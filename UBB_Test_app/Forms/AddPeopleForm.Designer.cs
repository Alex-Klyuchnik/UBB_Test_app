﻿namespace UBB_Test_app
{
    partial class AddPeopleForm
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
            this.AddPeopleButton = new System.Windows.Forms.Button();
            this.FIOTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CitiesListBox = new System.Windows.Forms.ListBox();
            this.CityIDTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddPeopleButton
            // 
            this.AddPeopleButton.Location = new System.Drawing.Point(104, 199);
            this.AddPeopleButton.Name = "AddPeopleButton";
            this.AddPeopleButton.Size = new System.Drawing.Size(75, 23);
            this.AddPeopleButton.TabIndex = 0;
            this.AddPeopleButton.Text = "Добавить";
            this.AddPeopleButton.UseVisualStyleBackColor = true;
            this.AddPeopleButton.Click += new System.EventHandler(this.AddPeopleButton_Click);
            // 
            // FIOTextBox
            // 
            this.FIOTextBox.Location = new System.Drawing.Point(79, 75);
            this.FIOTextBox.Name = "FIOTextBox";
            this.FIOTextBox.Size = new System.Drawing.Size(100, 20);
            this.FIOTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Город";
            // 
            // CitiesListBox
            // 
            this.CitiesListBox.FormattingEnabled = true;
            this.CitiesListBox.Location = new System.Drawing.Point(185, 143);
            this.CitiesListBox.Name = "CitiesListBox";
            this.CitiesListBox.Size = new System.Drawing.Size(87, 30);
            this.CitiesListBox.TabIndex = 5;
            // 
            // CityIDTextBox
            // 
            this.CityIDTextBox.Location = new System.Drawing.Point(79, 105);
            this.CityIDTextBox.Name = "CityIDTextBox";
            this.CityIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.CityIDTextBox.TabIndex = 6;
            // 
            // AddPeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.CityIDTextBox);
            this.Controls.Add(this.CitiesListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FIOTextBox);
            this.Controls.Add(this.AddPeopleButton);
            this.Name = "AddPeopleForm";
            this.Text = "AddPeopleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddPeopleButton;
        private System.Windows.Forms.TextBox FIOTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox CitiesListBox;
        private System.Windows.Forms.TextBox CityIDTextBox;
    }
}