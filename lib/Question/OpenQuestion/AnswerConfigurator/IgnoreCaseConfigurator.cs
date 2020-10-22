namespace lib.Question.OpenQuestion.AnswerConfigurator
{
    public class IgnoreCaseConfigurator : IAnswerConfigurator
    {
        string IAnswerConfigurator.ConfigureAnswer(string answer)
        {
            return answer.ToLower();
        }
    }

}
