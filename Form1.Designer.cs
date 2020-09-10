namespace TestTelnet
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_Connect = new System.Windows.Forms.Button();
            this.TextBox_Log = new System.Windows.Forms.TextBox();
            this.TextBox_Command = new System.Windows.Forms.TextBox();
            this.TextBox_TelnetServerAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_TelnetPort = new System.Windows.Forms.TextBox();
            this.Button_SendCommand = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_UserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_Connect
            // 
            this.Button_Connect.Location = new System.Drawing.Point(11, 267);
            this.Button_Connect.Name = "Button_Connect";
            this.Button_Connect.Size = new System.Drawing.Size(98, 30);
            this.Button_Connect.TabIndex = 0;
            this.Button_Connect.Text = "连接";
            this.Button_Connect.UseVisualStyleBackColor = true;
            this.Button_Connect.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBox_Log
            // 
            this.TextBox_Log.Location = new System.Drawing.Point(173, 83);
            this.TextBox_Log.Multiline = true;
            this.TextBox_Log.Name = "TextBox_Log";
            this.TextBox_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_Log.Size = new System.Drawing.Size(619, 357);
            this.TextBox_Log.TabIndex = 1;
            // 
            // TextBox_Command
            // 
            this.TextBox_Command.Location = new System.Drawing.Point(173, 48);
            this.TextBox_Command.Name = "TextBox_Command";
            this.TextBox_Command.Size = new System.Drawing.Size(518, 21);
            this.TextBox_Command.TabIndex = 2;
            // 
            // TextBox_TelnetServerAddress
            // 
            this.TextBox_TelnetServerAddress.Location = new System.Drawing.Point(11, 48);
            this.TextBox_TelnetServerAddress.Name = "TextBox_TelnetServerAddress";
            this.TextBox_TelnetServerAddress.Size = new System.Drawing.Size(114, 21);
            this.TextBox_TelnetServerAddress.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Telnet 服务器地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "端口：";
            // 
            // TextBox_TelnetPort
            // 
            this.TextBox_TelnetPort.Location = new System.Drawing.Point(10, 108);
            this.TextBox_TelnetPort.Name = "TextBox_TelnetPort";
            this.TextBox_TelnetPort.Size = new System.Drawing.Size(115, 21);
            this.TextBox_TelnetPort.TabIndex = 2;
            this.TextBox_TelnetPort.Text = "23";
            // 
            // Button_SendCommand
            // 
            this.Button_SendCommand.Location = new System.Drawing.Point(692, 48);
            this.Button_SendCommand.Name = "Button_SendCommand";
            this.Button_SendCommand.Size = new System.Drawing.Size(98, 20);
            this.Button_SendCommand.TabIndex = 0;
            this.Button_SendCommand.Text = "发送";
            this.Button_SendCommand.UseVisualStyleBackColor = true;
            this.Button_SendCommand.Click += new System.EventHandler(this.Button_SendCommand_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "命令：";
            // 
            // TextBox_UserName
            // 
            this.TextBox_UserName.Location = new System.Drawing.Point(11, 168);
            this.TextBox_UserName.Name = "TextBox_UserName";
            this.TextBox_UserName.Size = new System.Drawing.Size(115, 21);
            this.TextBox_UserName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "用户名：";
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.Location = new System.Drawing.Point(10, 224);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.Size = new System.Drawing.Size(115, 21);
            this.TextBox_Password.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 199);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "密码：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_Password);
            this.Controls.Add(this.TextBox_UserName);
            this.Controls.Add(this.TextBox_TelnetPort);
            this.Controls.Add(this.TextBox_TelnetServerAddress);
            this.Controls.Add(this.TextBox_Command);
            this.Controls.Add(this.TextBox_Log);
            this.Controls.Add(this.Button_SendCommand);
            this.Controls.Add(this.Button_Connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Connect;
        private System.Windows.Forms.TextBox TextBox_Log;
        private System.Windows.Forms.TextBox TextBox_Command;
        private System.Windows.Forms.TextBox TextBox_TelnetServerAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox_TelnetPort;
        private System.Windows.Forms.Button Button_SendCommand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBox_UserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.Label label5;
    }
}

