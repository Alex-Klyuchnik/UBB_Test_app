using System;
using System.Windows.Forms;
using UBB_Test_app.DB;
using UBB_Test_app.Entities;

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

            changedPerson.Id = Convert.ToInt32(IDTexbBox.Text);
            changedPerson.CityId = Convert.ToInt32(CityIDTextBox.Text);
            changedPerson.FIO = FIOTextBox.Text;

            string msg = dbActions.PersonEdit(changedPerson);
            MessageBox.Show(msg, "Client message");
        }
    }
}
