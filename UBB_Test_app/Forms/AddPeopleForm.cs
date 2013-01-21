using System;
using System.Windows.Forms;
using UBB_Test_app.DB;
using UBB_Test_app.Entities;
using UBB_Test_app.Features;
using UBB_Test_app.Properties;

namespace UBB_Test_app.Forms
{
    public partial class AddPeopleForm : Form
    {
        public AddPeopleForm()
        {
            InitializeComponent();
        }

        private void AddPeopleButton_Click(object sender, EventArgs e)
        {
            InputSanitizer  inputSanitizer = new InputSanitizer();
            Person addedPerson = new Person();
            addedPerson.FIO = inputSanitizer.Names(FIOTextBox.Text);
            try
            {
                addedPerson.CityId = Convert.ToInt32(inputSanitizer.DigitsOnly(CityIDTextBox.Text));
                DBActions dbActions = new DBActions();
                string res = dbActions.PersonAdd(addedPerson);
                MessageBox.Show(res, "Client message");
            }

            catch (Exception ex)
            {
                MessageBox.Show(Resources.IdIncorrect + ex.Message); 
            }
        }
    }
}
