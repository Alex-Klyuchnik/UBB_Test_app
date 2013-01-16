using System;
using System.Windows.Forms;
using UBB_Test_app.DB;
using UBB_Test_app.Entities;

namespace UBB_Test_app
{
    public partial class EditCityForm : Form
    {
        public EditCityForm()
        {
            InitializeComponent();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            City editedCity = new City();
            DBActions dbActions = new DBActions();

            editedCity.Id = Convert.ToInt32(IDTextBox.Text);
            editedCity.Name = NameTextBox.Text;
            editedCity.Region = RegionTextBox.Text;
            editedCity.Country = CountryTextBox.Text;
            editedCity.Attrib = attribCheckBox.Checked;

            string msg = dbActions.Edit(editedCity);
            MessageBox.Show(msg);
        }
    }
}
