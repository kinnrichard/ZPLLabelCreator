
namespace LabelCreator
{
    partial class LabelCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabelCreator));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblFileCreator = new System.Windows.Forms.Label();
            this.ZplTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelWidthTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblPrefix = new System.Windows.Forms.Label();
            this.ButtonPrint = new System.Windows.Forms.Button();
            this.ButtonGenerate = new System.Windows.Forms.Button();
            this.LabelHeightTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboboxUnits = new System.Windows.Forms.ComboBox();
            this.ButtonZplOpen = new System.Windows.Forms.Button();
            this.ComboboxDPI = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ButtonExport = new System.Windows.Forms.Button();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.LabelViewer = new AxAcroPDFLib.AxAcroPDF();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblCompany);
            this.panel2.Controls.Add(this.lblFileCreator);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(72, 801);
            this.panel2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(-5, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 479);
            this.label1.TabIndex = 17;
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Paint += new System.Windows.Forms.PaintEventHandler(this.label1_Paint);
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.ForeColor = System.Drawing.Color.Gray;
            this.lblCompany.Location = new System.Drawing.Point(32, 147);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(0, 40);
            this.lblCompany.TabIndex = 16;
            // 
            // lblFileCreator
            // 
            this.lblFileCreator.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileCreator.ForeColor = System.Drawing.Color.Gray;
            this.lblFileCreator.Location = new System.Drawing.Point(-11, 206);
            this.lblFileCreator.Name = "lblFileCreator";
            this.lblFileCreator.Size = new System.Drawing.Size(82, 220);
            this.lblFileCreator.TabIndex = 15;
            // 
            // ZplTextbox
            // 
            this.ZplTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZplTextbox.Location = new System.Drawing.Point(128, 110);
            this.ZplTextbox.Multiline = true;
            this.ZplTextbox.Name = "ZplTextbox";
            this.ZplTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ZplTextbox.Size = new System.Drawing.Size(388, 496);
            this.ZplTextbox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(123, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "ZPL Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(568, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 26);
            this.label2.TabIndex = 19;
            this.label2.Text = "Label Viewer";
            // 
            // LabelWidthTextbox
            // 
            this.LabelWidthTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LabelWidthTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWidthTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LabelWidthTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.LabelWidthTextbox.HintText = "";
            this.LabelWidthTextbox.isPassword = false;
            this.LabelWidthTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.LabelWidthTextbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LabelWidthTextbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LabelWidthTextbox.LineThickness = 4;
            this.LabelWidthTextbox.Location = new System.Drawing.Point(128, 643);
            this.LabelWidthTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.LabelWidthTextbox.Name = "LabelWidthTextbox";
            this.LabelWidthTextbox.Size = new System.Drawing.Size(140, 31);
            this.LabelWidthTextbox.TabIndex = 35;
            this.LabelWidthTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblPrefix
            // 
            this.lblPrefix.AutoSize = true;
            this.lblPrefix.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrefix.ForeColor = System.Drawing.Color.Gray;
            this.lblPrefix.Location = new System.Drawing.Point(124, 622);
            this.lblPrefix.Name = "lblPrefix";
            this.lblPrefix.Size = new System.Drawing.Size(93, 21);
            this.lblPrefix.TabIndex = 34;
            this.lblPrefix.Text = "Label Width";
            // 
            // ButtonPrint
            // 
            this.ButtonPrint.BackColor = System.Drawing.Color.Transparent;
            this.ButtonPrint.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPrint.ForeColor = System.Drawing.Color.DimGray;
            this.ButtonPrint.Location = new System.Drawing.Point(902, 745);
            this.ButtonPrint.Name = "ButtonPrint";
            this.ButtonPrint.Size = new System.Drawing.Size(79, 34);
            this.ButtonPrint.TabIndex = 37;
            this.ButtonPrint.Text = "Print";
            this.ButtonPrint.UseVisualStyleBackColor = false;
            this.ButtonPrint.Click += new System.EventHandler(this.ButtonPrint_Click);
            // 
            // ButtonGenerate
            // 
            this.ButtonGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.ButtonGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonGenerate.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGenerate.ForeColor = System.Drawing.Color.White;
            this.ButtonGenerate.Location = new System.Drawing.Point(816, 745);
            this.ButtonGenerate.Name = "ButtonGenerate";
            this.ButtonGenerate.Size = new System.Drawing.Size(79, 34);
            this.ButtonGenerate.TabIndex = 36;
            this.ButtonGenerate.Text = "Generate";
            this.ButtonGenerate.UseVisualStyleBackColor = false;
            this.ButtonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
            // 
            // LabelHeightTextbox
            // 
            this.LabelHeightTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LabelHeightTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeightTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LabelHeightTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.LabelHeightTextbox.HintText = "";
            this.LabelHeightTextbox.isPassword = false;
            this.LabelHeightTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.LabelHeightTextbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LabelHeightTextbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LabelHeightTextbox.LineThickness = 4;
            this.LabelHeightTextbox.Location = new System.Drawing.Point(305, 643);
            this.LabelHeightTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.LabelHeightTextbox.Name = "LabelHeightTextbox";
            this.LabelHeightTextbox.Size = new System.Drawing.Size(140, 31);
            this.LabelHeightTextbox.TabIndex = 39;
            this.LabelHeightTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(301, 622);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 38;
            this.label4.Text = "Label Height";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(124, 694);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 21);
            this.label5.TabIndex = 40;
            this.label5.Text = "Unit";
            // 
            // ComboboxUnits
            // 
            this.ComboboxUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboboxUnits.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ComboboxUnits.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboboxUnits.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ComboboxUnits.FormattingEnabled = true;
            this.ComboboxUnits.IntegralHeight = false;
            this.ComboboxUnits.Items.AddRange(new object[] {
            "Millimeters",
            "Inches"});
            this.ComboboxUnits.Location = new System.Drawing.Point(128, 718);
            this.ComboboxUnits.MaxDropDownItems = 10;
            this.ComboboxUnits.Name = "ComboboxUnits";
            this.ComboboxUnits.Size = new System.Drawing.Size(140, 29);
            this.ComboboxUnits.TabIndex = 45;
            // 
            // ButtonZplOpen
            // 
            this.ButtonZplOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.ButtonZplOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonZplOpen.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonZplOpen.ForeColor = System.Drawing.Color.White;
            this.ButtonZplOpen.Location = new System.Drawing.Point(380, 72);
            this.ButtonZplOpen.Name = "ButtonZplOpen";
            this.ButtonZplOpen.Size = new System.Drawing.Size(136, 34);
            this.ButtonZplOpen.TabIndex = 46;
            this.ButtonZplOpen.Text = "Open ZPL File";
            this.ButtonZplOpen.UseVisualStyleBackColor = false;
            this.ButtonZplOpen.Click += new System.EventHandler(this.ButtonZplOpen_Click);
            // 
            // ComboboxDPI
            // 
            this.ComboboxDPI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboboxDPI.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ComboboxDPI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboboxDPI.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ComboboxDPI.FormattingEnabled = true;
            this.ComboboxDPI.IntegralHeight = false;
            this.ComboboxDPI.Items.AddRange(new object[] {
            "152 dpi",
            "203 dpi",
            "300 dpi",
            "600 dpi"});
            this.ComboboxDPI.Location = new System.Drawing.Point(305, 718);
            this.ComboboxDPI.MaxDropDownItems = 10;
            this.ComboboxDPI.Name = "ComboboxDPI";
            this.ComboboxDPI.Size = new System.Drawing.Size(140, 29);
            this.ComboboxDPI.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(301, 694);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 21);
            this.label6.TabIndex = 47;
            this.label6.Text = "DPI";
            // 
            // ButtonExport
            // 
            this.ButtonExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.ButtonExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExport.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExport.ForeColor = System.Drawing.Color.White;
            this.ButtonExport.Location = new System.Drawing.Point(845, 72);
            this.ButtonExport.Name = "ButtonExport";
            this.ButtonExport.Size = new System.Drawing.Size(136, 34);
            this.ButtonExport.TabIndex = 49;
            this.ButtonExport.Text = "Export PDF";
            this.ButtonExport.UseVisualStyleBackColor = false;
            this.ButtonExport.Visible = false;
            this.ButtonExport.Click += new System.EventHandler(this.ButtonExport_Click);
            // 
            // picMinimize
            // 
            this.picMinimize.Image = global::LabelCreator.Properties.Resources.minus__1_;
            this.picMinimize.Location = new System.Drawing.Point(952, 12);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(24, 24);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMinimize.TabIndex = 51;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            // 
            // picClose
            // 
            this.picClose.Image = global::LabelCreator.Properties.Resources.close__1_;
            this.picClose.Location = new System.Drawing.Point(982, 12);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(24, 24);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picClose.TabIndex = 50;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // LabelViewer
            // 
            this.LabelViewer.Enabled = true;
            this.LabelViewer.Location = new System.Drawing.Point(573, 110);
            this.LabelViewer.Name = "LabelViewer";
            this.LabelViewer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("LabelViewer.OcxState")));
            this.LabelViewer.Size = new System.Drawing.Size(408, 496);
            this.LabelViewer.TabIndex = 18;
            // 
            // LabelCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 801);
            this.ControlBox = false;
            this.Controls.Add(this.picMinimize);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.ButtonExport);
            this.Controls.Add(this.ComboboxDPI);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ButtonZplOpen);
            this.Controls.Add(this.ComboboxUnits);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LabelHeightTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ButtonPrint);
            this.Controls.Add(this.ButtonGenerate);
            this.Controls.Add(this.LabelWidthTextbox);
            this.Controls.Add(this.lblPrefix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelViewer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ZplTextbox);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LabelCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LabelCreator_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblFileCreator;
        private System.Windows.Forms.Label label2;
        private AxAcroPDFLib.AxAcroPDF LabelViewer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ZplTextbox;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox LabelHeightTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonPrint;
        private System.Windows.Forms.Button ButtonGenerate;
        private Bunifu.Framework.UI.BunifuMaterialTextbox LabelWidthTextbox;
        private System.Windows.Forms.Label lblPrefix;
        private System.Windows.Forms.ComboBox ComboboxUnits;
        private System.Windows.Forms.Button ButtonZplOpen;
        private System.Windows.Forms.ComboBox ComboboxDPI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ButtonExport;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

