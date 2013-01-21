using System;
using System.Windows.Forms;
using UBB_Test_app.DB;
using UBB_Test_app.Features;

namespace UBB_Test_app.Forms
{
    public partial class DeleteCityForm : Form
    {
        public DeleteCityForm()
        {
            InitializeComponent();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            InputSanitizer inputSanitizer = new InputSanitizer();

            int id = Convert.ToInt32(inputSanitizer.DigitsOnly(IDTextBox.Text));
            DBActions dbActions = new DBActions();
            string msg = dbActions.DeleteCity(id);
            MessageBox.Show(msg);
        }
    }
}
