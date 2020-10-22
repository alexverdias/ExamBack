using System.Globalization;
using System.Text;

namespace lib.Question.OpenQuestion.AnswerConfigurator
{
    public class IgnoreAccentMarkConfigurator : IAnswerConfigurator
    {
        public string ConfigureAnswer(string answer)
        {
            var sbReturn = new StringBuilder();     
            var arrayText = answer.Normalize(NormalizationForm.FormD).ToCharArray();  
            foreach (char letter in arrayText){     
                if (CharUnicodeInfo.GetUnicodeCategory(letter) != UnicodeCategory.NonSpacingMark)  
                    sbReturn.Append(letter);     
            }     
            return sbReturn.ToString();  
        }
    }

}
