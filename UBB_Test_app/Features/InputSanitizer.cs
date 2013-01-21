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
            
            //TODO Remove after debug!
            MessageBox.Show(output);

            return output;
        }
    }
}
