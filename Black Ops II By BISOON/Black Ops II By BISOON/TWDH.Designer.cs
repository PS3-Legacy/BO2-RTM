namespace Black_Ops_II_By_BISOON
{
    partial class TWDH
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
            this.formSkin1 = new theme.FormSkin();
            this.closeBtn = new theme.FlatButton();
            this.flatMini1 = new theme.FlatMini();
            this.flatTabControl1 = new theme.FlatTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.radioButton3 = new theme.RadioButton();
            this.radioButton2 = new theme.RadioButton();
            this.radioButton1 = new theme.RadioButton();
            this.clientNum_DH = new theme.FlatNumeric();
            this.textBox_DH = new System.Windows.Forms.RichTextBox();
            this.doHeartBtn = new theme.FlatButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flatLabel3 = new theme.FlatLabel();
            this.decayDur_TW = new theme.FlatNumeric();
            this.flatLabel2 = new theme.FlatLabel();
            this.duration_TW = new theme.FlatNumeric();
            this.flatLabel1 = new theme.FlatLabel();
            this.clientNum_TW = new theme.FlatNumeric();
            this.typeWrBtn = new theme.FlatButton();
            this.textBox_TW = new System.Windows.Forms.RichTextBox();
            this.DhTimer = new System.Windows.Forms.Timer(this.components);
            this.formSkin1.SuspendLayout();
            this.flatTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.closeBtn);
            this.formSkin1.Controls.Add(this.flatMini1);
            this.formSkin1.Controls.Add(this.flatTabControl1);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(485, 281);
            this.formSkin1.TabIndex = 0;
            this.formSkin1.Text = "Type Writer / DoHeart";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.closeBtn.Location = new System.Drawing.Point(463, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Rounded = false;
            this.closeBtn.Size = new System.Drawing.Size(18, 18);
            this.closeBtn.TabIndex = 282;
            this.closeBtn.Text = "x";
            this.closeBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // flatMini1
            // 
            this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini1.BackColor = System.Drawing.Color.White;
            this.flatMini1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMini1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMini1.Location = new System.Drawing.Point(439, 3);
            this.flatMini1.Name = "flatMini1";
            this.flatMini1.Size = new System.Drawing.Size(18, 18);
            this.flatMini1.TabIndex = 281;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatTabControl1
            // 
            this.flatTabControl1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatTabControl1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatTabControl1.Controls.Add(this.tabPage1);
            this.flatTabControl1.Controls.Add(this.tabPage2);
            this.flatTabControl1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.flatTabControl1.ItemSize = new System.Drawing.Size(120, 40);
            this.flatTabControl1.Location = new System.Drawing.Point(0, 47);
            this.flatTabControl1.Name = "flatTabControl1";
            this.flatTabControl1.SelectedIndex = 0;
            this.flatTabControl1.Size = new System.Drawing.Size(485, 231);
            this.flatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.flatTabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage1.Controls.Add(this.radioButton3);
            this.tabPage1.Controls.Add(this.radioButton2);
            this.tabPage1.Controls.Add(this.radioButton1);
            this.tabPage1.Controls.Add(this.clientNum_DH);
            this.tabPage1.Controls.Add(this.textBox_DH);
            this.tabPage1.Controls.Add(this.doHeartBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(477, 183);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DoHeart";
            // 
            // radioButton3
            // 
            this.radioButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.radioButton3.Checked = false;
            this.radioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.radioButton3.Location = new System.Drawing.Point(357, 156);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Options = theme.RadioButton._Options.Style1;
            this.radioButton3.Size = new System.Drawing.Size(76, 22);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.Text = "Mod 3";
            this.radioButton3.CheckedChanged += new theme.RadioButton.CheckedChangedEventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.radioButton2.Checked = false;
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.radioButton2.Location = new System.Drawing.Point(357, 132);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Options = theme.RadioButton._Options.Style1;
            this.radioButton2.Size = new System.Drawing.Size(76, 22);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "Mod 2";
            this.radioButton2.CheckedChanged += new theme.RadioButton.CheckedChangedEventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.radioButton1.Checked = true;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.radioButton1.Location = new System.Drawing.Point(357, 108);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Options = theme.RadioButton._Options.Style1;
            this.radioButton1.Size = new System.Drawing.Size(76, 22);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "Mod 1";
            this.radioButton1.CheckedChanged += new theme.RadioButton.CheckedChangedEventHandler(this.radioButton1_CheckedChanged);
            // 
            // clientNum_DH
            // 
            this.clientNum_DH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.clientNum_DH.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.clientNum_DH.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.clientNum_DH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.clientNum_DH.ForeColor = System.Drawing.Color.White;
            this.clientNum_DH.Location = new System.Drawing.Point(65, 115);
            this.clientNum_DH.Maximum = ((long)(9999999));
            this.clientNum_DH.Minimum = ((long)(0));
            this.clientNum_DH.Name = "clientNum_DH";
            this.clientNum_DH.Size = new System.Drawing.Size(71, 30);
            this.clientNum_DH.TabIndex = 2;
            this.clientNum_DH.Text = "flatNumeric1";
            this.clientNum_DH.Value = ((long)(0));
            // 
            // textBox_DH
            // 
            this.textBox_DH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.textBox_DH.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_DH.Location = new System.Drawing.Point(6, 6);
            this.textBox_DH.Name = "textBox_DH";
            this.textBox_DH.Size = new System.Drawing.Size(461, 96);
            this.textBox_DH.TabIndex = 1;
            this.textBox_DH.Text = "";
            // 
            // doHeartBtn
            // 
            this.doHeartBtn.BackColor = System.Drawing.Color.Transparent;
            this.doHeartBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.doHeartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doHeartBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.doHeartBtn.Location = new System.Drawing.Point(154, 108);
            this.doHeartBtn.Name = "doHeartBtn";
            this.doHeartBtn.Rounded = false;
            this.doHeartBtn.Size = new System.Drawing.Size(167, 32);
            this.doHeartBtn.TabIndex = 0;
            this.doHeartBtn.Text = "Send";
            this.doHeartBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.doHeartBtn.Click += new System.EventHandler(this.doHeartBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage2.Controls.Add(this.flatLabel3);
            this.tabPage2.Controls.Add(this.decayDur_TW);
            this.tabPage2.Controls.Add(this.flatLabel2);
            this.tabPage2.Controls.Add(this.duration_TW);
            this.tabPage2.Controls.Add(this.flatLabel1);
            this.tabPage2.Controls.Add(this.clientNum_TW);
            this.tabPage2.Controls.Add(this.typeWrBtn);
            this.tabPage2.Controls.Add(this.textBox_TW);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(477, 183);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TypeWriter";
            // 
            // flatLabel3
            // 
            this.flatLabel3.AutoSize = true;
            this.flatLabel3.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.flatLabel3.ForeColor = System.Drawing.Color.White;
            this.flatLabel3.Location = new System.Drawing.Point(314, 130);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(74, 19);
            this.flatLabel3.TabIndex = 9;
            this.flatLabel3.Text = "DecayDur";
            // 
            // decayDur_TW
            // 
            this.decayDur_TW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.decayDur_TW.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.decayDur_TW.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.decayDur_TW.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.decayDur_TW.ForeColor = System.Drawing.Color.White;
            this.decayDur_TW.Location = new System.Drawing.Point(394, 124);
            this.decayDur_TW.Maximum = ((long)(9999999));
            this.decayDur_TW.Minimum = ((long)(0));
            this.decayDur_TW.Name = "decayDur_TW";
            this.decayDur_TW.Size = new System.Drawing.Size(73, 30);
            this.decayDur_TW.TabIndex = 8;
            this.decayDur_TW.Text = "flatNumeric2";
            this.decayDur_TW.Value = ((long)(5000));
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(149, 130);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(67, 19);
            this.flatLabel2.TabIndex = 7;
            this.flatLabel2.Text = "Duration";
            // 
            // duration_TW
            // 
            this.duration_TW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.duration_TW.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.duration_TW.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.duration_TW.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.duration_TW.ForeColor = System.Drawing.Color.White;
            this.duration_TW.Location = new System.Drawing.Point(222, 124);
            this.duration_TW.Maximum = ((long)(9999999));
            this.duration_TW.Minimum = ((long)(0));
            this.duration_TW.Name = "duration_TW";
            this.duration_TW.Size = new System.Drawing.Size(73, 30);
            this.duration_TW.TabIndex = 6;
            this.duration_TW.Text = "flatNumeric2";
            this.duration_TW.Value = ((long)(5000));
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(6, 130);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(47, 19);
            this.flatLabel1.TabIndex = 5;
            this.flatLabel1.Text = "Client";
            // 
            // clientNum_TW
            // 
            this.clientNum_TW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.clientNum_TW.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.clientNum_TW.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.clientNum_TW.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.clientNum_TW.ForeColor = System.Drawing.Color.White;
            this.clientNum_TW.Location = new System.Drawing.Point(59, 124);
            this.clientNum_TW.Maximum = ((long)(9999999));
            this.clientNum_TW.Minimum = ((long)(0));
            this.clientNum_TW.Name = "clientNum_TW";
            this.clientNum_TW.Size = new System.Drawing.Size(73, 30);
            this.clientNum_TW.TabIndex = 4;
            this.clientNum_TW.Text = "flatNumeric2";
            this.clientNum_TW.Value = ((long)(0));
            // 
            // typeWrBtn
            // 
            this.typeWrBtn.BackColor = System.Drawing.Color.Transparent;
            this.typeWrBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.typeWrBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.typeWrBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.typeWrBtn.Location = new System.Drawing.Point(130, 80);
            this.typeWrBtn.Name = "typeWrBtn";
            this.typeWrBtn.Rounded = false;
            this.typeWrBtn.Size = new System.Drawing.Size(167, 32);
            this.typeWrBtn.TabIndex = 3;
            this.typeWrBtn.Text = "Send";
            this.typeWrBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.typeWrBtn.Click += new System.EventHandler(this.typeWrBtn_Click);
            // 
            // textBox_TW
            // 
            this.textBox_TW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.textBox_TW.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_TW.Location = new System.Drawing.Point(6, 6);
            this.textBox_TW.Name = "textBox_TW";
            this.textBox_TW.Size = new System.Drawing.Size(461, 68);
            this.textBox_TW.TabIndex = 2;
            this.textBox_TW.Text = "";
            // 
            // DhTimer
            // 
            this.DhTimer.Tick += new System.EventHandler(this.DhTimer_Tick);
            // 
            // TWDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 281);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TWDH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TypeWriter / DoHeart";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.TWDH_Load);
            this.formSkin1.ResumeLayout(false);
            this.flatTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private theme.FormSkin formSkin1;
        private System.Windows.Forms.RichTextBox textBox_DH;
        private theme.FlatButton doHeartBtn;
        private theme.FlatTabControl flatTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private theme.FlatNumeric clientNum_DH;
        private System.Windows.Forms.TabPage tabPage2;
        private theme.FlatLabel flatLabel1;
        private theme.FlatNumeric clientNum_TW;
        private theme.FlatButton typeWrBtn;
        private System.Windows.Forms.RichTextBox textBox_TW;
        private System.Windows.Forms.Timer DhTimer;
        private theme.FlatLabel flatLabel3;
        private theme.FlatNumeric decayDur_TW;
        private theme.FlatLabel flatLabel2;
        private theme.FlatNumeric duration_TW;
        private theme.RadioButton radioButton2;
        private theme.RadioButton radioButton1;
        private theme.RadioButton radioButton3;
        private theme.FlatButton closeBtn;
        private theme.FlatMini flatMini1;
    }
}