using PlayerClass;
using System;

namespace ConsoleApp2
{
    partial class CharacterClassCreator
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

            



            this.checkBoxWarrior = new System.Windows.Forms.CheckBox();
            this.checkBoxMage = new System.Windows.Forms.CheckBox();
            this.checkBoxThief = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxWarrior
            // 
            this.checkBoxWarrior.AutoSize = true;
            this.checkBoxWarrior.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBoxWarrior.Location = new System.Drawing.Point(94, 182);
            this.checkBoxWarrior.Name = "checkBoxWarrior";
            this.checkBoxWarrior.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxWarrior.Size = new System.Drawing.Size(66, 17);
            this.checkBoxWarrior.TabIndex = 0;
            this.checkBoxWarrior.Text = "Strength";
            this.checkBoxWarrior.UseVisualStyleBackColor = true;
            this.checkBoxWarrior.CheckedChanged += new System.EventHandler(this.checkBoxWarrior_CheckedChanged);
            // 
            // checkBoxMage
            // 
            this.checkBoxMage.AutoSize = true;
            this.checkBoxMage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxMage.Location = new System.Drawing.Point(191, 158);
            this.checkBoxMage.Name = "checkBoxMage";
            this.checkBoxMage.Size = new System.Drawing.Size(80, 17);
            this.checkBoxMage.TabIndex = 1;
            this.checkBoxMage.Text = "Intelligence";
            this.checkBoxMage.UseVisualStyleBackColor = true;
            this.checkBoxMage.CheckedChanged += new System.EventHandler(this.checkBoxMage_CheckedChanged);
            // 
            // checkBoxThief
            // 
            this.checkBoxThief.AutoSize = true;
            this.checkBoxThief.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxThief.Location = new System.Drawing.Point(96, 139);
            this.checkBoxThief.Name = "checkBoxThief";
            this.checkBoxThief.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxThief.Size = new System.Drawing.Size(64, 17);
            this.checkBoxThief.TabIndex = 2;
            this.checkBoxThief.Text = "Wisdom";
            this.checkBoxThief.UseVisualStyleBackColor = true;
            this.checkBoxThief.CheckedChanged += new System.EventHandler(this.checkBoxThief_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(28, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(307, 122);
            this.button1.TabIndex = 3;
            this.button1.Text = "Select an Attribute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.FormClose1);
            // 
            // label1 Double-Click
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(65, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Double-Click each Check-Box.";

            // 
            // label2 choose class
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(314, 39);
            this.label2.TabIndex = 5;

            setLabelName();



            // 
            // CharacterClassCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConsoleApp2.Properties.Resources.whitehallway;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(366, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxThief);
            this.Controls.Add(this.checkBoxMage);
            this.Controls.Add(this.checkBoxWarrior);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ConsoleApp2.Properties.Settings.Default, "CharacterClassCreator", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Name = "CharacterClassCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = global::ConsoleApp2.Properties.Settings.Default.CharacterClassCreator;
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxWarrior;
        private System.Windows.Forms.CheckBox checkBoxMage;
        private System.Windows.Forms.CheckBox checkBoxThief;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}