// --------------------------------------------------------------------------------------------
#region // Copyright (c) 2014, SIL International. All Rights Reserved.
// <copyright from='2011' to='2014' company='SIL International'>
//		Copyright (c) 2014, SIL International. All Rights Reserved.
//
//		Distributable under the terms of the MIT License (http://sil.mit-license.org/)
// </copyright>
#endregion
// --------------------------------------------------------------------------------------------
using System.Collections.Generic;
using Paratext;
using Paratext.Checking;

namespace HearThis.Script
{
	/// <summary>
	/// This is the real implementation of IScripture which implements the interface by
	/// wrapping a real ScrText.
	/// </summary>
	internal class ParatextScripture : IScripture
	{
		private ScrText _scrText;

		public ParatextScripture(ScrText text)
		{
			_scrText = text;
		}

		#region IScripture Members

		public ScrVers Versification
		{
			get { return _scrText.Versification; }
		}

		public List<UsfmToken> GetUsfmTokens(VerseRef verseRef, bool singleChapter)
		{
			var parser = _scrText.Parser;
			return parser.GetUsfmTokens(verseRef, singleChapter, true);
		}

		public IScrParserState CreateScrParserState(VerseRef verseRef)
		{
			return new ParserState(new ScrParserState(_scrText, verseRef));
		}

		public string DefaultFont
		{
			get { return _scrText.DefaultFont; }
		}

		public string EthnologueCode
		{
			get
			{
				var result = _scrText.LanguageID.Id;
				if (result != null)
					return result;
				// Seems like the above SHOULD return Paratext's idea of the language identifier.
				// In some cases it does. But in others it does not.
				// In at least some cases where it does not, it really does know the identifier,
				// and seems to fairly consistently put it in the FullName,
				// surrounded by square brackets.
				var name = _scrText.FullName;
				int openBracket = name.IndexOf('[');
				int closeBracket = name.IndexOf(']');
				if (closeBracket > openBracket && openBracket > 0)
					return name.Substring(openBracket + 1, closeBracket - openBracket - 1);
				return result;
			}
		}

		public string Name
		{
			get { return _scrText.Name; }
		}

		public string FirstLevelStartQuotationMark
		{
			get { return new QuotationRules(_scrText).QuotesBegin; }
		}

		public string FirstLevelEndQuotationMark
		{
			get { return new QuotationRules(_scrText).QuotesEnd; }
		}

		public string SecondLevelStartQuotationMark
		{
			get { return new QuotationRules(_scrText).InnerQuotesBegin; }
		}

		public string SecondLevelEndQuotationMark
		{
			get { return new QuotationRules(_scrText).InnerQuotesEnd; }
		}

		public string ThirdLevelStartQuotationMark
		{
			get { return new QuotationRules(_scrText).InnerInnerQuotesBegin; }
		}

		public string ThirdLevelEndQuotationMark
		{
			get { return new QuotationRules(_scrText).InnerInnerQuotesEnd; }
		}
		#endregion
	}
}
