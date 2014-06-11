using System;
using System.Linq;
using System.Windows.Forms;
using HearThis.Publishing;

namespace HearThis.Script
{
	public class BookInfo
	{
		private readonly string _projectName;
		private readonly string _name;
		public readonly int ChapterCount;

		/// <summary>
		/// [0] == intro, [1] == chapter 1, etc.
		/// </summary>
		private readonly IScriptProvider _scriptProvider;

		public BookInfo(string projectName, int number, IScriptProvider scriptProvider)
		{
			BookNumber = number;
			_projectName = projectName;
			_name = Project.Statistics.BookNames.ElementAt(number);
			ChapterCount = Project.Statistics.GetChaptersInBook(number);
			_scriptProvider = scriptProvider;
			GetLineMethod = ((chapter, line) => _scriptProvider.GetLine(number, chapter, line));
		}

		public string LocalizedName
		{
			// TODO: Implement this - probably as part of making this a Paratext plugin
			get { return _name; }
		}

		public int BookNumber { get; private set; }

		public bool HasVerses
		{
			get
			{
				//at the moment, we just look for verses in the first chapter

				for (int i = 0; i < new BibleStats().GetChaptersInBook(BookNumber); i++)
				{
					if (_scriptProvider.GetTranslatedVerseCount(BookNumber, i + 1) >0)
					{
						return true;
					}
				}
				return false;
			}
		}

		public Func<int, int, ScriptLine> GetLineMethod { get; set; }

//        /// <summary>
//        /// bool HasVersesMethod(chapter)
//        /// </summary>
//        public Func<int, int> VerseCountMethod { get; set; }

		public string Name
		{
			get { return _name; }
		}

		public bool HasIntroduction
		{
			get { return _scriptProvider.GetScriptLineCount(BookNumber, 0) >0; }
		}

		internal string ProjectName
		{
			get { return _projectName; }
		}

		internal IScriptProvider ScriptProvider
		{
			get { return _scriptProvider; }
		}

		/// <summary>
		/// Gets intro or chapter 1, whichever comes first
		/// </summary>
		/// <returns></returns>
		public ChapterInfo GetFirstChapter()
		{
			if(HasIntroduction)
				return GetChapter(0);
			return GetChapter(1);
		}

		public virtual ChapterInfo GetChapter(int chapterOneBased)
		{
			// REVIEW: creating it new each time could lead to failed attempts to cache chapter information
			return ChapterInfo.Create(this, chapterOneBased);
		}

		public int CalculatePercentageRecorded()
		{
			int scriptLineCount = _scriptProvider.GetScriptLineCount(BookNumber);
			if (scriptLineCount == 0)
				return 0; //should it be 0 or 100 or -1 or what?
			int countOfRecordingsForBook = LineRecordingRepository.GetCountOfRecordingsForBook(ProjectName, Name);
			if (countOfRecordingsForBook == 0)
				return 0;
			return Math.Max(1, (int)(100.0 * countOfRecordingsForBook / scriptLineCount));
		}

		public int CalculatePercentageTranslated()
		{
			//todo

			if (_scriptProvider.GetTranslatedVerseCount(BookNumber, 1) > 0)
				return 100;
			return 0;
		}


		public void MakeDummyRecordings()
		{
			Cursor.Current = Cursors.WaitCursor;
			for (int c = 0 /*0 is introduction*/; c <= ChapterCount; c++)
			{
				GetChapter(c).MakeDummyRecordings();
			}
			Cursor.Current = Cursors.Default;
		}

		/// <summary>
		/// Virtual for testing
		/// </summary>
		public virtual string GetChapterFolder(int chapterNumber)
		{
			return LineRecordingRepository.GetChapterFolder(_projectName, _name, chapterNumber);
		}

		public virtual int GetCountOfRecordingsForChapter(int chapterNumber)
		{
			return LineRecordingRepository.GetCountOfRecordingsForChapter(_projectName, Name, chapterNumber);
		}
	}
}
