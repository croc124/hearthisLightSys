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

namespace HearThis.Script
{
	/// <summary>
	/// This exposes the things we care about out of ScrText, providing an
	/// anti-corruption layer between Paratext and HearThis and allowing us to test the code
	/// that calls Paratext.
	/// </summary>
	public interface IScripture : IScrProjectSettings
	{
		ScrVers Versification { get; }
		List<UsfmToken> GetUsfmTokens(VerseRef verseRef, bool singleChapter);
		IScrParserState CreateScrParserState(VerseRef verseRef);
		string DefaultFont { get; }
		string EthnologueCode { get; }
		string Name { get; }
	}

	/// <summary>
	/// This exposes the things we care about out of ScrText, providing an
	/// anti-corruption layer between Paratext and HearThis and allowing us to test the code
	/// that calls Paratext.
	/// </summary>
	public interface IScrProjectSettings
	{
		string FirstLevelStartQuotationMark { get; }
		string FirstLevelEndQuotationMark { get; }
		string SecondLevelStartQuotationMark { get; }
		string SecondLevelEndQuotationMark { get; }
		string ThirdLevelStartQuotationMark { get; }
		string ThirdLevelEndQuotationMark { get; }
	}
}