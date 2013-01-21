namespace UBB_Test_app
{
    partial class mainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AddButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.MaxpeopleButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attribute = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.citiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localDBDataSet = new UBB_Test_app.DB.localDBDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citiesTableAdapter = new UBB_Test_app.DB.localDBDataSetTableAdapters.CitiesTableAdapter();
            this.peopleTableAdapter = new UBB_Test_app.DB.localDBDataSetTableAdapters.PeopleTableAdapter();
            this.localDBDataSet1 = new UBB_Test_app.DB.localDBDataSet();
            this.localDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.citiesPeopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddPersonButton = new System.Windows.Forms.Button();
            this.ChangePersonButton = new System.Windows.Forms.Button();
            this.DeletePersonButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesPeopleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(506, 26);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(506, 56);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeButton.TabIndex = 2;
            this.ChangeButton.Text = "Изменить";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(506, 86);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.Location = new System.Drawing.Point(12, 86);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(75, 23);
            this.ReportButton.TabIndex = 4;
            this.ReportButton.Text = "Отчет";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // MaxpeopleButton
            // 
            this.MaxpeopleButton.Location = new System.Drawing.Point(112, 86);
            this.MaxpeopleButton.Name = "MaxpeopleButton";
            this.MaxpeopleButton.Size = new System.Drawing.Size(104, 23);
            this.MaxpeopleButton.TabIndex = 6;
            this.MaxpeopleButton.Text = "Макс. людей";
            this.MaxpeopleButton.UseVisualStyleBackColor = true;
            this.MaxpeopleButton.Click += new System.EventHandler(this.MaxpeopleButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.CityName,
            this.Region,
            this.Country,
            this.Attribute});
            this.dataGridView1.DataSource = this.citiesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(569, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // CityName
            // 
            this.CityName.DataPropertyName = "CityName";
            this.CityName.HeaderText = "CityName";
            this.CityName.Name = "CityName";
            // 
            // Region
            // 
            this.Region.DataPropertyName = "Region";
            this.Region.HeaderText = "Region";
            this.Region.Name = "Region";
            // 
            // Country
            // 
            this.Country.DataPropertyName = "Country";
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            // 
            // Attribute
            // 
            this.Attribute.DataPropertyName = "Attribute";
            this.Attribute.HeaderText = "Attribute";
            this.Attribute.Name = "Attribute";
            // 
            // citiesBindingSource
            // 
            this.citiesBindingSource.DataMember = "Cities";
            this.citiesBindingSource.DataSource = this.localDBDataSet;
            // 
            // localDBDataSet
            // 
            this.localDBDataSet.DataSetName = "localDBDataSet";
            this.localDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.cityIdDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.peopleBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(13, 320);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(569, 150);
            this.dataGridView2.TabIndex = 8;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // cityIdDataGridViewTextBoxColumn
            // 
            this.cityIdDataGridViewTextBoxColumn.DataPropertyName = "CityId";
            this.cityIdDataGridViewTextBoxColumn.HeaderText = "CityId";
            this.cityIdDataGridViewTextBoxColumn.Name = "cityIdDataGridViewTextBoxColumn";
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "FIO";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            // 
            // peopleBindingSource
            // 
            this.peopleBindingSource.DataMember = "People";
            this.peopleBindingSource.DataSource = this.localDBDataSet;
            // 
            // citiesTableAdapter
            // 
            this.citiesTableAdapter.ClearBeforeFill = true;
            // 
            // peopleTableAdapter
            // 
            this.peopleTableAdapter.ClearBeforeFill = true;
            // 
            // localDBDataSet1
            // 
            this.localDBDataSet1.DataSetName = "localDBDataSet";
            this.localDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // localDBDataSet1BindingSource
            // 
            this.localDBDataSet1BindingSource.DataSource = this.localDBDataSet1;
            this.localDBDataSet1BindingSource.Position = 0;
            // 
            // citiesBindingSource1
            // 
            this.citiesBindingSource1.DataMember = "Cities";
            this.citiesBindingSource1.DataSource = this.localDBDataSet1;
            // 
            // citiesPeopleBindingSource
            // 
            this.citiesPeopleBindingSource.DataMember = "CitiesPeople";
            this.citiesPeopleBindingSource.DataSource = this.citiesBindingSource;
            // 
            // AddPersonButton
            // 
            this.AddPersonButton.Location = new System.Drawing.Point(364, 25);
            this.AddPersonButton.Name = "AddPersonButton";
            this.AddPersonButton.Size = new System.Drawing.Size(75, 23);
            this.AddPersonButton.TabIndex = 9;
            this.AddPersonButton.Text = "Добавить";
            this.AddPersonButton.UseVisualStyleBackColor = true;
            this.AddPersonButton.Click += new System.EventHandler(this.AddPersonButton_Click);
            // 
            // ChangePersonButton
            // 
            this.ChangePersonButton.Location = new System.Drawing.Point(364, 55);
            this.ChangePersonButton.Name = "ChangePersonButton";
            this.ChangePersonButton.Size = new System.Drawing.Size(75, 23);
            this.ChangePersonButton.TabIndex = 10;
            this.ChangePersonButton.Text = "Изменить";
            this.ChangePersonButton.UseVisualStyleBackColor = true;
            this.ChangePersonButton.Click += new System.EventHandler(this.ChangePersonButton_Click);
            // 
            // DeletePersonButton
            // 
            this.DeletePersonButton.Location = new System.Drawing.Point(364, 85);
            this.DeletePersonButton.Name = "DeletePersonButton";
            this.DeletePersonButton.Size = new System.Drawing.Size(75, 23);
            this.DeletePersonButton.TabIndex = 11;
            this.DeletePersonButton.Text = "Удалить";
            this.DeletePersonButton.UseVisualStyleBackColor = true;
            this.DeletePersonButton.Click += new System.EventHandler(this.DeletePersonButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Города";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Люди";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 482);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeletePersonButton);
            this.Controls.Add(this.ChangePersonButton);
            this.Controls.Add(this.AddPersonButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MaxpeopleButton);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.AddButton);
            this.Name = "mainForm";
            this.Text = "Приложение";
            this.Load += new System.EventHandler(this.MainFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesPeopleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.Button MaxpeopleButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DB.localDBDataSet localDBDataSet;
        private System.Windows.Forms.BindingSource citiesBindingSource;
        private DB.localDBDataSetTableAdapters.CitiesTableAdapter citiesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource peopleBindingSource;
        private DB.localDBDataSetTableAdapters.PeopleTableAdapter peopleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource localDBDataSet1BindingSource;
        private DB.localDBDataSet localDBDataSet1;
        private System.Windows.Forms.BindingSource citiesPeopleBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource citiesBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Region;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Attribute;
        private System.Windows.Forms.Button AddPersonButton;
        private System.Windows.Forms.Button ChangePersonButton;
        private System.Windows.Forms.Button DeletePersonButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

