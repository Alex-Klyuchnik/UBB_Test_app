namespace UBB_Test_app.Forms
{
    partial class EditCityForm
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
            this.EditButton = new System.Windows.Forms.Button();
            this.attribCheckBox = new System.Windows.Forms.CheckBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.RegionTextBox = new System.Windows.Forms.TextBox();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(97, 193);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 0;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // attribCheckBox
            // 
            this.attribCheckBox.AutoSize = true;
            this.attribCheckBox.Location = new System.Drawing.Point(83, 170);
            this.attribCheckBox.Name = "attribCheckBox";
            this.attribCheckBox.Size = new System.Drawing.Size(65, 17);
            this.attribCheckBox.TabIndex = 1;
            this.attribCheckBox.Text = "Attribute";
            this.attribCheckBox.UseVisualStyleBackColor = true;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(83, 55);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.IDTextBox.TabIndex = 2;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(83, 81);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 3;
            // 
            // RegionTextBox
            // 
            this.RegionTextBox.Location = new System.Drawing.Point(83, 107);
            this.RegionTextBox.Name = "RegionTextBox";
            this.RegionTextBox.Size = new System.Drawing.Size(100, 20);
            this.RegionTextBox.TabIndex = 4;
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(83, 133);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(100, 20);
            this.CountryTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Region";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Country";
            // 
            // EditCityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 235);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountryTextBox);
            this.Controls.Add(this.RegionTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.attribCheckBox);
            this.Controls.Add(this.EditButton);
            this.Name = "EditCityForm";
            this.Text = "EditCityForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.CheckBox attribCheckBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox RegionTextBox;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}