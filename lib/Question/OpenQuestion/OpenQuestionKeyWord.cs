using System.Collections.Generic;
using lib.Question.OpenQuestion.AnswerConfigurator;
using System.Linq;

namespace lib.Question.OpenQuestion
{
    public class OpenQuestionKeyWord : OpenQuestion 
    {
        public IList<string> KeyWords { get; set; }
        public int MinimumMatch { get; set; }
        public OpenQuestionKeyWord(
            string question, 
            IList<string> keywords, 
            int minimumMatch,
            IAnswerConfigurator options 
        )
        :base(question,options)
        {
            this.KeyWords = keywords
                .Select(phrase => 
                    this.Configurator.ConfigureAnswer(phrase)
                )
                .ToList();
            this.MinimumMatch = minimumMatch;
        }

        public override bool Answer(object answer)
        {
            var ans = this.Configurator.ConfigureAnswer((string)answer);
            var count=0;
            for (int i = 0; i < KeyWords.Count; i++)
            {
                if(ans.Contains(KeyWords[i]))
                    count++;
            }
            return count == MinimumMatch;
        }
    }
}
