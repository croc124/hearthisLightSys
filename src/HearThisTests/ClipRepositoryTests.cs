using System;
using System.Collections.Generic;
using System.IO;
using HearThis.Publishing;
using HearThis.Script;
using NUnit.Framework;
using Palaso.IO;

namespace HearThisTests
{
	[TestFixture]
	public class ClipRepositoryTests
	{
		private class DummyInfoProvider : IPublishingInfoProvider
		{
			private IBibleStats _stats = new BibleStats();
			public List<string> Verses = new List<string>( new [] {null, "1"});
			public string Name { get { return "Dummy"; } }
			public string EthnologueCode { get { return "xdum"; } }
			public ScriptLine GetBlock(string bookName, int chapterNumber, int lineNumber0Based)
			{
				var scriptLineNumber = lineNumber0Based + 1;
				bool heading;
				string verse;
				if (lineNumber0Based < Verses.Count)
				{
					verse = Verses[lineNumber0Based];
					heading = verse == null;
				}
				else
				{
					verse = null;
					heading = true;
				}
				return new ScriptLine
				{
					Number = scriptLineNumber,
					Verse = verse,
					Heading = heading,
				};
			}

			public IBibleStats VersificationInfo { get { return _stats; } }
		}

		/// <summary>
		/// regression
		/// </summary>
		[Test, Ignore("known to fail")]
		public void MergeAudioFiles_DifferentChannels_StillMerges()
		{
			using (var output = new TempFile())
			using (var mono = TempFile.FromResource(Resource1._1Channel, ".wav"))
			using (var stereo = TempFile.FromResource(Resource1._2Channel, ".wav"))
			{
				var filesToJoin = new List<string>();
				filesToJoin.Add(mono.Path);
				filesToJoin.Add(stereo.Path);
				var progress = new Palaso.Progress.StringBuilderProgress();

				ClipRepository.MergeAudioFiles(filesToJoin, output.Path, progress);
				Assert.IsFalse(progress.ErrorEncountered);
				Assert.IsTrue(File.Exists(output.Path));
			}
		}

		[Test]
		public void MergeAudioFiles_SingleFile_CopiedToOutputPath()
		{
			using (var output = new TempFile())
			using (var mono = TempFile.FromResource(Resource1._1Channel, ".wav"))
			{
				var filesToJoin = new List<string>();
				filesToJoin.Add(mono.Path);
				var progress = new Palaso.Progress.StringBuilderProgress();

				ClipRepository.MergeAudioFiles(filesToJoin, output.Path, progress);
				Assert.IsFalse(progress.ErrorEncountered);
				Assert.IsTrue(File.Exists(output.Path));
				Assert.AreEqual(File.ReadAllBytes(mono.Path), File.ReadAllBytes(output.Path));
			}
		}

		[Test]
		public void PublishVerseIndexFiles_VerseIndexFormatNone_ExistingFileGetsDeleted()
		{
			var publishingModel = new PublishingModel(new DummyInfoProvider());
			var rootPath = Path.GetTempPath();
			const string bookName = "Psalms";
			const int chapterNumber = 5;
			var outputPath = Path.ChangeExtension(
				publishingModel.PublishingMethod.GetFilePathWithoutExtension(rootPath, bookName, chapterNumber), "txt");
			using (var output = new TempFile(outputPath, true))
			{
				var progress = new Palaso.Progress.StringBuilderProgress();

				File.Create(outputPath).Close();
				Assert.IsTrue(File.Exists(outputPath));
				ClipRepository.PublishVerseIndexFiles(rootPath, bookName, chapterNumber, new string[0], publishingModel, progress);
				Assert.IsFalse(progress.ErrorEncountered);
				Assert.IsFalse(File.Exists(outputPath));
			}
		}

		[Test]
		public void PublishVerseIndexFiles_AudacityLabelFileDoesNotExist_Created()
		{
			var publishingModel = new PublishingModel(new DummyInfoProvider());
			publishingModel.verseIndexFormat = PublishingModel.VerseIndexFormat.AudacityLabelFile;
			var rootPath = Path.GetTempPath();
			const string bookName = "Psalms";
			const int chapterNumber = 5;
			var outputPath = Path.ChangeExtension(
				publishingModel.PublishingMethod.GetFilePathWithoutExtension(rootPath, bookName, chapterNumber), "txt");
			using (new TempFile(outputPath, false))
			using (var mono = TempFile.FromResource(Resource1._1Channel, ".wav"))
			using (var file1 = TempFile.WithFilename("1.wav"))
			{
				File.Copy(mono.Path, file1.Path, true);
				var filesToJoin = new string[1];
				filesToJoin[0] = file1.Path;
				var progress = new Palaso.Progress.StringBuilderProgress();

				Assert.IsFalse(File.Exists(outputPath));
				ClipRepository.PublishVerseIndexFiles(rootPath, bookName, chapterNumber, filesToJoin, publishingModel, progress);
				Assert.IsFalse(progress.ErrorEncountered);
				Assert.IsTrue(File.Exists(outputPath));
				Assert.IsTrue(File.ReadAllText(outputPath).Length > 0);
			}
		}

