using System;
using System.Windows.Forms;
using UBB_Test_app.DB;
using UBB_Test_app.Entities;

namespace UBB_Test_app
{
    public partial class AddPeopleForm : Form
    {
        public AddPeopleForm()
        {
            InitializeComponent();
        }

        private void AddPeopleButton_Click(object sender, EventArgs e)
        {
            Person addedPerson = new Person();
            addedPerson.FIO = FIOTextBox.Text;
            addedPerson.CityId = Convert.ToInt32(CityIDTextBox.Text);

            DBActions dbActions = new DBActions();
            string res = dbActions.PersonAdd(addedPerson);
            MessageBox.Show(res,"Client message");
        }
    }
}
