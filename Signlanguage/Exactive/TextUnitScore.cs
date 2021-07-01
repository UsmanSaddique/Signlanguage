using System;
using System.Diagnostics;

namespace Signlanguage
{

    [DebuggerDisplay("Value: {ScoredTextUnit.FormattedValue} - Stem: {ScoredTextUnit.Stem} - Score: {Score}")]
    public class TextUnitScore
    {
        public TextUnit ScoredTextUnit { get; set; }

        public Double Score { get; set; }
    }
}