		[Test]
		public void PublishVerseIndexFiles_CueSheetDoesNotExist_Created()
		{
			var publishingModel = new PublishingModel(new DummyInfoProvider());
			publishingModel.verseIndexFormat = PublishingModel.VerseIndexFormat.CueSheet;
			var rootPath = Path.GetTempPath();
			const string bookName = "Psalms";
			const int chapterNumber = 5;
			var outputPath = Path.ChangeExtension(
				publishingModel.PublishingMethod.GetFilePathWithoutExtension(rootPath, bookName, chapterNumber), "txt");
			using (new TempFile(outputPath, false))
			using (var mono = TempFile.FromResource(Resource1._1Channel, ".wav"))
			using (var file1 = TempFile.WithFilename("1.wav"))
			{
				File.Copy(mono.Path, file1.Path, true);
				var filesToJoin = new string[1];
				filesToJoin[0] = file1.Path;
				var progress = new Palaso.Progress.StringBuilderProgress();

				Assert.IsFalse(File.Exists(outputPath));
				ClipRepository.PublishVerseIndexFiles(rootPath, bookName, chapterNumber, filesToJoin, publishingModel, progress);
				Assert.IsFalse(progress.ErrorEncountered);
				Assert.IsTrue(File.Exists(outputPath));
				Assert.IsTrue(File.ReadAllText(outputPath).Length > 0);
			}
		}

		[Test]
		public void GetAudacityLabelFileContents_ConsecutiveClipsTwoHeadingThreeVerses_ContentsAreCorrect()
		{
			var publishingInfoProvider = new DummyInfoProvider();
			publishingInfoProvider.Verses.Add("2-3");
			publishingInfoProvider.Verses.Add(null);
			publishingInfoProvider.Verses.Add("4");
			using (var mono = TempFile.FromResource(Resource1._1Channel, ".wav"))
			using (var file0 = TempFile.WithFilename("0.wav"))
			using (var file1 = TempFile.WithFilename("1.wav"))
			using (var file2 = TempFile.WithFilename("2.wav"))
			using (var file3 = TempFile.WithFilename("3.wav"))
			using (var file4 = TempFile.WithFilename("4.wav"))
			{
				File.Copy(mono.Path, file0.Path, true);
				File.Copy(mono.Path, file1.Path, true);
				File.Copy(mono.Path, file2.Path, true);
				File.Copy(mono.Path, file3.Path, true);
				File.Copy(mono.Path, file4.Path, true);
				var filesToJoin = new[] { file0.Path, file1.Path, file2.Path, file3.Path, file4.Path };

				var result = ClipRepository.GetAudacityLabelFileContents(filesToJoin, publishingInfoProvider, "Psalms", 5);
				var lines = result.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
				int i = 0;
				Assert.AreEqual("0\t0.062\ts1", lines[i++]);
				Assert.AreEqual("0.062\t0.124\t1", lines[i++]);
				Assert.AreEqual("0.124\t0.186\t2-3", lines[i++]);
				Assert.AreEqual("0.186\t0.248\ts2", lines[i++]);
				Assert.AreEqual("0.248\t0.31\t4", lines[i]);
			}
		}

		[Test]
		public void GetAudacityLabelFileContents_SkippedClips_UnrecordedVersesNotLabeled()
		{
			var publishingInfoProvider = new DummyInfoProvider();
			publishingInfoProvider.Verses.Add("2-3"); // Skipped
			publishingInfoProvider.Verses.Add(null); // Skipped
			publishingInfoProvider.Verses.Add("4");
			using (var mono = TempFile.FromResource(Resource1._1Channel, ".wav"))
			using (var file0 = TempFile.WithFilename("0.wav"))
			using (var file1 = TempFile.WithFilename("1.wav"))
			using (var file4 = TempFile.WithFilename("4.wav"))
			{
				File.Copy(mono.Path, file0.Path, true);
				File.Copy(mono.Path, file1.Path, true);
				File.Copy(mono.Path, file4.Path, true);
				var filesToJoin = new[] { file0.Path, file1.Path, file4.Path };

				var result = ClipRepository.GetAudacityLabelFileContents(filesToJoin, publishingInfoProvider, "Psalms", 5);
				var lines = result.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
				int i = 0;
				Assert.AreEqual("0\t0.062\ts1", lines[i++]);
				Assert.AreEqual("0.062\t0.124\t1", lines[i++]);
				Assert.AreEqual("0.124\t0.186\t4", lines[i]);
			}
		}

