using System.Collections.Generic;
using System.Linq;

namespace lib.Question.ClosedQuestion
{
    public class MultipleClosedQuestion : ClosedQuestion{
        public IEnumerable<string> ValidAnswers { get; set; }
        public MultipleClosedQuestion(
            string question, 
            IEnumerable<string> options, 
            IEnumerable<string> validAnswers
        ) : base(question,options){
            this.ValidAnswers = validAnswers;
        }
        public override bool Answer(object answer)
        {
            var ans = ((IEnumerable<string>)answer)
                .Select(row => row.ToLower());
                
            if(ValidOption(ans))
                return ans.All(
                    current => this.ValidAnswers.Any(
                        valid => valid == current
                    )
                );
            else
                return false;
        }
    }
}
