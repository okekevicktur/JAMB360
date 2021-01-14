namespace Jamb360
{
    partial class PopupWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopupWindow));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnclose = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.freebiesBox = new System.Windows.Forms.GroupBox();
            this.totPts = new System.Windows.Forms.Label();
            this.labTotQust = new System.Windows.Forms.Label();
            this.quickmathsBox = new System.Windows.Forms.GroupBox();
            this.diffLevel = new System.Windows.Forms.Label();
            this.AvgresponsTime = new System.Windows.Forms.Label();
            this.timeTaken = new System.Windows.Forms.Label();
            this.TotQuestAns = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.bunifuShadowPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.freebiesBox.SuspendLayout();
            this.quickmathsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuShadowPanel1.Controls.Add(this.panel1);
            this.bunifuShadowPanel1.Controls.Add(this.freebiesBox);
            this.bunifuShadowPanel1.Controls.Add(this.quickmathsBox);
            this.bunifuShadowPanel1.Controls.Add(this.label1);
            this.bunifuShadowPanel1.Controls.Add(this.btnReset);
            this.bunifuShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.Empty;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(381, 247);
            this.bunifuShadowPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 25);
            this.panel1.TabIndex = 5;
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
            this.btnclose.Location = new System.Drawing.Point(352, 0);
            this.btnclose.Name = "btnclose";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnclose.onHoverState = stateProperties1;
            this.btnclose.Size = new System.Drawing.Size(29, 25);
            this.btnclose.TabIndex = 0;
            this.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // freebiesBox
            // 
            this.freebiesBox.Controls.Add(this.totPts);
            this.freebiesBox.Controls.Add(this.labTotQust);
            this.freebiesBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freebiesBox.Location = new System.Drawing.Point(29, 52);
            this.freebiesBox.Name = "freebiesBox";
            this.freebiesBox.Size = new System.Drawing.Size(326, 138);
            this.freebiesBox.TabIndex = 4;
            this.freebiesBox.TabStop = false;
            this.freebiesBox.Visible = false;
            // 
            // totPts
            // 
            this.totPts.AutoSize = true;
            this.totPts.Location = new System.Drawing.Point(24, 74);
            this.totPts.Name = "totPts";
            this.totPts.Size = new System.Drawing.Size(87, 19);
            this.totPts.TabIndex = 1;
            this.totPts.Text = "Total points: ";
            // 
            // labTotQust
            // 
            this.labTotQust.AutoSize = true;
            this.labTotQust.Location = new System.Drawing.Point(24, 43);
            this.labTotQust.Name = "labTotQust";
            this.labTotQust.Size = new System.Drawing.Size(104, 19);
            this.labTotQust.TabIndex = 0;
            this.labTotQust.Text = "Total questions:";
            // 
            // quickmathsBox
            // 
            this.quickmathsBox.Controls.Add(this.diffLevel);
            this.quickmathsBox.Controls.Add(this.AvgresponsTime);
            this.quickmathsBox.Controls.Add(this.timeTaken);
            this.quickmathsBox.Controls.Add(this.TotQuestAns);
            this.quickmathsBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickmathsBox.Location = new System.Drawing.Point(29, 47);
            this.quickmathsBox.Name = "quickmathsBox";
            this.quickmathsBox.Size = new System.Drawing.Size(326, 142);
            this.quickmathsBox.TabIndex = 2;
            this.quickmathsBox.TabStop = false;
            this.quickmathsBox.Visible = false;
            // 
            // diffLevel
            // 
            this.diffLevel.AutoSize = true;
            this.diffLevel.Location = new System.Drawing.Point(7, 118);
            this.diffLevel.Name = "diffLevel";
            this.diffLevel.Size = new System.Drawing.Size(96, 19);
            this.diffLevel.TabIndex = 3;
            this.diffLevel.Text = "Difficulty level:";
            // 
            // AvgresponsTime
            // 
            this.AvgresponsTime.AutoSize = true;
            this.AvgresponsTime.Location = new System.Drawing.Point(7, 87);
            this.AvgresponsTime.Name = "AvgresponsTime";
            this.AvgresponsTime.Size = new System.Drawing.Size(156, 19);
            this.AvgresponsTime.TabIndex = 2;
            this.AvgresponsTime.Text = "Average response time: ";
            // 
            // timeTaken
            // 
            this.timeTaken.AutoSize = true;
            this.timeTaken.Location = new System.Drawing.Point(7, 56);
            this.timeTaken.Name = "timeTaken";
            this.timeTaken.Size = new System.Drawing.Size(83, 19);
            this.timeTaken.TabIndex = 1;
            this.timeTaken.Text = "Time taken: ";
            // 
            // TotQuestAns
            // 
            this.TotQuestAns.AutoSize = true;
            this.TotQuestAns.Location = new System.Drawing.Point(7, 25);
            this.TotQuestAns.Name = "TotQuestAns";
            this.TotQuestAns.Size = new System.Drawing.Size(164, 19);
            this.TotQuestAns.TabIndex = 0;
            this.TotQuestAns.Text = "Total questions anwered: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stats";
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.btnReset.Location = new System.Drawing.Point(280, 195);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 29);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Retry";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // PopupWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 247);
            this.Controls.Add(this.bunifuShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PopupWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PopupWindow";
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.bunifuShadowPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.freebiesBox.ResumeLayout(false);
            this.freebiesBox.PerformLayout();
            this.quickmathsBox.ResumeLayout(false);
            this.quickmathsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel bunifuShadowPanel1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox quickmathsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TotQuestAns;
        private System.Windows.Forms.Label diffLevel;
        private System.Windows.Forms.Label AvgresponsTime;
        private System.Windows.Forms.Label timeTaken;
        private System.Windows.Forms.GroupBox freebiesBox;
        private System.Windows.Forms.Label totPts;
        private System.Windows.Forms.Label labTotQust;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnclose;
    }
}