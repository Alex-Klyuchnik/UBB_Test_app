using System.Text.RegularExpressions;

namespace UBB_Test_app.Features
{
    public class InputSanitizer
    {
        public string DigitsOnly (string input)
        {
            string output = "";
            output = Regex.Replace(input, @"[^0-9]","");
            return output;
        }

        public string Names (string input)
        {
            string output = "";
            output = Regex.Replace(input, @"[^a-zA-Z0-9а-яА-Я\-\ ]","");
            return output;
        }
    }
}
