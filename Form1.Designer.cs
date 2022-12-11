namespace BankServiceClientApp
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.createAccBtn = new System.Windows.Forms.Button();
            this.createAccResBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.createAccNic = new System.Windows.Forms.TextBox();
            this.createAccAdd = new System.Windows.Forms.TextBox();
            this.createAccPh = new System.Windows.Forms.TextBox();
            this.createAccLastName = new System.Windows.Forms.TextBox();
            this.createAccFirstName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.depositBtn = new System.Windows.Forms.Button();
            this.depositresBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.depositeAmountText = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.WithdrawBtn = new System.Windows.Forms.Button();
            this.withdrawresBox = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.withdrawText = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.transferBtn = new System.Windows.Forms.Button();
            this.transerResBox = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.transferAmount = new System.Windows.Forms.TextBox();
            this.trasnferAccid = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.accsListRefreshBtn = new System.Windows.Forms.Button();
            this.userCurrentBalanceText = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.userAccPassCode = new System.Windows.Forms.TextBox();
            this.userAccIDTextBox = new System.Windows.Forms.TextBox();
            this.btnRefreshBalance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(1, 1);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listBox1);
            this.splitContainer1.Size = new System.Drawing.Size(829, 340);
            this.splitContainer1.SplitterDistance = 510;
            this.splitContainer1.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(817, 677);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.createAccBtn);
            this.tabPage1.Controls.Add(this.createAccResBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.createAccNic);
            this.tabPage1.Controls.Add(this.createAccAdd);
            this.tabPage1.Controls.Add(this.createAccPh);
            this.tabPage1.Controls.Add(this.createAccLastName);
            this.tabPage1.Controls.Add(this.createAccFirstName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(809, 651);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create Account";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // createAccBtn
            // 
            this.createAccBtn.Location = new System.Drawing.Point(148, 254);
            this.createAccBtn.Name = "createAccBtn";
            this.createAccBtn.Size = new System.Drawing.Size(75, 23);
            this.createAccBtn.TabIndex = 11;
            this.createAccBtn.Text = "Create";
            this.createAccBtn.UseVisualStyleBackColor = true;
            this.createAccBtn.Click += new System.EventHandler(this.createAccBtn_Click);
            // 
            // createAccResBox
            // 
            this.createAccResBox.Location = new System.Drawing.Point(304, 17);
            this.createAccResBox.Name = "createAccResBox";
            this.createAccResBox.ReadOnly = true;
            this.createAccResBox.Size = new System.Drawing.Size(174, 212);
            this.createAccResBox.TabIndex = 10;
            this.createAccResBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nic No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phone No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name";
            // 
            // createAccNic
            // 
            this.createAccNic.Location = new System.Drawing.Point(90, 209);
            this.createAccNic.Name = "createAccNic";
            this.createAccNic.Size = new System.Drawing.Size(192, 20);
            this.createAccNic.TabIndex = 4;
            // 
            // createAccAdd
            // 
            this.createAccAdd.Location = new System.Drawing.Point(90, 163);
            this.createAccAdd.Name = "createAccAdd";
            this.createAccAdd.Size = new System.Drawing.Size(192, 20);
            this.createAccAdd.TabIndex = 3;
            // 
            // createAccPh
            // 
            this.createAccPh.Location = new System.Drawing.Point(90, 120);
            this.createAccPh.Name = "createAccPh";
            this.createAccPh.Size = new System.Drawing.Size(192, 20);
            this.createAccPh.TabIndex = 2;
            // 
            // createAccLastName
            // 
            this.createAccLastName.Location = new System.Drawing.Point(90, 76);
            this.createAccLastName.Name = "createAccLastName";
            this.createAccLastName.Size = new System.Drawing.Size(192, 20);
            this.createAccLastName.TabIndex = 1;
            // 
            // createAccFirstName
            // 
            this.createAccFirstName.Location = new System.Drawing.Point(90, 30);
            this.createAccFirstName.Name = "createAccFirstName";
            this.createAccFirstName.Size = new System.Drawing.Size(192, 20);
            this.createAccFirstName.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.depositBtn);
            this.tabPage2.Controls.Add(this.depositresBox);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.depositeAmountText);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(809, 651);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Deposit";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // depositBtn
            // 
            this.depositBtn.Location = new System.Drawing.Point(95, 87);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.Size = new System.Drawing.Size(75, 23);
            this.depositBtn.TabIndex = 3;
            this.depositBtn.Text = "Deposit";
            this.depositBtn.UseVisualStyleBackColor = true;
            this.depositBtn.Click += new System.EventHandler(this.depositBtn_Click);
            // 
            // depositresBox
            // 
            this.depositresBox.Location = new System.Drawing.Point(26, 199);
            this.depositresBox.Name = "depositresBox";
            this.depositresBox.ReadOnly = true;
            this.depositresBox.Size = new System.Drawing.Size(458, 96);
            this.depositresBox.TabIndex = 2;
            this.depositresBox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Amount";
            // 
            // depositeAmountText
            // 
            this.depositeAmountText.Location = new System.Drawing.Point(95, 35);
            this.depositeAmountText.Name = "depositeAmountText";
            this.depositeAmountText.Size = new System.Drawing.Size(167, 20);
            this.depositeAmountText.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.WithdrawBtn);
            this.tabPage3.Controls.Add(this.withdrawresBox);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.withdrawText);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(809, 651);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Withdraw";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // WithdrawBtn
            // 
            this.WithdrawBtn.Location = new System.Drawing.Point(95, 87);
            this.WithdrawBtn.Name = "WithdrawBtn";
            this.WithdrawBtn.Size = new System.Drawing.Size(75, 23);
            this.WithdrawBtn.TabIndex = 5;
            this.WithdrawBtn.Text = "Withdraw";
            this.WithdrawBtn.UseVisualStyleBackColor = true;
            this.WithdrawBtn.Click += new System.EventHandler(this.WithdrawBtn_Click);
            // 
            // withdrawresBox
            // 
            this.withdrawresBox.Location = new System.Drawing.Point(26, 199);
            this.withdrawresBox.Name = "withdrawresBox";
            this.withdrawresBox.ReadOnly = true;
            this.withdrawresBox.Size = new System.Drawing.Size(458, 96);
            this.withdrawresBox.TabIndex = 4;
            this.withdrawresBox.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Amount";
            // 
            // withdrawText
            // 
            this.withdrawText.AcceptsReturn = true;
            this.withdrawText.Location = new System.Drawing.Point(95, 35);
            this.withdrawText.Name = "withdrawText";
            this.withdrawText.Size = new System.Drawing.Size(167, 20);
            this.withdrawText.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.transferBtn);
            this.tabPage4.Controls.Add(this.transerResBox);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.transferAmount);
            this.tabPage4.Controls.Add(this.trasnferAccid);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(809, 651);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Transfer";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // transferBtn
            // 
            this.transferBtn.Location = new System.Drawing.Point(95, 138);
            this.transferBtn.Name = "transferBtn";
            this.transferBtn.Size = new System.Drawing.Size(75, 23);
            this.transferBtn.TabIndex = 6;
            this.transferBtn.Text = "Transfer";
            this.transferBtn.UseVisualStyleBackColor = true;
            this.transferBtn.Click += new System.EventHandler(this.transferBtn_Click);
            // 
            // transerResBox
            // 
            this.transerResBox.Location = new System.Drawing.Point(26, 199);
            this.transerResBox.Name = "transerResBox";
            this.transerResBox.ReadOnly = true;
            this.transerResBox.Size = new System.Drawing.Size(458, 96);
            this.transerResBox.TabIndex = 5;
            this.transerResBox.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 26);
            this.label7.TabIndex = 2;
            this.label7.Text = "Account Id\r\n to transfer";
            // 
            // transferAmount
            // 
            this.transferAmount.Location = new System.Drawing.Point(95, 83);
            this.transferAmount.Name = "transferAmount";
            this.transferAmount.Size = new System.Drawing.Size(167, 20);
            this.transferAmount.TabIndex = 1;
            // 
            // trasnferAccid
            // 
            this.trasnferAccid.Location = new System.Drawing.Point(95, 35);
            this.trasnferAccid.Name = "trasnferAccid";
            this.trasnferAccid.ReadOnly = true;
            this.trasnferAccid.Size = new System.Drawing.Size(167, 20);
            this.trasnferAccid.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(309, 327);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.accsListRefreshBtn);
            this.panel1.Controls.Add(this.userCurrentBalanceText);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.userAccPassCode);
            this.panel1.Controls.Add(this.userAccIDTextBox);
            this.panel1.Controls.Add(this.btnRefreshBalance);
            this.panel1.Location = new System.Drawing.Point(1, 355);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1597, 97);
            this.panel1.TabIndex = 7;
            // 
            // accsListRefreshBtn
            // 
            this.accsListRefreshBtn.Location = new System.Drawing.Point(745, 7);
            this.accsListRefreshBtn.Name = "accsListRefreshBtn";
            this.accsListRefreshBtn.Size = new System.Drawing.Size(75, 23);
            this.accsListRefreshBtn.TabIndex = 15;
            this.accsListRefreshBtn.Text = "Refresh List";
            this.accsListRefreshBtn.UseVisualStyleBackColor = true;
            this.accsListRefreshBtn.Click += new System.EventHandler(this.accsListRefreshBtn_Click);
            // 
            // userCurrentBalanceText
            // 
            this.userCurrentBalanceText.Location = new System.Drawing.Point(558, 60);
            this.userCurrentBalanceText.Name = "userCurrentBalanceText";
            this.userCurrentBalanceText.ReadOnly = true;
            this.userCurrentBalanceText.Size = new System.Drawing.Size(155, 20);
            this.userCurrentBalanceText.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(169, 41);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 12;
            this.textBox4.Text = "Account Passcode";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.ForeColor = System.Drawing.Color.Transparent;
            this.textBox3.Location = new System.Drawing.Point(169, 6);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "Account ID";
            // 
            // userAccPassCode
            // 
            this.userAccPassCode.Location = new System.Drawing.Point(9, 42);
            this.userAccPassCode.Name = "userAccPassCode";
            this.userAccPassCode.Size = new System.Drawing.Size(153, 20);
            this.userAccPassCode.TabIndex = 10;
            // 
            // userAccIDTextBox
            // 
            this.userAccIDTextBox.AccessibleDescription = "";
            this.userAccIDTextBox.AccessibleName = "";
            this.userAccIDTextBox.Location = new System.Drawing.Point(9, 7);
            this.userAccIDTextBox.Name = "userAccIDTextBox";
            this.userAccIDTextBox.Size = new System.Drawing.Size(153, 20);
            this.userAccIDTextBox.TabIndex = 9;
            // 
            // btnRefreshBalance
            // 
            this.btnRefreshBalance.Location = new System.Drawing.Point(719, 60);
            this.btnRefreshBalance.Name = "btnRefreshBalance";
            this.btnRefreshBalance.Size = new System.Drawing.Size(101, 23);
            this.btnRefreshBalance.TabIndex = 8;
            this.btnRefreshBalance.Text = "Refresh Balance";
            this.btnRefreshBalance.UseVisualStyleBackColor = true;
            this.btnRefreshBalance.Click += new System.EventHandler(this.btnRefreshBalance_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(844, 489);
            this.Name = "Form1";
            this.Text = "Bank Service Client Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox userCurrentBalanceText;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox userAccPassCode;
        private System.Windows.Forms.TextBox userAccIDTextBox;
        private System.Windows.Forms.Button btnRefreshBalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox createAccNic;
        private System.Windows.Forms.TextBox createAccAdd;
        private System.Windows.Forms.TextBox createAccPh;
        private System.Windows.Forms.TextBox createAccLastName;
        private System.Windows.Forms.TextBox createAccFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox depositeAmountText;
        private System.Windows.Forms.TextBox transferAmount;
        private System.Windows.Forms.TextBox trasnferAccid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox withdrawText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox createAccResBox;
        private System.Windows.Forms.RichTextBox depositresBox;
        private System.Windows.Forms.RichTextBox withdrawresBox;
        private System.Windows.Forms.RichTextBox transerResBox;
        private System.Windows.Forms.Button createAccBtn;
        private System.Windows.Forms.Button depositBtn;
        private System.Windows.Forms.Button WithdrawBtn;
        private System.Windows.Forms.Button transferBtn;
        private System.Windows.Forms.Button accsListRefreshBtn;
    }
}

