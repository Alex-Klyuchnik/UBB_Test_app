namespace UBB_Test_app
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
            this.SuspendLayout();
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(67, 47);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(100, 20);
            this.CityTextBox.TabIndex = 0;
            // 
            // RegionTextBox
            // 
            this.RegionTextBox.Location = new System.Drawing.Point(67, 74);
            this.RegionTextBox.Name = "RegionTextBox";
            this.RegionTextBox.Size = new System.Drawing.Size(100, 20);
            this.RegionTextBox.TabIndex = 1;
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(67, 101);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(100, 20);
            this.CountryTextBox.TabIndex = 2;
            // 
            // AttributeCheckbox
            // 
            this.AttributeCheckbox.AutoSize = true;
            this.AttributeCheckbox.Location = new System.Drawing.Point(67, 128);
            this.AttributeCheckbox.Name = "AttributeCheckbox";
            this.AttributeCheckbox.Size = new System.Drawing.Size(65, 17);
            this.AttributeCheckbox.TabIndex = 3;
            this.AttributeCheckbox.Text = "Attribute";
            this.AttributeCheckbox.UseVisualStyleBackColor = true;
            // 
            // AddCityButton
            // 
            this.AddCityButton.Location = new System.Drawing.Point(67, 172);
            this.AddCityButton.Name = "AddCityButton";
            this.AddCityButton.Size = new System.Drawing.Size(75, 23);
            this.AddCityButton.TabIndex = 4;
            this.AddCityButton.Text = "Добавить город";
            this.AddCityButton.UseVisualStyleBackColor = true;
            this.AddCityButton.Click += new System.EventHandler(this.AddCityButtonClick);
            // 
            // AddCityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 262);
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
    }
}