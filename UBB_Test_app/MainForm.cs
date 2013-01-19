﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using UBB_Test_app.DB;
using UBB_Test_app.Forms;
using UBB_Test_app.Properties;

namespace UBB_Test_app
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "localDBDataSet1.Cities". При необходимости она может быть перемещена или удалена.
            this.citiesTableAdapter.Fill(this.localDBDataSet1.Cities);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "localDBDataSet.People". При необходимости она может быть перемещена или удалена.
            this.peopleTableAdapter.Fill(this.localDBDataSet.People);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "localDBDataSet.People". При необходимости она может быть перемещена или удалена.
            this.peopleTableAdapter.Fill(this.localDBDataSet.People);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "localDBDataSet.Cities". При необходимости она может быть перемещена или удалена.
            this.citiesTableAdapter.Fill(this.localDBDataSet.Cities);

        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            AddCityForm addCity = new AddCityForm();
            addCity.Show();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.peopleTableAdapter.FillBy(this.localDBDataSet.People);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void MaxpeopleButton_Click(object sender, EventArgs e)
        {
            DBActions actions = new DBActions();
            MessageBox.Show(actions.MaxPop());
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteCityForm delete = new DeleteCityForm();
            delete.Show();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            EditCityForm edit = new EditCityForm();
            edit.Show();
        }

        private void AddPersonButton_Click(object sender, EventArgs e)
        {
            AddPeopleForm addPeople = new AddPeopleForm();
            addPeople.Show();
        }

        private void ChangePersonButton_Click(object sender, EventArgs e)
        {
            ChangePersonForm changePerson = new ChangePersonForm();
            changePerson.Show();
        }

        private void DeletePersonButton_Click(object sender, EventArgs e)
        {
            DeletePersonForm deletePerson = new DeletePersonForm();
            deletePerson.Show();
        }

        private void SendToServButton_Click(object sender, EventArgs e)
        {
            SenderOnline senderOnline = new SenderOnline();
            MessageBox.Show(senderOnline.SendCity(), "Отправка");
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            DBActions dbActions = new DBActions();
            string report = dbActions.GetReport();
            MessageBox.Show(report, "Report message");

            //For debug purposes
            /*string filePath = Resources.ReportPath;
            List<string> list = new List<string>();
            list.Add("Donetsk;Sidorov S S");
            list.Add("Makeevka;Petrov P P");
            File.WriteAllLines(filePath,list);*/
        }
    }
}