		[Test]
		public void GetAudacityLabelFileContents_MultipleClipsPerVerse_LabelIndicatesStartOfFirstClipForEachVerse()
		{
			var publishingInfoProvider = new DummyInfoProvider();
			publishingInfoProvider.Verses.Add("1");
			publishingInfoProvider.Verses.Add("2-3");
			publishingInfoProvider.Verses.Add("2-3");
			publishingInfoProvider.Verses.Add("2-3");
			publishingInfoProvider.Verses.Add("3"); // REVIEW: Desired result not yet certain
			using (var mono = TempFile.FromResource(Resource1._1Channel, ".wav"))
			using (var file0 = TempFile.WithFilename("0.wav"))
			using (var file1 = TempFile.WithFilename("1.wav"))
			using (var file2 = TempFile.WithFilename("2.wav"))
			using (var file3 = TempFile.WithFilename("3.wav"))
			using (var file4 = TempFile.WithFilename("4.wav"))
			using (var file5 = TempFile.WithFilename("5.wav"))
			using (var file6 = TempFile.WithFilename("6.wav"))
			{
				File.Copy(mono.Path, file0.Path, true);
				File.Copy(mono.Path, file1.Path, true);
				File.Copy(mono.Path, file2.Path, true);
				File.Copy(mono.Path, file3.Path, true);
				File.Copy(mono.Path, file4.Path, true);
				File.Copy(mono.Path, file5.Path, true);
				File.Copy(mono.Path, file6.Path, true);
				var filesToJoin = new[] { file0.Path, file1.Path, file2.Path, file3.Path, file4.Path, file5.Path, file6.Path };

				var result = ClipRepository.GetAudacityLabelFileContents(filesToJoin, publishingInfoProvider, "Psalms", 5);
				var lines = result.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
				int i = 0;
				Assert.AreEqual("0\t0.062\ts1", lines[i++]);
				Assert.AreEqual("0.062\t0.186\t1", lines[i++]); // Includes 2 clips
				Assert.AreEqual("0.186\t0.372\t2-3", lines[i++]); // Includes 3 clips
				Assert.AreEqual("0.372\t0.434\t3", lines[i]);
			}
		}

		[Test]
		public void GetAudacityLabelFileContents_ConsecutiveHeadingClips_HeadingsCoalesced()
		{
			var publishingInfoProvider = new DummyInfoProvider();
			publishingInfoProvider.Verses[0] = null;
			publishingInfoProvider.Verses[1] = null;
			publishingInfoProvider.Verses.Add(null); // Three consecutive headings
			publishingInfoProvider.Verses.Add("1-2");
			publishingInfoProvider.Verses.Add(null);
			publishingInfoProvider.Verses.Add(null); // Two consecutive headings
			publishingInfoProvider.Verses.Add("3");
			using (var mono = TempFile.FromResource(Resource1._1Channel, ".wav"))
			using (var file0 = TempFile.WithFilename("0.wav")) // Heading 1a
			using (var file1 = TempFile.WithFilename("1.wav")) // Heading 1b
			using (var file2 = TempFile.WithFilename("2.wav")) // Heading 1c
			using (var file3 = TempFile.WithFilename("3.wav"))
			using (var file4 = TempFile.WithFilename("4.wav")) // Heading 2a
			using (var file5 = TempFile.WithFilename("5.wav")) // Heading 2b
			using (var file6 = TempFile.WithFilename("6.wav"))
			{
				File.Copy(mono.Path, file0.Path, true);
				File.Copy(mono.Path, file1.Path, true);
				File.Copy(mono.Path, file2.Path, true);
				File.Copy(mono.Path, file3.Path, true);
				File.Copy(mono.Path, file4.Path, true);
				File.Copy(mono.Path, file5.Path, true);
				File.Copy(mono.Path, file6.Path, true);
				var filesToJoin = new[] { file0.Path, file1.Path, file2.Path, file3.Path, file4.Path, file5.Path, file6.Path };

				var result = ClipRepository.GetAudacityLabelFileContents(filesToJoin, publishingInfoProvider, "Psalms", 5);
				var lines = result.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
				int i = 0;
				Assert.AreEqual("0\t0.186\ts1", lines[i++]); // Includes 3 clips
				Assert.AreEqual("0.186\t0.248\t1-2", lines[i++]);
				Assert.AreEqual("0.248\t0.372\ts2", lines[i++]); // Includes 2 clips
				Assert.AreEqual("0.372\t0.434\t3", lines[i]);
			}
		}

