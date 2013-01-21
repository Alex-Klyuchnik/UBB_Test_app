using System;
using System.Windows.Forms;
using UBB_Test_app.DB;
using UBB_Test_app.Features;

namespace UBB_Test_app.Forms
{
    public partial class DeletePersonForm : Form
    {
        public DeletePersonForm()
        {
            InitializeComponent();
        }

        private void DeletePersonButton_Click(object sender, EventArgs e)
        {
            InputSanitizer inputSanitizer = new InputSanitizer();
            DBActions dbActions = new DBActions();
            int id = Convert.ToInt32(inputSanitizer.DigitsOnly(IDTextBox.Text));
            string msg = dbActions.PersonDelete(id);
            MessageBox.Show(msg, "Client message");
        }
    }
}
