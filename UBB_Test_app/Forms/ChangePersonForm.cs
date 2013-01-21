using System;
using System.Windows.Forms;
using UBB_Test_app.DB;
using UBB_Test_app.Entities;
using UBB_Test_app.Features;
using UBB_Test_app.Properties;

namespace UBB_Test_app
{
    public partial class ChangePersonForm : Form
    {
        public ChangePersonForm()
        {
            InitializeComponent();
        }

        private void ChangePersonButton_Click(object sender, EventArgs e)
        {
            Person changedPerson = new Person();
            DBActions dbActions = new DBActions();
            InputSanitizer inputSanitizer = new InputSanitizer();

            try
            {
                changedPerson.Id = Convert.ToInt32(inputSanitizer.DigitsOnly(IDTexbBox.Text));
                changedPerson.CityId = Convert.ToInt32(inputSanitizer.DigitsOnly(CityIDTextBox.Text));
                changedPerson.FIO = inputSanitizer.Names(FIOTextBox.Text);
                string msg = dbActions.PersonEdit(changedPerson);
                MessageBox.Show(msg, "Client message");
            }
            catch(Exception ex)
            {
                MessageBox.Show(Resources.IdIncorrect + ex.Message);
            }
        }
    }
}
