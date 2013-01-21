using System;
using System.Windows.Forms;
using UBB_Test_app.DB;
using UBB_Test_app.Entities;
using UBB_Test_app.Features;
using UBB_Test_app.Properties;

namespace UBB_Test_app.Forms
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
            InputSanitizer inputSanitizer = new InputSanitizer();

            try
            {
                editedCity.Id = Convert.ToInt32(inputSanitizer.DigitsOnly(IDTextBox.Text));
                editedCity.Name = inputSanitizer.Names(NameTextBox.Text);
                editedCity.Region = inputSanitizer.Names(RegionTextBox.Text);
                editedCity.Country = inputSanitizer.Names(CountryTextBox.Text);
                editedCity.Attrib = attribCheckBox.Checked;

                string msg = dbActions.EditCity(editedCity);
                MessageBox.Show(msg);
            }
            catch(Exception ex)
            {
                MessageBox.Show(Resources.IdIncorrect + ex.Message);
            }
        }
    }
}
