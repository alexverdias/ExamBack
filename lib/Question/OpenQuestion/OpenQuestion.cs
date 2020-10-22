
using System.Collections.Generic;
using lib.Question.OpenQuestion.AnswerConfigurator;

namespace lib.Question.OpenQuestion
{
    
    public abstract class OpenQuestion : IQuestion
    {        
        public string Question { get; set; }
        public IAnswerConfigurator Configurator { get; set; }
        public OpenQuestion(string question,IAnswerConfigurator configurator)
        {
            this.Question = question;
            this.Configurator = configurator;        
        }
        public abstract bool Answer(object answer);
    }
}
