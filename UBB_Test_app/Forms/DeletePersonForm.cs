using System;
using System.Windows.Forms;
using UBB_Test_app.DB;

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
            DBActions dbActions = new DBActions();
            int id = Convert.ToInt32(IDTextBox.Text);
            string msg = dbActions.PersonDelete(id);
            MessageBox.Show(msg, "Client message");
        }
    }
}
