﻿namespace OOP_Project_Group13.Forms
{
    partial class ManageClassWindow
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
            this.classNameLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // classNameLabel
            // 
            this.classNameLabel.AutoSize = true;
            this.classNameLabel.Location = new System.Drawing.Point(39, 39);
            this.classNameLabel.Name = "classNameLabel";
            this.classNameLabel.Size = new System.Drawing.Size(128, 25);
            this.classNameLabel.TabIndex = 0;
            this.classNameLabel.Text = "Class Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Create Course";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Modify Course";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(442, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 43);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete Course";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(44, 196);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 43);
            this.button4.TabIndex = 4;
            this.button4.Text = "Students";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(215, 196);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(165, 43);
            this.button5.TabIndex = 5;
            this.button5.Text = "Timetable";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // ManageClassWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 623);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.classNameLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageClassWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Class";
            this.Load += new System.EventHandler(this.ManageClassWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label classNameLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}