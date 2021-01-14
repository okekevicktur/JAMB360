namespace Jamb360
{
    partial class QuickMaths
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuickMaths));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPlay = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSettings = new Bunifu.UI.WinForms.BunifuImageButton();
            this.questBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.labelTime = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labInstruct = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.questBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 34);
            this.panel1.TabIndex = 0;
            // 
            // btnPlay
            // 
            this.btnPlay.ActiveImage = null;
            this.btnPlay.AllowAnimations = true;
            this.btnPlay.AllowZooming = true;
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.ErrorImage")));
            this.btnPlay.FadeWhenInactive = false;
            this.btnPlay.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.ImageActive = null;
            this.btnPlay.ImageLocation = null;
            this.btnPlay.ImageMargin = 10;
            this.btnPlay.ImageSize = new System.Drawing.Size(22, 20);
            this.btnPlay.ImageZoomSize = new System.Drawing.Size(32, 30);
            this.btnPlay.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.InitialImage")));
            this.btnPlay.Location = new System.Drawing.Point(566, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Rotation = 0;
            this.btnPlay.ShowActiveImage = true;
            this.btnPlay.ShowCursorChanges = true;
            this.btnPlay.ShowImageBorders = true;
            this.btnPlay.ShowSizeMarkers = false;
            this.btnPlay.Size = new System.Drawing.Size(32, 30);
            this.btnPlay.TabIndex = 44;
            this.btnPlay.ToolTipText = "";
            this.btnPlay.WaitOnLoad = false;
            this.btnPlay.Zoom = 10;
            this.btnPlay.ZoomSpeed = 10;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageActive = null;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(62, 34);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 38;
            this.btnBack.TabStop = false;
            this.btnBack.Zoom = 20;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.ActiveImage = null;
            this.btnSettings.AllowAnimations = true;
            this.btnSettings.AllowZooming = true;
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSettings.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.ErrorImage")));
            this.btnSettings.FadeWhenInactive = false;
            this.btnSettings.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageActive = null;
            this.btnSettings.ImageLocation = null;
            this.btnSettings.ImageMargin = 10;
            this.btnSettings.ImageSize = new System.Drawing.Size(24, 24);
            this.btnSettings.ImageZoomSize = new System.Drawing.Size(34, 34);
            this.btnSettings.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.InitialImage")));
            this.btnSettings.Location = new System.Drawing.Point(1138, 0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Rotation = 0;
            this.btnSettings.ShowActiveImage = true;
            this.btnSettings.ShowCursorChanges = true;
            this.btnSettings.ShowImageBorders = true;
            this.btnSettings.ShowSizeMarkers = false;
            this.btnSettings.Size = new System.Drawing.Size(34, 34);
            this.btnSettings.TabIndex = 43;
            this.btnSettings.ToolTipText = "";
            this.btnSettings.WaitOnLoad = false;
            this.btnSettings.Zoom = 10;
            this.btnSettings.ZoomSpeed = 10;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // questBox
            // 
            this.questBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.questBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.questBox.Controls.Add(this.label1);
            this.questBox.Controls.Add(this.bunifuMaterialTextbox1);
            this.questBox.Location = new System.Drawing.Point(402, 255);
            this.questBox.Name = "questBox";
            this.questBox.Size = new System.Drawing.Size(399, 159);
            this.questBox.TabIndex = 48;
            this.questBox.TabStop = false;
            this.questBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 39);
            this.label1.TabIndex = 40;
            this.label1.Text = "?  *  ? = ?";
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bunifuMaterialTextbox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuMaterialTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(194)))), ((int)(((byte)(248)))));
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(194)))), ((int)(((byte)(248)))));
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(100, 100);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuMaterialTextbox1.MaxLength = 10;
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(193, 39);
            this.bunifuMaterialTextbox1.TabIndex = 41;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextbox1.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            this.bunifuMaterialTextbox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bunifuMaterialTextbox1_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.bunifuThinButton21);
            this.groupBox1.Controls.Add(this.labelTime);
            this.groupBox1.Controls.Add(this.bunifuImageButton1);
            this.groupBox1.Location = new System.Drawing.Point(417, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 111);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Click play to start";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(85, 56);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(183, 49);
            this.bunifuThinButton21.TabIndex = 46;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(173, 31);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(54, 21);
            this.labelTime.TabIndex = 44;
            this.labelTime.Text = "label2";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(128, 20);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(42, 31);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 38;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labInstruct
            // 
            this.labInstruct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labInstruct.AutoSize = true;
            this.labInstruct.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labInstruct.Location = new System.Drawing.Point(408, 231);
            this.labInstruct.Name = "labInstruct";
            this.labInstruct.Size = new System.Drawing.Size(353, 21);
            this.labInstruct.TabIndex = 49;
            this.labInstruct.Text = "Note: Question changes when the answer is correct";
            this.labInstruct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labInstruct.Visible = false;
            // 
            // QuickMaths
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 585);
            this.Controls.Add(this.labInstruct);
            this.Controls.Add(this.questBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "QuickMaths";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quick Maths";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QuickMaths_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.questBox.ResumeLayout(false);
            this.questBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnBack;
        private Bunifu.UI.WinForms.BunifuImageButton btnPlay;
        private Bunifu.UI.WinForms.BunifuImageButton btnSettings;
        private System.Windows.Forms.GroupBox questBox;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.Label labelTime;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labInstruct;
    }
}