namespace Jamb360
{
    partial class QuickMaths_Settings
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuickMaths_Settings));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnclose = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.freebiesNoOfQuestn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDiffLevel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTimeLimit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rad20 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.rad10 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radio5 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radbut3 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radbut2 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radbut1 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rad20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rad10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radio5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radbut3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radbut2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radbut1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 30);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclose.BackgroundImage")));
            this.btnclose.ButtonText = "X";
            this.btnclose.ButtonTextMarginLeft = 0;
            this.btnclose.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnclose.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnclose.DisabledForecolor = System.Drawing.Color.White;
            this.btnclose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnclose.IconPadding = 10;
            this.btnclose.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnclose.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnclose.IdleBorderRadius = 1;
            this.btnclose.IdleBorderThickness = 0;
            this.btnclose.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.btnclose.IdleIconLeftImage = null;
            this.btnclose.IdleIconRightImage = null;
            this.btnclose.Location = new System.Drawing.Point(353, 0);
            this.btnclose.Name = "btnclose";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnclose.onHoverState = stateProperties1;
            this.btnclose.Size = new System.Drawing.Size(29, 30);
            this.btnclose.TabIndex = 0;
            this.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.freebiesNoOfQuestn);
            this.panel2.Controls.Add(this.btnDiffLevel);
            this.panel2.Controls.Add(this.btnTimeLimit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 252);
            this.panel2.TabIndex = 2;
            // 
            // freebiesNoOfQuestn
            // 
            this.freebiesNoOfQuestn.Active = false;
            this.freebiesNoOfQuestn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.freebiesNoOfQuestn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.freebiesNoOfQuestn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.freebiesNoOfQuestn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.freebiesNoOfQuestn.BorderRadius = 0;
            this.freebiesNoOfQuestn.ButtonText = "Number of Questions";
            this.freebiesNoOfQuestn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.freebiesNoOfQuestn.DisabledColor = System.Drawing.Color.Gray;
            this.freebiesNoOfQuestn.Enabled = false;
            this.freebiesNoOfQuestn.Iconcolor = System.Drawing.Color.Transparent;
            this.freebiesNoOfQuestn.Iconimage = ((System.Drawing.Image)(resources.GetObject("freebiesNoOfQuestn.Iconimage")));
            this.freebiesNoOfQuestn.Iconimage_right = null;
            this.freebiesNoOfQuestn.Iconimage_right_Selected = null;
            this.freebiesNoOfQuestn.Iconimage_Selected = null;
            this.freebiesNoOfQuestn.IconMarginLeft = 0;
            this.freebiesNoOfQuestn.IconMarginRight = 0;
            this.freebiesNoOfQuestn.IconRightVisible = true;
            this.freebiesNoOfQuestn.IconRightZoom = 0D;
            this.freebiesNoOfQuestn.IconVisible = true;
            this.freebiesNoOfQuestn.IconZoom = 50D;
            this.freebiesNoOfQuestn.IsTab = false;
            this.freebiesNoOfQuestn.Location = new System.Drawing.Point(1, 22);
            this.freebiesNoOfQuestn.Name = "freebiesNoOfQuestn";
            this.freebiesNoOfQuestn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.freebiesNoOfQuestn.OnHovercolor = System.Drawing.Color.White;
            this.freebiesNoOfQuestn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.freebiesNoOfQuestn.selected = false;
            this.freebiesNoOfQuestn.Size = new System.Drawing.Size(167, 51);
            this.freebiesNoOfQuestn.TabIndex = 2;
            this.freebiesNoOfQuestn.Text = "Number of Questions";
            this.freebiesNoOfQuestn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.freebiesNoOfQuestn.Textcolor = System.Drawing.Color.White;
            this.freebiesNoOfQuestn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freebiesNoOfQuestn.Click += new System.EventHandler(this.freebiesNoOfQuestn_Click);
            // 
            // btnDiffLevel
            // 
            this.btnDiffLevel.Active = false;
            this.btnDiffLevel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDiffLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDiffLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.btnDiffLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDiffLevel.BorderRadius = 0;
            this.btnDiffLevel.ButtonText = "Difficulty Level";
            this.btnDiffLevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiffLevel.DisabledColor = System.Drawing.Color.Gray;
            this.btnDiffLevel.Enabled = false;
            this.btnDiffLevel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDiffLevel.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDiffLevel.Iconimage")));
            this.btnDiffLevel.Iconimage_right = null;
            this.btnDiffLevel.Iconimage_right_Selected = null;
            this.btnDiffLevel.Iconimage_Selected = null;
            this.btnDiffLevel.IconMarginLeft = 0;
            this.btnDiffLevel.IconMarginRight = 0;
            this.btnDiffLevel.IconRightVisible = true;
            this.btnDiffLevel.IconRightZoom = 0D;
            this.btnDiffLevel.IconVisible = true;
            this.btnDiffLevel.IconZoom = 50D;
            this.btnDiffLevel.IsTab = false;
            this.btnDiffLevel.Location = new System.Drawing.Point(0, 157);
            this.btnDiffLevel.Name = "btnDiffLevel";
            this.btnDiffLevel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.btnDiffLevel.OnHovercolor = System.Drawing.Color.White;
            this.btnDiffLevel.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.btnDiffLevel.selected = false;
            this.btnDiffLevel.Size = new System.Drawing.Size(167, 54);
            this.btnDiffLevel.TabIndex = 1;
            this.btnDiffLevel.Text = "Difficulty Level";
            this.btnDiffLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDiffLevel.Textcolor = System.Drawing.Color.White;
            this.btnDiffLevel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiffLevel.Click += new System.EventHandler(this.btnDiffLevel_Click);
            // 
            // btnTimeLimit
            // 
            this.btnTimeLimit.Active = false;
            this.btnTimeLimit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTimeLimit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimeLimit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.btnTimeLimit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimeLimit.BorderRadius = 0;
            this.btnTimeLimit.ButtonText = "Time Limit";
            this.btnTimeLimit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimeLimit.DisabledColor = System.Drawing.Color.Gray;
            this.btnTimeLimit.Enabled = false;
            this.btnTimeLimit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTimeLimit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTimeLimit.Iconimage")));
            this.btnTimeLimit.Iconimage_right = null;
            this.btnTimeLimit.Iconimage_right_Selected = null;
            this.btnTimeLimit.Iconimage_Selected = null;
            this.btnTimeLimit.IconMarginLeft = 0;
            this.btnTimeLimit.IconMarginRight = 0;
            this.btnTimeLimit.IconRightVisible = true;
            this.btnTimeLimit.IconRightZoom = 0D;
            this.btnTimeLimit.IconVisible = true;
            this.btnTimeLimit.IconZoom = 50D;
            this.btnTimeLimit.IsTab = false;
            this.btnTimeLimit.Location = new System.Drawing.Point(0, 89);
            this.btnTimeLimit.Name = "btnTimeLimit";
            this.btnTimeLimit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.btnTimeLimit.OnHovercolor = System.Drawing.Color.White;
            this.btnTimeLimit.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.btnTimeLimit.selected = false;
            this.btnTimeLimit.Size = new System.Drawing.Size(167, 51);
            this.btnTimeLimit.TabIndex = 0;
            this.btnTimeLimit.Text = "Time Limit";
            this.btnTimeLimit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTimeLimit.Textcolor = System.Drawing.Color.White;
            this.btnTimeLimit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeLimit.Click += new System.EventHandler(this.btnTimeLimit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.radbut3);
            this.panel3.Controls.Add(this.radbut2);
            this.panel3.Controls.Add(this.radbut1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(168, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 252);
            this.panel3.TabIndex = 3;
            this.panel3.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel4.Controls.Add(this.rad20);
            this.panel4.Controls.Add(this.rad10);
            this.panel4.Controls.Add(this.radio5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(214, 252);
            this.panel4.TabIndex = 4;
            this.panel4.Visible = false;
            // 
            // rad20
            // 
            this.rad20.BeforeTouchSize = new System.Drawing.Size(121, 22);
            this.rad20.EnableTouchMode = true;
            this.rad20.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad20.ImageCheckBoxSize = new System.Drawing.Size(19, 19);
            this.rad20.Location = new System.Drawing.Point(32, 148);
            this.rad20.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.rad20.Name = "rad20";
            this.rad20.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.rad20.Size = new System.Drawing.Size(148, 33);
            this.rad20.TabIndex = 2;
            this.rad20.Text = "20";
            this.rad20.CheckChanged += new System.EventHandler(this.rad20_CheckChanged);
            // 
            // rad10
            // 
            this.rad10.BeforeTouchSize = new System.Drawing.Size(121, 22);
            this.rad10.EnableTouchMode = true;
            this.rad10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad10.ImageCheckBoxSize = new System.Drawing.Size(19, 19);
            this.rad10.Location = new System.Drawing.Point(32, 108);
            this.rad10.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.rad10.Name = "rad10";
            this.rad10.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.rad10.Size = new System.Drawing.Size(148, 33);
            this.rad10.TabIndex = 1;
            this.rad10.Text = "10";
            this.rad10.CheckChanged += new System.EventHandler(this.rad10_CheckChanged);
            // 
            // radio5
            // 
            this.radio5.BeforeTouchSize = new System.Drawing.Size(121, 22);
            this.radio5.EnableTouchMode = true;
            this.radio5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio5.ImageCheckBoxSize = new System.Drawing.Size(19, 19);
            this.radio5.Location = new System.Drawing.Point(32, 70);
            this.radio5.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.radio5.Name = "radio5";
            this.radio5.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.radio5.Size = new System.Drawing.Size(148, 33);
            this.radio5.TabIndex = 0;
            this.radio5.Text = "5";
            this.radio5.CheckChanged += new System.EventHandler(this.radio5_CheckChanged);
            // 
            // radbut3
            // 
            this.radbut3.BeforeTouchSize = new System.Drawing.Size(121, 22);
            this.radbut3.EnableTouchMode = true;
            this.radbut3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbut3.ImageCheckBoxSize = new System.Drawing.Size(19, 19);
            this.radbut3.Location = new System.Drawing.Point(32, 148);
            this.radbut3.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.radbut3.Name = "radbut3";
            this.radbut3.Size = new System.Drawing.Size(148, 33);
            this.radbut3.TabIndex = 2;
            this.radbut3.Text = "60";
            this.radbut3.CheckChanged += new System.EventHandler(this.radbut3_CheckChanged);
            // 
            // radbut2
            // 
            this.radbut2.BeforeTouchSize = new System.Drawing.Size(121, 22);
            this.radbut2.EnableTouchMode = true;
            this.radbut2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbut2.ImageCheckBoxSize = new System.Drawing.Size(19, 19);
            this.radbut2.Location = new System.Drawing.Point(32, 108);
            this.radbut2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.radbut2.Name = "radbut2";
            this.radbut2.Size = new System.Drawing.Size(148, 33);
            this.radbut2.TabIndex = 1;
            this.radbut2.Text = "40";
            this.radbut2.CheckChanged += new System.EventHandler(this.radbut2_CheckChanged);
            // 
            // radbut1
            // 
            this.radbut1.BeforeTouchSize = new System.Drawing.Size(121, 22);
            this.radbut1.EnableTouchMode = true;
            this.radbut1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbut1.ImageCheckBoxSize = new System.Drawing.Size(19, 19);
            this.radbut1.Location = new System.Drawing.Point(32, 70);
            this.radbut1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.radbut1.Name = "radbut1";
            this.radbut1.Size = new System.Drawing.Size(148, 33);
            this.radbut1.TabIndex = 0;
            this.radbut1.Text = "30";
            this.radbut1.CheckChanged += new System.EventHandler(this.radbut1_CheckChanged);
            // 
            // QuickMaths_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 282);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuickMaths_Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QuickMaths_Settings";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rad20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rad10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radio5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radbut3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radbut2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radbut1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnDiffLevel;
        private Bunifu.Framework.UI.BunifuFlatButton btnTimeLimit;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnclose;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel3;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radbut3;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radbut2;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radbut1;
        private System.Windows.Forms.Panel panel4;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rad20;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rad10;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radio5;
        private Bunifu.Framework.UI.BunifuFlatButton freebiesNoOfQuestn;

    }
}