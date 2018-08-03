#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace Clinisis
{
    partial class ConfigureForm
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
            this.components = new System.ComponentModel.Container();
            this.gradientPanelExt1 = new Syncfusion.Windows.Forms.Tools.GradientPanelExt();
            this.button1 = new System.Windows.Forms.Button();
            this.Confirm = new System.Windows.Forms.Button();
            this.choo = new System.Windows.Forms.Label();
            this.res = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ChooseDatabase = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowser1 = new Syncfusion.Windows.Forms.FolderBrowser(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanelExt1)).BeginInit();
            this.gradientPanelExt1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanelExt1
            // 
            this.gradientPanelExt1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gradientPanelExt1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.gradientPanelExt1.Border = new System.Windows.Forms.Padding(12);
            this.gradientPanelExt1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanelExt1.Controls.Add(this.button1);
            this.gradientPanelExt1.Controls.Add(this.Confirm);
            this.gradientPanelExt1.Controls.Add(this.choo);
            this.gradientPanelExt1.Controls.Add(this.res);
            this.gradientPanelExt1.Controls.Add(this.button2);
            this.gradientPanelExt1.Controls.Add(this.ChooseDatabase);
            this.gradientPanelExt1.Location = new System.Drawing.Point(51, 12);
            this.gradientPanelExt1.Name = "gradientPanelExt1";
            this.gradientPanelExt1.Size = new System.Drawing.Size(441, 224);
            this.gradientPanelExt1.TabIndex = 0;
            this.gradientPanelExt1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanelExt1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(110, 184);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 23);
            this.Confirm.TabIndex = 2;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // choo
            // 
            this.choo.AutoSize = true;
            this.choo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choo.Location = new System.Drawing.Point(26, 50);
            this.choo.Name = "choo";
            this.choo.Size = new System.Drawing.Size(0, 13);
            this.choo.TabIndex = 1;
            // 
            // res
            // 
            this.res.AutoSize = true;
            this.res.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res.Location = new System.Drawing.Point(26, 146);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(0, 13);
            this.res.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Restore Database";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ChooseDatabase
            // 
            this.ChooseDatabase.Location = new System.Drawing.Point(29, 24);
            this.ChooseDatabase.Name = "ChooseDatabase";
            this.ChooseDatabase.Size = new System.Drawing.Size(177, 23);
            this.ChooseDatabase.TabIndex = 0;
            this.ChooseDatabase.Text = "Choose Destination For Database";
            this.ChooseDatabase.UseVisualStyleBackColor = true;
            this.ChooseDatabase.Click += new System.EventHandler(this.ChooseDatabase_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ConfigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(534, 281);
            this.Controls.Add(this.gradientPanelExt1);
            this.Name = "ConfigureForm";
            this.Text = "MetroForm1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ConfigureForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanelExt1)).EndInit();
            this.gradientPanelExt1.ResumeLayout(false);
            this.gradientPanelExt1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanelExt gradientPanelExt1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ChooseDatabase;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Syncfusion.Windows.Forms.FolderBrowser folderBrowser1;
        private System.Windows.Forms.Label choo;
        private System.Windows.Forms.Label res;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Confirm;
    }
}