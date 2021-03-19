namespace BlockchainAssignment
{
    partial class BlockchainApp
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GenWallet = new System.Windows.Forms.Button();
            this.ValKeys = new System.Windows.Forms.Button();
            this.GenNewBlock = new System.Windows.Forms.Button();
            this.CreateTransaction = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.ValChain = new System.Windows.Forms.Button();
            this.CheckBal = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox1.Location = new System.Drawing.Point(18, 18);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(984, 481);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Print Block";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 507);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 513);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Public Key:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(549, 513);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(341, 26);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(549, 546);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(341, 26);
            this.textBox3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 552);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Private Key:";
            // 
            // GenWallet
            // 
            this.GenWallet.Location = new System.Drawing.Point(897, 507);
            this.GenWallet.Name = "GenWallet";
            this.GenWallet.Size = new System.Drawing.Size(113, 65);
            this.GenWallet.TabIndex = 7;
            this.GenWallet.Text = "Generate Wallet";
            this.GenWallet.UseVisualStyleBackColor = true;
            this.GenWallet.Click += new System.EventHandler(this.GenWallet_Click);
            // 
            // ValKeys
            // 
            this.ValKeys.Location = new System.Drawing.Point(897, 578);
            this.ValKeys.Name = "ValKeys";
            this.ValKeys.Size = new System.Drawing.Size(113, 40);
            this.ValKeys.TabIndex = 8;
            this.ValKeys.Text = "Validate Keys";
            this.ValKeys.UseVisualStyleBackColor = true;
            this.ValKeys.Click += new System.EventHandler(this.ValKeys_Click);
            // 
            // GenNewBlock
            // 
            this.GenNewBlock.Location = new System.Drawing.Point(18, 552);
            this.GenNewBlock.Name = "GenNewBlock";
            this.GenNewBlock.Size = new System.Drawing.Size(109, 53);
            this.GenNewBlock.TabIndex = 9;
            this.GenNewBlock.Text = "Generate New Block";
            this.GenNewBlock.UseVisualStyleBackColor = true;
            this.GenNewBlock.Click += new System.EventHandler(this.GenNewBlock_Click);
            // 
            // CreateTransaction
            // 
            this.CreateTransaction.Location = new System.Drawing.Point(18, 611);
            this.CreateTransaction.Name = "CreateTransaction";
            this.CreateTransaction.Size = new System.Drawing.Size(109, 64);
            this.CreateTransaction.TabIndex = 10;
            this.CreateTransaction.Text = "Create Transaction";
            this.CreateTransaction.UseVisualStyleBackColor = true;
            this.CreateTransaction.Click += new System.EventHandler(this.CreateTransaction_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 611);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 649);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fee:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(218, 611);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(218, 649);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 26);
            this.textBox5.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 687);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Receiver key:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(123, 684);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(299, 26);
            this.textBox6.TabIndex = 16;
            // 
            // ValChain
            // 
            this.ValChain.Location = new System.Drawing.Point(897, 624);
            this.ValChain.Name = "ValChain";
            this.ValChain.Size = new System.Drawing.Size(113, 65);
            this.ValChain.TabIndex = 17;
            this.ValChain.Text = "Validate Chain";
            this.ValChain.UseVisualStyleBackColor = true;
            this.ValChain.Click += new System.EventHandler(this.ValChain_Click);
            // 
            // CheckBal
            // 
            this.CheckBal.Location = new System.Drawing.Point(740, 578);
            this.CheckBal.Name = "CheckBal";
            this.CheckBal.Size = new System.Drawing.Size(150, 40);
            this.CheckBal.TabIndex = 18;
            this.CheckBal.Text = "Check Balance";
            this.CheckBal.UseVisualStyleBackColor = true;
            this.CheckBal.Click += new System.EventHandler(this.CheckBal_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(422, 598);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Mining Selection: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(431, 624);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "(Pick only one)";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Greedy",
            "Altruistic",
            "Random",
            "None"});
            this.comboBox1.Location = new System.Drawing.Point(561, 598);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BlockchainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1022, 740);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CheckBal);
            this.Controls.Add(this.ValChain);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CreateTransaction);
            this.Controls.Add(this.GenNewBlock);
            this.Controls.Add(this.ValKeys);
            this.Controls.Add(this.GenWallet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BlockchainApp";
            this.Text = "Blockchain App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GenWallet;
        private System.Windows.Forms.Button ValKeys;
        private System.Windows.Forms.Button GenNewBlock;
        private System.Windows.Forms.Button CreateTransaction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button ValChain;
        private System.Windows.Forms.Button CheckBal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

