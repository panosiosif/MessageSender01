namespace MessageSender01
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
            this.components = new System.ComponentModel.Container();
            this.buttonSendHello = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelMain = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonConfirmCredentials = new System.Windows.Forms.Button();
            this.buttonLoadPrevCredentials = new System.Windows.Forms.Button();
            this.buttonConfirmAddress = new System.Windows.Forms.Button();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonLoadPrevAddress = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.buttonSendContinuously = new System.Windows.Forms.Button();
            this.buttonStopSending = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSendHello
            // 
            this.buttonSendHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendHello.Location = new System.Drawing.Point(12, 256);
            this.buttonSendHello.Name = "buttonSendHello";
            this.buttonSendHello.Size = new System.Drawing.Size(260, 34);
            this.buttonSendHello.TabIndex = 0;
            this.buttonSendHello.Text = "Send \"Hello\" once";
            this.buttonSendHello.UseVisualStyleBackColor = true;
            this.buttonSendHello.Click += new System.EventHandler(this.buttonHello_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(39, 92);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(103, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Device Name";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(148, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 26);
            this.textBox1.TabIndex = 3;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(12, 124);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(130, 20);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Device Password";
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMain.Location = new System.Drawing.Point(12, 9);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(539, 24);
            this.labelMain.TabIndex = 5;
            this.labelMain.Text = "Welcome to Message Sender. Please Enter Device Credentials";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(148, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(124, 26);
            this.textBox2.TabIndex = 6;
            // 
            // buttonConfirmCredentials
            // 
            this.buttonConfirmCredentials.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmCredentials.Location = new System.Drawing.Point(12, 153);
            this.buttonConfirmCredentials.Name = "buttonConfirmCredentials";
            this.buttonConfirmCredentials.Size = new System.Drawing.Size(260, 37);
            this.buttonConfirmCredentials.TabIndex = 7;
            this.buttonConfirmCredentials.Text = "Confirm Credentials";
            this.buttonConfirmCredentials.UseVisualStyleBackColor = true;
            this.buttonConfirmCredentials.Click += new System.EventHandler(this.buttonConfirmCredentials_Click);
            // 
            // buttonLoadPrevCredentials
            // 
            this.buttonLoadPrevCredentials.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadPrevCredentials.Location = new System.Drawing.Point(12, 55);
            this.buttonLoadPrevCredentials.Name = "buttonLoadPrevCredentials";
            this.buttonLoadPrevCredentials.Size = new System.Drawing.Size(260, 28);
            this.buttonLoadPrevCredentials.TabIndex = 8;
            this.buttonLoadPrevCredentials.Text = "Load Previous Credentials";
            this.buttonLoadPrevCredentials.UseVisualStyleBackColor = true;
            this.buttonLoadPrevCredentials.Click += new System.EventHandler(this.buttonLoadPrevCredentials_Click);
            // 
            // buttonConfirmAddress
            // 
            this.buttonConfirmAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmAddress.Location = new System.Drawing.Point(279, 55);
            this.buttonConfirmAddress.Name = "buttonConfirmAddress";
            this.buttonConfirmAddress.Size = new System.Drawing.Size(342, 28);
            this.buttonConfirmAddress.TabIndex = 9;
            this.buttonConfirmAddress.Text = "Load Previous Address";
            this.buttonConfirmAddress.UseVisualStyleBackColor = true;
            this.buttonConfirmAddress.Click += new System.EventHandler(this.buttonLoadPrevAddress_Click);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(278, 92);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(153, 20);
            this.labelAddress.TabIndex = 10;
            this.labelAddress.Text = "Destination Address";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(437, 89);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(184, 26);
            this.textBox3.TabIndex = 11;
            // 
            // buttonLoadPrevAddress
            // 
            this.buttonLoadPrevAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadPrevAddress.Location = new System.Drawing.Point(278, 153);
            this.buttonLoadPrevAddress.Name = "buttonLoadPrevAddress";
            this.buttonLoadPrevAddress.Size = new System.Drawing.Size(343, 37);
            this.buttonLoadPrevAddress.TabIndex = 12;
            this.buttonLoadPrevAddress.Text = "Confirm Address";
            this.buttonLoadPrevAddress.UseVisualStyleBackColor = true;
            this.buttonLoadPrevAddress.Click += new System.EventHandler(this.buttonConfirmsAddress_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Send Custome Message:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(278, 353);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(343, 26);
            this.textBox4.TabIndex = 14;
            // 
            // buttonSendContinuously
            // 
            this.buttonSendContinuously.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendContinuously.Location = new System.Drawing.Point(12, 296);
            this.buttonSendContinuously.Name = "buttonSendContinuously";
            this.buttonSendContinuously.Size = new System.Drawing.Size(419, 34);
            this.buttonSendContinuously.TabIndex = 15;
            this.buttonSendContinuously.Text = "Send Time and Date continuously";
            this.buttonSendContinuously.UseVisualStyleBackColor = true;
            this.buttonSendContinuously.Click += new System.EventHandler(this.buttonSendContinuously_Click);
            // 
            // buttonStopSending
            // 
            this.buttonStopSending.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStopSending.Location = new System.Drawing.Point(437, 296);
            this.buttonStopSending.Name = "buttonStopSending";
            this.buttonStopSending.Size = new System.Drawing.Size(184, 34);
            this.buttonStopSending.TabIndex = 16;
            this.buttonStopSending.Text = "Stop Sending";
            this.buttonStopSending.UseVisualStyleBackColor = true;
            this.buttonStopSending.Click += new System.EventHandler(this.buttonStopSending_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonSend
            // 
            this.buttonSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSend.Location = new System.Drawing.Point(437, 385);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(184, 34);
            this.buttonSend.TabIndex = 17;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 434);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonStopSending);
            this.Controls.Add(this.buttonSendContinuously);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonLoadPrevAddress);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.buttonConfirmAddress);
            this.Controls.Add(this.buttonLoadPrevCredentials);
            this.Controls.Add(this.buttonConfirmCredentials);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelMain);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonSendHello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSendHello;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonConfirmCredentials;
        private System.Windows.Forms.Button buttonLoadPrevCredentials;
        private System.Windows.Forms.Button buttonConfirmAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonLoadPrevAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button buttonSendContinuously;
        private System.Windows.Forms.Button buttonStopSending;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonSend;
    }
}

