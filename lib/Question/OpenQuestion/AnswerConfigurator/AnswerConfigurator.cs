using System;
using System.Collections.Generic;
using System.Linq;

namespace lib.Question.OpenQuestion.AnswerConfigurator
{
    public class AnswerConfigurator : IAnswerConfigurator
    {
        public OpenAnswerOptions Options { get; set; }
        private IEnumerable<IAnswerConfigurator> Configurations;
        public AnswerConfigurator(OpenAnswerOptions options)
        {
            this.Options = options;
            
            if(options.HasFlag(OpenAnswerOptions.None))
                this.Configurations = new List<IAnswerConfigurator>();
            else{
                var selectedOptions = options.ToString().Split(',');
                Configurations = selectedOptions.Select( 
                    option =>  
                    {
                        var tmpType = Type.GetType($"lib.Question.OpenQuestion.AnswerConfigurator.{option.Trim()}Configurator");
                        return (IAnswerConfigurator)Activator.CreateInstance(tmpType);
                    }                    
                );
            }
        }
        public string ConfigureAnswer(string answer)
        {
            if(this.Configurations.Count() == 0)
            {
                return answer;
            }
            else{
                var result = answer;
                foreach (var config in this.Configurations)
                {
                    result = config.ConfigureAnswer(result);
                }
                return result;
            }
        }
    }



}
