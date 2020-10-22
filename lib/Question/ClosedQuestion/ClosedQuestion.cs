using System.Collections.Generic;
using System.Linq;

namespace lib.Question.ClosedQuestion
{
    public abstract class ClosedQuestion : IQuestion{
        public string Question { get; set; }
        public IEnumerable<string> Options;
        public abstract bool Answer(object answer);

        public ClosedQuestion(string question, IEnumerable<string> options)
        {
            this.Question = question;
            this.Options = options.Select(opt => opt.ToLower());
        }
        public bool ValidOption(string option){
            if(Options.Any(opt => option == opt))
                return true;
            else
                throw new InvalidOptionException($"{option} is not a valid option");
        }

        public bool ValidOption(IEnumerable<string> selectedOptions){
            
            var invalid = selectedOptions
                .Where(selopt => 
                    !Options.Any(opt=> opt == selopt)
                );

            if(invalid.Count() == 0)
                return true;
            else
                throw new InvalidOptionException($"{string.Join(",",invalid)} is not a valid option");
        }
    }
}
