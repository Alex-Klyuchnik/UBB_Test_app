namespace UBB_Test_app
{
    partial class ChangePersonForm
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
            this.ChangePersonButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IDTexbBox = new System.Windows.Forms.TextBox();
            this.CityIDTextBox = new System.Windows.Forms.TextBox();
            this.FIOTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChangePersonButton
            // 
            this.ChangePersonButton.Location = new System.Drawing.Point(113, 171);
            this.ChangePersonButton.Name = "ChangePersonButton";
            this.ChangePersonButton.Size = new System.Drawing.Size(75, 23);
            this.ChangePersonButton.TabIndex = 0;
            this.ChangePersonButton.Text = "Изменить";
            this.ChangePersonButton.UseVisualStyleBackColor = true;
            this.ChangePersonButton.Click += new System.EventHandler(this.ChangePersonButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID города";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ФИО";
            // 
            // IDTexbBox
            // 
            this.IDTexbBox.Location = new System.Drawing.Point(100, 39);
            this.IDTexbBox.Name = "IDTexbBox";
            this.IDTexbBox.Size = new System.Drawing.Size(100, 20);
            this.IDTexbBox.TabIndex = 4;
            // 
            // CityIDTextBox
            // 
            this.CityIDTextBox.Location = new System.Drawing.Point(100, 66);
            this.CityIDTextBox.Name = "CityIDTextBox";
            this.CityIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.CityIDTextBox.TabIndex = 5;
            // 
            // FIOTextBox
            // 
            this.FIOTextBox.Location = new System.Drawing.Point(100, 94);
            this.FIOTextBox.Name = "FIOTextBox";
            this.FIOTextBox.Size = new System.Drawing.Size(100, 20);
            this.FIOTextBox.TabIndex = 6;
            // 
            // ChangePersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 228);
            this.Controls.Add(this.FIOTextBox);
            this.Controls.Add(this.CityIDTextBox);
            this.Controls.Add(this.IDTexbBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChangePersonButton);
            this.Name = "ChangePersonForm";
            this.Text = "ChangePersonForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChangePersonButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IDTexbBox;
        private System.Windows.Forms.TextBox CityIDTextBox;
        private System.Windows.Forms.TextBox FIOTextBox;
    }
}