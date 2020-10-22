using System.Collections.Generic;
using System.Linq;

namespace lib.Question.ClosedQuestion
{
    public class RadioClosedQuestion : ClosedQuestion
    {
        public string ValidAnswer { get; set; }
        public RadioClosedQuestion(
            string question, 
            IEnumerable<string> options, 
            string validAnswer
        ) : base(question,options)
        {
            this.ValidAnswer = validAnswer.ToLower();
        }

        public override bool Answer(object answer)
        {
            var ans = ((string)answer).ToLower();
            if(ValidOption(ans))
                return ans.ToLower().Equals(this.ValidAnswer);
            return false;            
        }
    }
}
