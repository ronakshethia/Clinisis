#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace Clinisis
{
    partial class DiagnosticBox
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
            this.Close = new Syncfusion.Windows.Forms.ButtonAdv();
            this.Add = new Syncfusion.Windows.Forms.ButtonAdv();
            this.DescriptionBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.DTitleBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanelExt1)).BeginInit();
            this.gradientPanelExt1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTitleBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanelExt1
            // 
            this.gradientPanelExt1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gradientPanelExt1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gradientPanelExt1.Border = new System.Windows.Forms.Padding(12);
            this.gradientPanelExt1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanelExt1.Controls.Add(this.Close);
            this.gradientPanelExt1.Controls.Add(this.Add);
            this.gradientPanelExt1.Controls.Add(this.DescriptionBox);
            this.gradientPanelExt1.Controls.Add(this.DTitleBox);
            this.gradientPanelExt1.Controls.Add(this.label3);
            this.gradientPanelExt1.Controls.Add(this.label2);
            this.gradientPanelExt1.Controls.Add(this.panel1);
            this.gradientPanelExt1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelExt1.Name = "gradientPanelExt1";
            this.gradientPanelExt1.Size = new System.Drawing.Size(288, 366);
            this.gradientPanelExt1.TabIndex = 0;
            this.gradientPanelExt1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanelExt1_Paint);
            // 
            // Close
            // 
            this.Close.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.Close.BackColor = System.Drawing.Color.Black;
            this.Close.BeforeTouchSize = new System.Drawing.Size(84, 38);
            this.Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Image = global::Clinisis.Properties.Resources.if_Close_Icon_Dark_1398917;
            this.Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Close.IsBackStageButton = false;
            this.Close.Location = new System.Drawing.Point(139, 309);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(84, 38);
            this.Close.TabIndex = 4;
            this.Close.Text = "Close";
            this.Close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Add
            // 
            this.Add.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.Add.BackColor = System.Drawing.Color.Black;
            this.Add.BeforeTouchSize = new System.Drawing.Size(79, 38);
            this.Add.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.White;
           // this.Add.Image = global::Clinisis.Properties.Resources.if_plus_sign_173078__1_;
            this.Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add.IsBackStageButton = false;
            this.Add.Location = new System.Drawing.Point(54, 309);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(79, 38);
            this.Add.TabIndex = 4;
            this.Add.Text = "Add";
            this.Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.DescriptionBox.BeforeTouchSize = new System.Drawing.Size(251, 31);
            this.DescriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionBox.Location = new System.Drawing.Point(21, 145);
            this.DescriptionBox.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.DescriptionBox.Multiline = true;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(243, 158);
            this.DescriptionBox.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.DescriptionBox.TabIndex = 3;
            // 
            // DTitleBox
            // 
            this.DTitleBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.DTitleBox.BeforeTouchSize = new System.Drawing.Size(251, 31);
            this.DTitleBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.DTitleBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DTitleBox.CornerRadius = 5;
            this.DTitleBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DTitleBox.FarImage = global::Clinisis.Properties.Resources.if_address4_216563;
            this.DTitleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTitleBox.Location = new System.Drawing.Point(17, 87);
            this.DTitleBox.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.DTitleBox.MinimumSize = new System.Drawing.Size(14, 10);
            this.DTitleBox.Name = "DTitleBox";
            this.DTitleBox.Size = new System.Drawing.Size(251, 20);
            this.DTitleBox.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.DTitleBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(21, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(20, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Diagnosis Title";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(19, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 41);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Medical Diagnosis List";
            // 
            // DiagnosticBox
            // 
            this.AcceptButton = this.Add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 366);
            this.Controls.Add(this.gradientPanelExt1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DiagnosticBox";
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.Text = "MetroForm1";
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanelExt1)).EndInit();
            this.gradientPanelExt1.ResumeLayout(false);
            this.gradientPanelExt1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTitleBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanelExt gradientPanelExt1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt DTitleBox;
        private Syncfusion.Windows.Forms.ButtonAdv Add;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt DescriptionBox;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.ButtonAdv Close;
    }
}