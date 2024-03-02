namespace Sendmailkas
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabMain = new TabControl();
            tabPage1 = new TabPage();
            txtPwdFrom = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtAddressTo = new TextBox();
            llSend = new LinkLabel();
            groupBox1 = new GroupBox();
            txtMail = new TextBox();
            label3 = new Label();
            llCheck = new LinkLabel();
            txtBalance = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtAddress = new TextBox();
            tabPage2 = new TabPage();
            label4 = new Label();
            txtPort = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtIP = new TextBox();
            lblInfo = new Label();
            tabMain.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabPage1);
            tabMain.Controls.Add(tabPage2);
            tabMain.Dock = DockStyle.Fill;
            tabMain.Location = new Point(0, 0);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(800, 377);
            tabMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblInfo);
            tabPage1.Controls.Add(txtPwdFrom);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(txtAddressTo);
            tabPage1.Controls.Add(llSend);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(llCheck);
            tabPage1.Controls.Add(txtBalance);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtAddress);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 347);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Mailkas";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtPwdFrom
            // 
            txtPwdFrom.Location = new Point(147, 52);
            txtPwdFrom.Name = "txtPwdFrom";
            txtPwdFrom.PasswordChar = '*';
            txtPwdFrom.Size = new Size(162, 23);
            txtPwdFrom.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 58);
            label8.Name = "label8";
            label8.Size = new Size(101, 17);
            label8.TabIndex = 15;
            label8.Text = "From Password:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 92);
            label7.Name = "label7";
            label7.Size = new Size(127, 17);
            label7.TabIndex = 14;
            label7.Text = "To Kaspa Address：";
            // 
            // txtAddressTo
            // 
            txtAddressTo.Location = new Point(183, 86);
            txtAddressTo.Name = "txtAddressTo";
            txtAddressTo.Size = new Size(496, 23);
            txtAddressTo.TabIndex = 13;
            // 
            // llSend
            // 
            llSend.AutoSize = true;
            llSend.Location = new Point(680, 122);
            llSend.Name = "llSend";
            llSend.Size = new Size(85, 17);
            llSend.TabIndex = 12;
            llSend.TabStop = true;
            llSend.Text = "Send mailkas";
            llSend.LinkClicked += llSend_LinkClicked;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMail);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(3, 153);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(786, 191);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mail text";
            // 
            // txtMail
            // 
            txtMail.Dock = DockStyle.Fill;
            txtMail.Location = new Point(3, 19);
            txtMail.Multiline = true;
            txtMail.Name = "txtMail";
            txtMail.ScrollBars = ScrollBars.Vertical;
            txtMail.Size = new Size(780, 169);
            txtMail.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(603, 58);
            label3.Name = "label3";
            label3.Size = new Size(29, 17);
            label3.TabIndex = 10;
            label3.Text = "Kas";
            // 
            // llCheck
            // 
            llCheck.AutoSize = true;
            llCheck.Location = new Point(652, 55);
            llCheck.Name = "llCheck";
            llCheck.Size = new Size(132, 17);
            llCheck.TabIndex = 8;
            llCheck.TabStop = true;
            llCheck.Text = "Check Kaspa Balance";
            llCheck.LinkClicked += llCheck_LinkClicked;
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(411, 52);
            txtBalance.Name = "txtBalance";
            txtBalance.ReadOnly = true;
            txtBalance.Size = new Size(186, 23);
            txtBalance.TabIndex = 9;
            txtBalance.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(315, 58);
            label2.Name = "label2";
            label2.Size = new Size(90, 17);
            label2.TabIndex = 7;
            label2.Text = "From Balance:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 23);
            label1.Name = "label1";
            label1.Size = new Size(142, 17);
            label1.TabIndex = 6;
            label1.Text = "From Kaspa Address：";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(183, 17);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(496, 23);
            txtAddress.TabIndex = 5;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(txtPort);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(txtIP);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 347);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Settings";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(152, 233);
            label4.Name = "label4";
            label4.Size = new Size(570, 17);
            label4.TabIndex = 15;
            label4.Text = "Donate address: kaspa:qpje7d7x4w0hme7yzxtvas0qmj5h946p3vpxhag56wqwrkamfshxq4ev0kczz";
            // 
            // txtPort
            // 
            txtPort.Location = new Point(162, 46);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(186, 23);
            txtPort.TabIndex = 14;
            txtPort.Text = "16110";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(121, 46);
            label5.Name = "label5";
            label5.Size = new Size(35, 17);
            label5.TabIndex = 13;
            label5.Text = "Port:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 20);
            label6.Name = "label6";
            label6.Size = new Size(120, 17);
            label6.TabIndex = 12;
            label6.Text = "Kaspa Net IP(host):";
            // 
            // txtIP
            // 
            txtIP.Location = new Point(162, 17);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(360, 23);
            txtIP.TabIndex = 11;
            txtIP.Text = "localhost";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(35, 122);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(0, 17);
            lblInfo.TabIndex = 17;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 377);
            Controls.Add(tabMain);
            Name = "frmMain";
            Text = "Send mail from kaspa to kaspa";
            Load += frmMain_Load;
            tabMain.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabMain;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label3;
        private LinkLabel llCheck;
        private TextBox txtBalance;
        private Label label2;
        private Label label1;
        private TextBox txtAddress;
        private TextBox txtPort;
        private Label label5;
        private Label label6;
        private TextBox txtIP;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox txtMail;
        private Label label7;
        private TextBox txtAddressTo;
        private LinkLabel llSend;
        private TextBox txtPwdFrom;
        private Label label8;
        private Label lblInfo;
    }
}