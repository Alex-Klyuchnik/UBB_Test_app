using System;
using System.Windows.Forms;
using UBB_Test_app.DB;
using UBB_Test_app.Entities;
using UBB_Test_app.Features;

namespace UBB_Test_app.Forms
{
    public partial class AddCityForm : Form
    {
        public AddCityForm()
        {
            InitializeComponent();
        }

        private void AddCityButtonClick(object sender, EventArgs e)
        {
            City addedCity = new City();
            InputSanitizer inputSanitizer = new InputSanitizer();

            addedCity.Name = inputSanitizer.Names(CityTextBox.Text);
            addedCity.Region = inputSanitizer.Names(RegionTextBox.Text);
            addedCity.Country = inputSanitizer.Names(CountryTextBox.Text);
            addedCity.Attrib = AttributeCheckbox.Checked;

            DBActions dbAct = new DBActions();
            string msg = dbAct.AddCity(addedCity);
            MessageBox.Show(msg);
        }
    }
}
