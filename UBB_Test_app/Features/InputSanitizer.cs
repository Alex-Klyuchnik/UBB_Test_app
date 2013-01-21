using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace UBB_Test_app.Features
{
    class InputSanitizer
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

            MessageBox.Show(output); //TODO remove after debug

            return output;
        }
    }
}
