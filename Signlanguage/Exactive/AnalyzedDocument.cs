using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Signlanguage
{
    public class AnalyzedDocument
    {
        public List<TextUnitScore> ScoredTextUnits { get; set; }

        public List<SentenceScore> ScoredSentences { get; set; }
    }
}