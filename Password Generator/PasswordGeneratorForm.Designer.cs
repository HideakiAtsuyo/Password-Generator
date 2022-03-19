
namespace Password_Generator
{
    partial class PasswordGeneratorForm
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
            this.HAResultPanel = new ReaLTaiizor.Controls.LostBorderPanel();
            this.GSPHAB = new ReaLTaiizor.Controls.LostButton();
            this.PLHARTB = new System.Windows.Forms.RichTextBox();
            this.GHAB = new ReaLTaiizor.Controls.LostButton();
            this.HAOptionsPanel = new ReaLTaiizor.Controls.LostBorderPanel();
            this.lostButton1 = new ReaLTaiizor.Controls.LostButton();
            this.SaveHAB = new ReaLTaiizor.Controls.LostButton();
            this.lostLabel2 = new ReaLTaiizor.Controls.LostLabel();
            this.NHAL = new System.Windows.Forms.NumericUpDown();
            this.lostLabel1 = new ReaLTaiizor.Controls.LostLabel();
            this.LHAL = new System.Windows.Forms.NumericUpDown();
            this.BHACB = new ReaLTaiizor.Controls.LostCheckBox();
            this.SHACB = new ReaLTaiizor.Controls.LostCheckBox();
            this.DHACB = new ReaLTaiizor.Controls.LostCheckBox();
            this.LCHACB = new ReaLTaiizor.Controls.LostCheckBox();
            this.UCHACB = new ReaLTaiizor.Controls.LostCheckBox();
            this.HAResultPanel.SuspendLayout();
            this.HAOptionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NHAL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LHAL)).BeginInit();
            this.SuspendLayout();
            // 
            // HAResultPanel
            // 
            this.HAResultPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.HAResultPanel.BorderColor = System.Drawing.Color.DodgerBlue;
            this.HAResultPanel.Controls.Add(this.GSPHAB);
            this.HAResultPanel.Controls.Add(this.PLHARTB);
            this.HAResultPanel.Controls.Add(this.GHAB);
            this.HAResultPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.HAResultPanel.ForeColor = System.Drawing.Color.White;
            this.HAResultPanel.Location = new System.Drawing.Point(160, 36);
            this.HAResultPanel.Name = "HAResultPanel";
            this.HAResultPanel.Padding = new System.Windows.Forms.Padding(5);
            this.HAResultPanel.ShowText = true;
            this.HAResultPanel.Size = new System.Drawing.Size(467, 312);
            this.HAResultPanel.TabIndex = 5;
            this.HAResultPanel.Text = "Generator";
            // 
            // GSPHAB
            // 
            this.GSPHAB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.GSPHAB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GSPHAB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GSPHAB.ForeColor = System.Drawing.Color.White;
            this.GSPHAB.HoverColor = System.Drawing.Color.DodgerBlue;
            this.GSPHAB.Image = null;
            this.GSPHAB.Location = new System.Drawing.Point(301, 259);
            this.GSPHAB.Name = "GSPHAB";
            this.GSPHAB.Size = new System.Drawing.Size(151, 40);
            this.GSPHAB.TabIndex = 8;
            this.GSPHAB.Text = "Generate Secure Password";
            this.GSPHAB.Click += new System.EventHandler(this.GSPHAB_Click);
            // 
            // PLHARTB
            // 
            this.PLHARTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.PLHARTB.Location = new System.Drawing.Point(13, 24);
            this.PLHARTB.Name = "PLHARTB";
            this.PLHARTB.Size = new System.Drawing.Size(439, 229);
            this.PLHARTB.TabIndex = 7;
            this.PLHARTB.Text = "";
            // 
            // GHAB
            // 
            this.GHAB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.GHAB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GHAB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GHAB.ForeColor = System.Drawing.Color.White;
            this.GHAB.HoverColor = System.Drawing.Color.DodgerBlue;
            this.GHAB.Image = null;
            this.GHAB.Location = new System.Drawing.Point(13, 259);
            this.GHAB.Name = "GHAB";
            this.GHAB.Size = new System.Drawing.Size(120, 40);
            this.GHAB.TabIndex = 6;
            this.GHAB.Text = "Generate";
            this.GHAB.Click += new System.EventHandler(this.GHAB_Click);
            // 
            // HAOptionsPanel
            // 
            this.HAOptionsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.HAOptionsPanel.BorderColor = System.Drawing.Color.DodgerBlue;
            this.HAOptionsPanel.Controls.Add(this.lostButton1);
            this.HAOptionsPanel.Controls.Add(this.SaveHAB);
            this.HAOptionsPanel.Controls.Add(this.lostLabel2);
            this.HAOptionsPanel.Controls.Add(this.NHAL);
            this.HAOptionsPanel.Controls.Add(this.lostLabel1);
            this.HAOptionsPanel.Controls.Add(this.LHAL);
            this.HAOptionsPanel.Controls.Add(this.BHACB);
            this.HAOptionsPanel.Controls.Add(this.SHACB);
            this.HAOptionsPanel.Controls.Add(this.DHACB);
            this.HAOptionsPanel.Controls.Add(this.LCHACB);
            this.HAOptionsPanel.Controls.Add(this.UCHACB);
            this.HAOptionsPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.HAOptionsPanel.ForeColor = System.Drawing.Color.White;
            this.HAOptionsPanel.Location = new System.Drawing.Point(5, 36);
            this.HAOptionsPanel.Name = "HAOptionsPanel";
            this.HAOptionsPanel.Padding = new System.Windows.Forms.Padding(5);
            this.HAOptionsPanel.ShowText = true;
            this.HAOptionsPanel.Size = new System.Drawing.Size(149, 312);
            this.HAOptionsPanel.TabIndex = 11;
            this.HAOptionsPanel.Text = "Options";
            // 
            // lostButton1
            // 
            this.lostButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.lostButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lostButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lostButton1.ForeColor = System.Drawing.Color.White;
            this.lostButton1.HoverColor = System.Drawing.Color.DodgerBlue;
            this.lostButton1.Image = null;
            this.lostButton1.Location = new System.Drawing.Point(86, 259);
            this.lostButton1.Name = "lostButton1";
            this.lostButton1.Size = new System.Drawing.Size(60, 40);
            this.lostButton1.TabIndex = 20;
            this.lostButton1.Text = "Reset";
            this.lostButton1.Click += new System.EventHandler(this.lostButton1_Click);
            // 
            // SaveHAB
            // 
            this.SaveHAB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.SaveHAB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveHAB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SaveHAB.ForeColor = System.Drawing.Color.White;
            this.SaveHAB.HoverColor = System.Drawing.Color.DodgerBlue;
            this.SaveHAB.Image = null;
            this.SaveHAB.Location = new System.Drawing.Point(7, 259);
            this.SaveHAB.Name = "SaveHAB";
            this.SaveHAB.Size = new System.Drawing.Size(60, 40);
            this.SaveHAB.TabIndex = 8;
            this.SaveHAB.Text = "Save";
            this.SaveHAB.Click += new System.EventHandler(this.SaveHAB_Click);
            // 
            // lostLabel2
            // 
            this.lostLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.lostLabel2.ForeColor = System.Drawing.Color.White;
            this.lostLabel2.Location = new System.Drawing.Point(3, 210);
            this.lostLabel2.Name = "lostLabel2";
            this.lostLabel2.Size = new System.Drawing.Size(64, 23);
            this.lostLabel2.TabIndex = 18;
            this.lostLabel2.Text = "Number:";
            // 
            // NHAL
            // 
            this.NHAL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.NHAL.ForeColor = System.Drawing.Color.White;
            this.NHAL.Location = new System.Drawing.Point(73, 204);
            this.NHAL.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NHAL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NHAL.Name = "NHAL";
            this.NHAL.Size = new System.Drawing.Size(51, 29);
            this.NHAL.TabIndex = 19;
            this.NHAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NHAL.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lostLabel1
            // 
            this.lostLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.lostLabel1.ForeColor = System.Drawing.Color.White;
            this.lostLabel1.Location = new System.Drawing.Point(3, 175);
            this.lostLabel1.Name = "lostLabel1";
            this.lostLabel1.Size = new System.Drawing.Size(64, 23);
            this.lostLabel1.TabIndex = 13;
            this.lostLabel1.Text = "Length:";
            // 
            // LHAL
            // 
            this.LHAL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.LHAL.ForeColor = System.Drawing.Color.White;
            this.LHAL.Location = new System.Drawing.Point(73, 169);
            this.LHAL.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.LHAL.Name = "LHAL";
            this.LHAL.Size = new System.Drawing.Size(51, 29);
            this.LHAL.TabIndex = 17;
            this.LHAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LHAL.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // BHACB
            // 
            this.BHACB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.BHACB.Checked = false;
            this.BHACB.CheckedColor = System.Drawing.Color.White;
            this.BHACB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BHACB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BHACB.ForeColor = System.Drawing.Color.White;
            this.BHACB.Location = new System.Drawing.Point(3, 140);
            this.BHACB.Name = "BHACB";
            this.BHACB.Size = new System.Drawing.Size(121, 23);
            this.BHACB.TabIndex = 16;
            this.BHACB.Text = "Brackets([}..)";
            this.BHACB.Click += new System.EventHandler(this.BHACB_Click);
            // 
            // SHACB
            // 
            this.SHACB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.SHACB.Checked = false;
            this.SHACB.CheckedColor = System.Drawing.Color.White;
            this.SHACB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SHACB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SHACB.ForeColor = System.Drawing.Color.White;
            this.SHACB.Location = new System.Drawing.Point(3, 111);
            this.SHACB.Name = "SHACB";
            this.SHACB.Size = new System.Drawing.Size(121, 23);
            this.SHACB.TabIndex = 15;
            this.SHACB.Text = "Special([}..)";
            this.SHACB.Click += new System.EventHandler(this.SHACB_Click);
            // 
            // DHACB
            // 
            this.DHACB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.DHACB.Checked = false;
            this.DHACB.CheckedColor = System.Drawing.Color.White;
            this.DHACB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DHACB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DHACB.ForeColor = System.Drawing.Color.White;
            this.DHACB.Location = new System.Drawing.Point(3, 82);
            this.DHACB.Name = "DHACB";
            this.DHACB.Size = new System.Drawing.Size(121, 23);
            this.DHACB.TabIndex = 14;
            this.DHACB.Text = "Digits(12..)";
            this.DHACB.Click += new System.EventHandler(this.DHACB_Click);
            // 
            // LCHACB
            // 
            this.LCHACB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.LCHACB.Checked = false;
            this.LCHACB.CheckedColor = System.Drawing.Color.White;
            this.LCHACB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LCHACB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LCHACB.ForeColor = System.Drawing.Color.White;
            this.LCHACB.Location = new System.Drawing.Point(3, 53);
            this.LCHACB.Name = "LCHACB";
            this.LCHACB.Size = new System.Drawing.Size(121, 23);
            this.LCHACB.TabIndex = 12;
            this.LCHACB.Text = "LowerCase(ab..)";
            this.LCHACB.Click += new System.EventHandler(this.LCHACB_Click);
            // 
            // UCHACB
            // 
            this.UCHACB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.UCHACB.Checked = false;
            this.UCHACB.CheckedColor = System.Drawing.Color.White;
            this.UCHACB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UCHACB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UCHACB.ForeColor = System.Drawing.Color.White;
            this.UCHACB.Location = new System.Drawing.Point(3, 24);
            this.UCHACB.Name = "UCHACB";
            this.UCHACB.Size = new System.Drawing.Size(121, 23);
            this.UCHACB.TabIndex = 11;
            this.UCHACB.Text = "UpperCase(AB..)";
            this.UCHACB.Click += new System.EventHandler(this.UCHACB_Click);
            // 
            // PasswordGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 356);
            this.Controls.Add(this.HAOptionsPanel);
            this.Controls.Add(this.HAResultPanel);
            this.Image = null;
            this.MaximizeBox = false;
            this.Name = "PasswordGeneratorForm";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
            this.HAResultPanel.ResumeLayout(false);
            this.HAOptionsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NHAL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LHAL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.LostBorderPanel HAResultPanel;
        private ReaLTaiizor.Controls.LostButton GHAB;
        private ReaLTaiizor.Controls.LostBorderPanel HAOptionsPanel;
        private ReaLTaiizor.Controls.LostLabel lostLabel2;
        private System.Windows.Forms.NumericUpDown NHAL;
        private ReaLTaiizor.Controls.LostLabel lostLabel1;
        private System.Windows.Forms.NumericUpDown LHAL;
        private ReaLTaiizor.Controls.LostCheckBox BHACB;
        private ReaLTaiizor.Controls.LostCheckBox SHACB;
        private ReaLTaiizor.Controls.LostCheckBox DHACB;
        private ReaLTaiizor.Controls.LostCheckBox LCHACB;
        private ReaLTaiizor.Controls.LostCheckBox UCHACB;
        private System.Windows.Forms.RichTextBox PLHARTB;
        private ReaLTaiizor.Controls.LostButton SaveHAB;
        private ReaLTaiizor.Controls.LostButton lostButton1;
        private ReaLTaiizor.Controls.LostButton GSPHAB;
    }
}

