using System;
using System.Windows.Forms;
using UBB_Test_app.DB;
using UBB_Test_app.Entities;

namespace UBB_Test_app
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
            addedCity.Name = CityTextBox.Text;
            addedCity.Region = RegionTextBox.Text;
            addedCity.Country = CountryTextBox.Text;
            addedCity.Attrib = AttributeCheckbox.Checked;

            DBActions dbAct = new DBActions();
            dbAct.AddCity(addedCity);
            MessageBox.Show("Город добавлен успешно!"); //TODO Split local/network messages
        }
    }
}
