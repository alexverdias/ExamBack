using System;
using lib.Question.OpenQuestion;
using lib.Question.ClosedQuestion;
using lib.Question.OpenQuestion.AnswerConfigurator;

namespace exe
{
    class Program
    {
        static void Main(string[] args)
        {
            var question = "¿Nombre de Mexico?";
            var ans = "EUM";
            var configurator = new AnswerConfigurator(
                OpenAnswerOptions.IgnoreCase
                |OpenAnswerOptions.IgnoreAccentMark
            );
            //var configurator = new AnswerConfigurator(OpenAnswerOptions.IgnoreAccentMark);
            var openQ = new OpenQuestionSingleAns(question,ans,configurator);
            Console.WriteLine(openQ.Answer(args[0]));
            //Console.WriteLine(openQ.Answer("eum"));
        }
    }
}
