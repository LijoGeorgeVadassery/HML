﻿namespace Harrison.Inventory.WinForm
{
    partial class bankDetails
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
            this.BankNamelbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bankNametxt = new System.Windows.Forms.ComboBox();
            this.donebtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BankNamelbl
            // 
            this.BankNamelbl.AutoSize = true;
            this.BankNamelbl.Location = new System.Drawing.Point(12, 31);
            this.BankNamelbl.Name = "BankNamelbl";
            this.BankNamelbl.Size = new System.Drawing.Size(85, 17);
            this.BankNamelbl.TabIndex = 3;
            this.BankNamelbl.Text = "Bank Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 5;
            // 
            // bankNametxt
            // 
            this.bankNametxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.bankNametxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.bankNametxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.bankNametxt.FormattingEnabled = true;
            this.bankNametxt.Location = new System.Drawing.Point(103, 28);
            this.bankNametxt.Name = "bankNametxt";
            this.bankNametxt.Size = new System.Drawing.Size(344, 24);
            this.bankNametxt.TabIndex = 4;
            // 
            // donebtn
            // 
            this.donebtn.Location = new System.Drawing.Point(15, 85);
            this.donebtn.Name = "donebtn";
            this.donebtn.Size = new System.Drawing.Size(150, 41);
            this.donebtn.TabIndex = 12;
            this.donebtn.Text = "Save";
            this.donebtn.UseVisualStyleBackColor = true;
            this.donebtn.Click += new System.EventHandler(this.donebtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(402, 85);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(143, 41);
            this.cancelbtn.TabIndex = 14;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 22);
            this.button1.TabIndex = 15;
            this.button1.Text = "Add Branch";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(216, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 41);
            this.button2.TabIndex = 16;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bankDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 138);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.donebtn);
            this.Controls.Add(this.bankNametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BankNamelbl);
            this.Name = "bankDetails";
            this.Text = "Bank Master";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BankNamelbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox bankNametxt;
        private System.Windows.Forms.Button donebtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}