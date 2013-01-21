namespace UBB_Test_app.Forms
{
    partial class AddCityForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.RegionTextBox = new System.Windows.Forms.TextBox();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.AttributeCheckbox = new System.Windows.Forms.CheckBox();
            this.AddCityButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(127, 47);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(100, 20);
            this.CityTextBox.TabIndex = 0;
            // 
            // RegionTextBox
            // 
            this.RegionTextBox.Location = new System.Drawing.Point(127, 73);
            this.RegionTextBox.Name = "RegionTextBox";
            this.RegionTextBox.Size = new System.Drawing.Size(100, 20);
            this.RegionTextBox.TabIndex = 1;
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(127, 100);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(100, 20);
            this.CountryTextBox.TabIndex = 2;
            // 
            // AttributeCheckbox
            // 
            this.AttributeCheckbox.AutoSize = true;
            this.AttributeCheckbox.Location = new System.Drawing.Point(141, 126);
            this.AttributeCheckbox.Name = "AttributeCheckbox";
            this.AttributeCheckbox.Size = new System.Drawing.Size(65, 17);
            this.AttributeCheckbox.TabIndex = 3;
            this.AttributeCheckbox.Text = "Attribute";
            this.AttributeCheckbox.UseVisualStyleBackColor = true;
            // 
            // AddCityButton
            // 
            this.AddCityButton.Location = new System.Drawing.Point(127, 176);
            this.AddCityButton.Name = "AddCityButton";
            this.AddCityButton.Size = new System.Drawing.Size(75, 23);
            this.AddCityButton.TabIndex = 4;
            this.AddCityButton.Text = "Добавить город";
            this.AddCityButton.UseVisualStyleBackColor = true;
            this.AddCityButton.Click += new System.EventHandler(this.AddCityButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название города";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Регион";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Страна";
            // 
            // AddCityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 212);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddCityButton);
            this.Controls.Add(this.AttributeCheckbox);
            this.Controls.Add(this.CountryTextBox);
            this.Controls.Add(this.RegionTextBox);
            this.Controls.Add(this.CityTextBox);
            this.Name = "AddCityForm";
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.TextBox RegionTextBox;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.CheckBox AttributeCheckbox;
        private System.Windows.Forms.Button AddCityButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}