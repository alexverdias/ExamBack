using lib.Question.OpenQuestion.AnswerConfigurator;

namespace lib.Question.OpenQuestion
{
    public class OpenQuestionSingleAns : OpenQuestion{
        public string ValidAnswer { get; set; }
        public OpenQuestionSingleAns(
            string question, 
            string answer,
            IAnswerConfigurator options 
        )
        :base(question,options)
        {
            ValidAnswer = options.ConfigureAnswer(answer);
        }

        public override bool Answer(object answer)
        {
            return this
                .Configurator
                .ConfigureAnswer(
                    (string)answer
                )
                .Equals(ValidAnswer);
        }
    }
}