		[Test]
		[Ignore("Cue sheet implementation could not be completed due to lack of design/use case")]
		public void GetCueSheetContents_ConsecutiveClipsTwoHeadingThreeVerses_ContentsAreCorrect()
		{
			var publishingInfoProvider = new DummyInfoProvider();
			publishingInfoProvider.Verses.Add("2-3");
			publishingInfoProvider.Verses.Add(null);
			publishingInfoProvider.Verses.Add("4");
			using (var mono = TempFile.FromResource(Resource1._1Channel, ".wav"))
			using (var file0 = TempFile.WithFilename("0.wav"))
			using (var file1 = TempFile.WithFilename("1.wav"))
			using (var file2 = TempFile.WithFilename("2.wav"))
			using (var file3 = TempFile.WithFilename("3.wav"))
			using (var file4 = TempFile.WithFilename("4.wav"))
			{
				File.Copy(mono.Path, file0.Path, true);
				File.Copy(mono.Path, file1.Path, true);
				File.Copy(mono.Path, file2.Path, true);
				File.Copy(mono.Path, file3.Path, true);
				File.Copy(mono.Path, file4.Path, true);
				var filesToJoin = new[] { file0.Path, file1.Path, file2.Path, file3.Path, file4.Path };

				var result = ClipRepository.GetCueSheetContents(filesToJoin, publishingInfoProvider, "Psalms", 5, "PSA5.wav");
				var lines = result.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
				int i = 0;
				Assert.AreEqual("FILE \"PSA5.wav\"", lines[i++]);
				Assert.AreEqual("TRACK 01 AUDIO", lines[i++]);
				Assert.AreEqual("  TITLE \"psa005-xdum-s1\"", lines[i++]);
				Assert.AreEqual("  INDEX 01 00:00:00", lines[i++]);
				Assert.AreEqual("TRACK 02 AUDIO", lines[i++]);
				Assert.AreEqual("  TITLE \"00000-psa005-xdum-V001\"", lines[i++]);
				Assert.AreEqual("  INDEX 01 00:00:05", lines[i++]);
				Assert.AreEqual("TRACK 03 AUDIO", lines[i++]);
				Assert.AreEqual("  TITLE \"00000-psa005-xdum-V002-003\"", lines[i++]);
				Assert.AreEqual("  INDEX 01 00:00:09", lines[i++]);
				Assert.AreEqual("0.062\t0.124\t1", lines[i++]);
				Assert.AreEqual("0.124\t0.186\t2-3", lines[i++]);
				Assert.AreEqual("0.186\t0.248\ts2", lines[i++]);
				Assert.AreEqual("0.248\t0.31\t4", lines[i]);
			}
		}

		[Test]
		[Ignore("Cue sheet implementation could not be completed due to lack of design/use case")]
		public void GetCueSheetContents_SkippedClips_UnrecordedVersesNotLabeled()
		{
			var publishingInfoProvider = new DummyInfoProvider();
			publishingInfoProvider.Verses.Add("2-3"); // Skipped
			publishingInfoProvider.Verses.Add(null); // Skipped
			publishingInfoProvider.Verses.Add("4");
			using (var mono = TempFile.FromResource(Resource1._1Channel, ".wav"))
			using (var file0 = TempFile.WithFilename("0.wav"))
			using (var file1 = TempFile.WithFilename("1.wav"))
			using (var file4 = TempFile.WithFilename("4.wav"))
			{
				File.Copy(mono.Path, file0.Path, true);
				File.Copy(mono.Path, file1.Path, true);
				File.Copy(mono.Path, file4.Path, true);
				var filesToJoin = new[] { file0.Path, file1.Path, file4.Path };

				var result = ClipRepository.GetCueSheetContents(filesToJoin, publishingInfoProvider, "Psalms", 5, "PSA5.wav");
				var lines = result.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
				int i = 0;
				Assert.AreEqual("FILE \"PSA5.wav\"", lines[i++]);
				Assert.AreEqual("0\t0.062\ts1", lines[i++]);
				Assert.AreEqual("0.062\t0.124\t1", lines[i++]);
				Assert.AreEqual("0.124\t0.186\t4", lines[i]);
			}
		}

