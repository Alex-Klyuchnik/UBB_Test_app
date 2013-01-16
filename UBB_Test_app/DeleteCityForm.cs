using System;
using System.Windows.Forms;
using UBB_Test_app.DB;

namespace UBB_Test_app
{
    public partial class DeleteCityForm : Form
    {
        public DeleteCityForm()
        {
            InitializeComponent();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDTextBox.Text);
            DBActions dbActions = new DBActions();
            string msg = dbActions.Delete(id);
            MessageBox.Show(msg);
        }
    }
}
