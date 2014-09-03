// --------------------------------------------------------------------------------------------
#region // Copyright (c) 2014, SIL International. All Rights Reserved.
// <copyright from='2011' to='2014' company='SIL International'>
//		Copyright (c) 2014, SIL International. All Rights Reserved.
//
//		Distributable under the terms of the MIT License (http://sil.mit-license.org/)
// </copyright>
#endregion
// --------------------------------------------------------------------------------------------
using System;
using System.IO;
using System.Windows.Forms;
using DesktopAnalytics;
using HearThis.Properties;
using HearThis.Script;
using HearThis.UI;
using L10NSharp;
using Palaso.IO;
using Palaso.Reporting;
using Paratext;

namespace HearThis
{
	internal static class Program
	{
		public const string kCompany = "SIL";
		public const string kProduct = "HearThis";

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			//bring in settings from any previous version
			if (Settings.Default.NeedUpgrade)
			{
				//see http://stackoverflow.com/questions/3498561/net-applicationsettingsbase-should-i-call-upgrade-every-time-i-load
				Settings.Default.Upgrade();
				Settings.Default.NeedUpgrade = false;
				Settings.Default.Save();
			}

			SetUpErrorHandling();
			SetupLocalization();

			if (args.Length == 1 && args[0].Trim() == "-afterInstall")
			{
				using (var dlg = new Palaso.UI.WindowsForms.ReleaseNotes.ShowReleaseNotesDialog(Resources.HearThis,  FileLocator.GetFileDistributedWithApplication( "releaseNotes.md")))
				{
					dlg.ShowDialog();
				}
			}

			string lastName = null;
			string emailAddress = null;

			if (Control.ModifierKeys == Keys.Control)
			{
				Settings.Default.Project = SampleScriptProvider.kProjectUiName;
			}
			else
			{

				try
				{
					ScrTextCollection.Initialize();
					var regData = RegistrationInfo.RegistrationData;
					lastName = regData.Name;
					emailAddress = regData.Email;
				}
				catch (Exception)
				{
					ErrorReport.NotifyUserOfProblem(
						LocalizationManager.GetString("Program.ParatextNotInstalled",
							"It looks like perhaps Paratext is not installed on this computer, or there is some other problem connecting to it. We'll set you up with a sample so you can play with HearThis, but you'll have to install Paratext to get any real work done here.",
							""));

					Settings.Default.Project = SampleScriptProvider.kProjectUiName;
				}
			}

			string firstName = null;
			if (lastName != null)
			{
				var split = lastName.LastIndexOf(" ", StringComparison.Ordinal);
				if (split > 0)
				{
					firstName = lastName.Substring(0, split);
					lastName = lastName.Substring(split + 1);
				}
			}
			var userInfo = new UserInfo { FirstName = firstName, LastName = lastName, UILanguageCode = LocalizationManager.UILanguageId, Email = emailAddress};

#if DEBUG
			// Always track if this is a debug build, but track to a different segment.io project
			const bool allowTracking = true;
			const string key = "pldi6z3n3vfz23czhano";
#else
			// If this is a release build, then allow an environment variable to be set to false
			// so that testers aren't generating false analytics
			string feedbackSetting = System.Environment.GetEnvironmentVariable("FEEDBACK");

			var allowTracking = string.IsNullOrEmpty(feedbackSetting) || feedbackSetting.ToLower() == "yes" || feedbackSetting.ToLower() == "true";

			const string key = "bh7aaqmlmd0bhd48g3ye";
#endif
			using (new Analytics(key, userInfo, allowTracking))
			{
				Application.Run(new Shell());
			}
		}

		private static void SetupLocalization()
		{
			var installedStringFileFolder = FileLocator.GetDirectoryDistributedWithApplication("localization");
			var targetTmxFilePath = Path.Combine(kCompany, kProduct);
			string desiredUiLangId = Settings.Default.UserInterfaceLanguage;
			LocalizationManager.Create(desiredUiLangId, "HearThis", Application.ProductName, Application.ProductVersion,
				installedStringFileFolder, targetTmxFilePath, Resources.HearThis, IssuesEmailAddress, "HearThis");
			// For now, do not set up localization for Palaso UI components etc.
			// Doing so introduces a large number of things to localize that are not actually used in HearThis, and few if any
			// that actually ARE used.
			//LocalizationManager.Create(desiredUiLangId, "Palaso", "Palaso", Application.ProductVersion, installedStringFileFolder,
			//						   targetTmxFilePath, Resources.HearThis, IssuesEmailAddress, "Palaso.UI");
		}

		/// <summary>
		/// The email address people should write to with problems (or new localizations?) for HearThis.
		/// </summary>
		public static string IssuesEmailAddress
		{
			get { return "issues@hearthis.palaso.org"; }
		}

		/// ------------------------------------------------------------------------------------
		private static void SetUpErrorHandling()
		{
			ErrorReport.EmailAddress = "issues@hearthis.palaso.org";
			ErrorReport.AddStandardProperties();
			ExceptionHandler.Init();
			ExceptionHandler.AddDelegate(ReportError);
		}

		private static void ReportError(object sender, CancelExceptionHandlingEventArgs e)
		{
			Analytics.ReportException(e.Exception);
		}
	}
}