		[Test]
		[Ignore("Cue sheet implementation could not be completed due to lack of design/use case")]
		public void GetCueSheetContents_MultipleClipsPerVerse_LabelIndicatesStartOfFirstClipForEachVerse()
		{
			var publishingInfoProvider = new DummyInfoProvider();
			publishingInfoProvider.Verses.Add("1");
			publishingInfoProvider.Verses.Add("2-3");
			publishingInfoProvider.Verses.Add("2-3");
			publishingInfoProvider.Verses.Add("2-3");
			publishingInfoProvider.Verses.Add("3"); // REVIEW: Desired result not yet certain
			using (var mono = TempFile.FromResource(Resource1._1Channel, ".wav"))
			using (var file0 = TempFile.WithFilename("0.wav"))
			using (var file1 = TempFile.WithFilename("1.wav"))
			using (var file2 = TempFile.WithFilename("2.wav"))
			using (var file3 = TempFile.WithFilename("3.wav"))
			using (var file4 = TempFile.WithFilename("4.wav"))
			using (var file5 = TempFile.WithFilename("5.wav"))
			using (var file6 = TempFile.WithFilename("6.wav"))
			{
				File.Copy(mono.Path, file0.Path, true);
				File.Copy(mono.Path, file1.Path, true);
				File.Copy(mono.Path, file2.Path, true);
				File.Copy(mono.Path, file3.Path, true);
				File.Copy(mono.Path, file4.Path, true);
				File.Copy(mono.Path, file5.Path, true);
				File.Copy(mono.Path, file6.Path, true);
				var filesToJoin = new[] { file0.Path, file1.Path, file2.Path, file3.Path, file4.Path, file5.Path, file6.Path };

				var result = ClipRepository.GetCueSheetContents(filesToJoin, publishingInfoProvider, "Psalms", 5, "PSA5.wav");
				var lines = result.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
				int i = 0;
				Assert.AreEqual("FILE \"PSA5.wav\"", lines[i++]);
				Assert.AreEqual("0\t0.062\ts1", lines[i++]);
				Assert.AreEqual("0.062\t0.186\t1", lines[i++]); // Includes 2 clips
				Assert.AreEqual("0.186\t0.372\t2-3", lines[i++]); // Includes 3 clips
				Assert.AreEqual("0.372\t0.434\t3", lines[i]);
			}
		}

		[Test]
		[Ignore("Cue sheet implementation could not be completed due to lack of design/use case")]
		public void GetCueSheetContents_ConsecutiveHeadingClips_HeadingsCoalesced()
		{
			var publishingInfoProvider = new DummyInfoProvider();
			publishingInfoProvider.Verses[0] = null;
			publishingInfoProvider.Verses[1] = null;
			publishingInfoProvider.Verses.Add(null); // Three consecutive headings
			publishingInfoProvider.Verses.Add("1-2");
			publishingInfoProvider.Verses.Add(null);
			publishingInfoProvider.Verses.Add(null); // Two consecutive headings
			publishingInfoProvider.Verses.Add("3");
			using (var mono = TempFile.FromResource(Resource1._1Channel, ".wav"))
			using (var file0 = TempFile.WithFilename("0.wav")) // Heading 1a
			using (var file1 = TempFile.WithFilename("1.wav")) // Heading 1b
			using (var file2 = TempFile.WithFilename("2.wav")) // Heading 1c
			using (var file3 = TempFile.WithFilename("3.wav"))
			using (var file4 = TempFile.WithFilename("4.wav")) // Heading 2a
			using (var file5 = TempFile.WithFilename("5.wav")) // Heading 2b
			using (var file6 = TempFile.WithFilename("6.wav"))
			{
				File.Copy(mono.Path, file0.Path, true);
				File.Copy(mono.Path, file1.Path, true);
				File.Copy(mono.Path, file2.Path, true);
				File.Copy(mono.Path, file3.Path, true);
				File.Copy(mono.Path, file4.Path, true);
				File.Copy(mono.Path, file5.Path, true);
				File.Copy(mono.Path, file6.Path, true);
				var filesToJoin = new[] { file0.Path, file1.Path, file2.Path, file3.Path, file4.Path, file5.Path, file6.Path };

				var result = ClipRepository.GetCueSheetContents(filesToJoin, publishingInfoProvider, "Psalms", 5, "PSA5.wav");
				var lines = result.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
				int i = 0;
				Assert.AreEqual("FILE \"PSA5.wav\"", lines[i++]);
				Assert.AreEqual("0\t0.186\ts1", lines[i++]); // Includes 3 clips
				Assert.AreEqual("0.186\t0.248\t1-2", lines[i++]);
				Assert.AreEqual("0.248\t0.372\ts2", lines[i++]); // Includes 2 clips
				Assert.AreEqual("0.372\t0.434\t3", lines[i]);
			}
		}
	}
}
