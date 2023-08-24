namespace KarinClicker
{
    partial class Karin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Karin));
            this.LeftClicker = new System.Windows.Forms.Timer(this.components);
            this.siticoneAnimateWindow1 = new ns1.SiticoneAnimateWindow(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.minimize = new ns1.SiticoneControlBox();
            this.close = new ns1.SiticoneControlBox();
            this.leftcps = new System.Windows.Forms.Label();
            this.CPSValueScroll = new ns1.SiticoneMetroTrackBar();
            this.CPSValue = new System.Windows.Forms.Label();
            this.credits = new System.Windows.Forms.Label();
            this.clickerenabled = new ns1.SiticoneCustomCheckBox();
            this.enabled = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.delete_exit = new ns1.SiticoneCustomCheckBox();
            this.a = new System.Windows.Forms.Label();
            this.soundclicker = new ns1.SiticoneCustomCheckBox();
            this.blatantmode = new ns1.SiticoneCustomCheckBox();
            this.blatantmode_text = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftClicker
            // 
            this.LeftClicker.Enabled = true;
            this.LeftClicker.Tick += new System.EventHandler(this.LeftClicker_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 37);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.Control;
            this.title.Location = new System.Drawing.Point(7, 8);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(79, 21);
            this.title.TabIndex = 2;
            this.title.Text = "Karin v1.0";
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.ControlBoxType = ns5.ControlBoxType.MinimizeBox;
            this.minimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.minimize.HoveredState.Parent = this.minimize;
            this.minimize.IconColor = System.Drawing.Color.White;
            this.minimize.Location = new System.Drawing.Point(539, 9);
            this.minimize.Name = "minimize";
            this.minimize.ShadowDecoration.Parent = this.minimize;
            this.minimize.Size = new System.Drawing.Size(19, 19);
            this.minimize.TabIndex = 1;
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.close.HoveredState.Parent = this.close;
            this.close.IconColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(564, 9);
            this.close.Name = "close";
            this.close.ShadowDecoration.Parent = this.close;
            this.close.Size = new System.Drawing.Size(19, 19);
            this.close.TabIndex = 0;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // leftcps
            // 
            this.leftcps.AutoSize = true;
            this.leftcps.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftcps.ForeColor = System.Drawing.SystemColors.Control;
            this.leftcps.Location = new System.Drawing.Point(6, 86);
            this.leftcps.Name = "leftcps";
            this.leftcps.Size = new System.Drawing.Size(108, 25);
            this.leftcps.TabIndex = 1;
            this.leftcps.Text = "Left Clicker";
            // 
            // CPSValueScroll
            // 
            this.CPSValueScroll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.CPSValueScroll.HoveredState.Parent = this.CPSValueScroll;
            this.CPSValueScroll.Location = new System.Drawing.Point(11, 114);
            this.CPSValueScroll.Maximum = 20;
            this.CPSValueScroll.Minimum = 1;
            this.CPSValueScroll.Name = "CPSValueScroll";
            this.CPSValueScroll.Size = new System.Drawing.Size(509, 23);
            this.CPSValueScroll.TabIndex = 2;
            this.CPSValueScroll.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CPSValueScroll.Value = 10;
            this.CPSValueScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.CPSValueScrollAction);
            // 
            // CPSValue
            // 
            this.CPSValue.AutoSize = true;
            this.CPSValue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPSValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CPSValue.Location = new System.Drawing.Point(526, 114);
            this.CPSValue.Name = "CPSValue";
            this.CPSValue.Size = new System.Drawing.Size(57, 21);
            this.CPSValue.TabIndex = 3;
            this.CPSValue.Text = "10 CPS";
            // 
            // credits
            // 
            this.credits.AutoSize = true;
            this.credits.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.credits.Location = new System.Drawing.Point(7, 336);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(190, 20);
            this.credits.TabIndex = 4;
            this.credits.Text = "made by lugami/misureta";
            // 
            // clickerenabled
            // 
            this.clickerenabled.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.clickerenabled.CheckedState.BorderRadius = 2;
            this.clickerenabled.CheckedState.BorderThickness = 0;
            this.clickerenabled.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.clickerenabled.CheckedState.Parent = this.clickerenabled;
            this.clickerenabled.Location = new System.Drawing.Point(11, 143);
            this.clickerenabled.Name = "clickerenabled";
            this.clickerenabled.ShadowDecoration.Parent = this.clickerenabled;
            this.clickerenabled.Size = new System.Drawing.Size(20, 20);
            this.clickerenabled.TabIndex = 5;
            this.clickerenabled.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.clickerenabled.UncheckedState.BorderRadius = 2;
            this.clickerenabled.UncheckedState.BorderThickness = 0;
            this.clickerenabled.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.clickerenabled.UncheckedState.Parent = this.clickerenabled;
            this.clickerenabled.CheckedChanged += new System.EventHandler(this.clickerenabled_CheckedChanged);
            // 
            // enabled
            // 
            this.enabled.AutoSize = true;
            this.enabled.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.enabled.Location = new System.Drawing.Point(37, 143);
            this.enabled.Name = "enabled";
            this.enabled.Size = new System.Drawing.Size(64, 20);
            this.enabled.TabIndex = 6;
            this.enabled.Text = "enabled";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(493, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "delete on exit";
            // 
            // delete_exit
            // 
            this.delete_exit.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.delete_exit.CheckedState.BorderRadius = 2;
            this.delete_exit.CheckedState.BorderThickness = 0;
            this.delete_exit.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.delete_exit.CheckedState.Parent = this.delete_exit;
            this.delete_exit.Location = new System.Drawing.Point(467, 336);
            this.delete_exit.Name = "delete_exit";
            this.delete_exit.ShadowDecoration.Parent = this.delete_exit;
            this.delete_exit.Size = new System.Drawing.Size(20, 20);
            this.delete_exit.TabIndex = 7;
            this.delete_exit.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.delete_exit.UncheckedState.BorderRadius = 2;
            this.delete_exit.UncheckedState.BorderThickness = 0;
            this.delete_exit.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.delete_exit.UncheckedState.Parent = this.delete_exit;
            this.delete_exit.CheckedChanged += new System.EventHandler(this.delete_exit_CheckedChanged);
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.a.Location = new System.Drawing.Point(37, 178);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(91, 20);
            this.a.TabIndex = 10;
            this.a.Text = "click sounds";
            // 
            // soundclicker
            // 
            this.soundclicker.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.soundclicker.CheckedState.BorderRadius = 2;
            this.soundclicker.CheckedState.BorderThickness = 0;
            this.soundclicker.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.soundclicker.CheckedState.Parent = this.soundclicker;
            this.soundclicker.Location = new System.Drawing.Point(11, 178);
            this.soundclicker.Name = "soundclicker";
            this.soundclicker.ShadowDecoration.Parent = this.soundclicker;
            this.soundclicker.Size = new System.Drawing.Size(20, 20);
            this.soundclicker.TabIndex = 9;
            this.soundclicker.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.soundclicker.UncheckedState.BorderRadius = 2;
            this.soundclicker.UncheckedState.BorderThickness = 0;
            this.soundclicker.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.soundclicker.UncheckedState.Parent = this.soundclicker;
            this.soundclicker.CheckedChanged += new System.EventHandler(this.soundclicker_CheckedChanged);
            // 
            // blatantmode
            // 
            this.blatantmode.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.blatantmode.CheckedState.BorderRadius = 2;
            this.blatantmode.CheckedState.BorderThickness = 0;
            this.blatantmode.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.blatantmode.CheckedState.Parent = this.blatantmode;
            this.blatantmode.Location = new System.Drawing.Point(191, 143);
            this.blatantmode.Name = "blatantmode";
            this.blatantmode.ShadowDecoration.Parent = this.blatantmode;
            this.blatantmode.Size = new System.Drawing.Size(20, 20);
            this.blatantmode.TabIndex = 11;
            this.blatantmode.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.blatantmode.UncheckedState.BorderRadius = 2;
            this.blatantmode.UncheckedState.BorderThickness = 0;
            this.blatantmode.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.blatantmode.UncheckedState.Parent = this.blatantmode;
            this.blatantmode.CheckedChanged += new System.EventHandler(this.blatantmode_CheckedChanged);
            // 
            // blatantmode_text
            // 
            this.blatantmode_text.AutoSize = true;
            this.blatantmode_text.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blatantmode_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.blatantmode_text.Location = new System.Drawing.Point(217, 143);
            this.blatantmode_text.Name = "blatantmode_text";
            this.blatantmode_text.Size = new System.Drawing.Size(100, 20);
            this.blatantmode_text.TabIndex = 12;
            this.blatantmode_text.Text = "blatant mode";
            // 
            // Karin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(595, 365);
            this.Controls.Add(this.blatantmode_text);
            this.Controls.Add(this.blatantmode);
            this.Controls.Add(this.a);
            this.Controls.Add(this.soundclicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete_exit);
            this.Controls.Add(this.enabled);
            this.Controls.Add(this.clickerenabled);
            this.Controls.Add(this.credits);
            this.Controls.Add(this.CPSValue);
            this.Controls.Add(this.CPSValueScroll);
            this.Controls.Add(this.leftcps);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Karin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Karin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.SiticoneAnimateWindow siticoneAnimateWindow1;
        private System.Windows.Forms.Panel panel1;
        private ns1.SiticoneControlBox close;
        private ns1.SiticoneControlBox minimize;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label leftcps;
        private ns1.SiticoneMetroTrackBar CPSValueScroll;
        private System.Windows.Forms.Label CPSValue;
        private System.Windows.Forms.Label credits;
        public System.Windows.Forms.Timer LeftClicker;
        private ns1.SiticoneCustomCheckBox clickerenabled;
        private System.Windows.Forms.Label enabled;
        private System.Windows.Forms.Label label1;
        private ns1.SiticoneCustomCheckBox delete_exit;
        private System.Windows.Forms.Label a;
        private ns1.SiticoneCustomCheckBox soundclicker;
        private ns1.SiticoneCustomCheckBox blatantmode;
        private System.Windows.Forms.Label blatantmode_text;
    }
}

