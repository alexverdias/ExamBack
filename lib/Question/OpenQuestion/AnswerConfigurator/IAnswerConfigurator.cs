using System;

namespace lib.Question.OpenQuestion.AnswerConfigurator
{
    [Flags]
    public enum OpenAnswerOptions{
        None = 1,
        IgnoreCase = 2,
        IgnoreAccentMark = 4,
        IgnoreSpaces = 8
    }
    public interface IAnswerConfigurator{
        string ConfigureAnswer(string answer);
    }

}
