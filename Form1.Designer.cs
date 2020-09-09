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
            this.SuspendLayout();
            // 
            // Button_Connect
            // 
            this.Button_Connect.Location = new System.Drawing.Point(15, 184);
            this.Button_Connect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button_Connect.Name = "Button_Connect";
            this.Button_Connect.Size = new System.Drawing.Size(131, 38);
            this.Button_Connect.TabIndex = 0;
            this.Button_Connect.Text = "连接";
            this.Button_Connect.UseVisualStyleBackColor = true;
            this.Button_Connect.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBox_Log
            // 
            this.TextBox_Log.Location = new System.Drawing.Point(249, 104);
            this.TextBox_Log.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox_Log.Multiline = true;
            this.TextBox_Log.Name = "TextBox_Log";
            this.TextBox_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_Log.Size = new System.Drawing.Size(805, 445);
            this.TextBox_Log.TabIndex = 1;
            // 
            // TextBox_Command
            // 
            this.TextBox_Command.Location = new System.Drawing.Point(249, 60);
            this.TextBox_Command.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox_Command.Name = "TextBox_Command";
            this.TextBox_Command.Size = new System.Drawing.Size(671, 25);
            this.TextBox_Command.TabIndex = 2;
            // 
            // TextBox_TelnetServerAddress
            // 
            this.TextBox_TelnetServerAddress.Location = new System.Drawing.Point(15, 60);
            this.TextBox_TelnetServerAddress.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_TelnetServerAddress.Name = "TextBox_TelnetServerAddress";
            this.TextBox_TelnetServerAddress.Size = new System.Drawing.Size(150, 25);
            this.TextBox_TelnetServerAddress.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Telnet 服务器地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "端口：";
            // 
            // TextBox_TelnetPort
            // 
            this.TextBox_TelnetPort.Location = new System.Drawing.Point(13, 135);
            this.TextBox_TelnetPort.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_TelnetPort.Name = "TextBox_TelnetPort";
            this.TextBox_TelnetPort.Size = new System.Drawing.Size(152, 25);
            this.TextBox_TelnetPort.TabIndex = 2;
            this.TextBox_TelnetPort.Text = "23";
            // 
            // Button_SendCommand
            // 
            this.Button_SendCommand.Location = new System.Drawing.Point(923, 60);
            this.Button_SendCommand.Margin = new System.Windows.Forms.Padding(4);
            this.Button_SendCommand.Name = "Button_SendCommand";
            this.Button_SendCommand.Size = new System.Drawing.Size(131, 25);
            this.Button_SendCommand.TabIndex = 0;
            this.Button_SendCommand.Text = "发送";
            this.Button_SendCommand.UseVisualStyleBackColor = true;
            this.Button_SendCommand.Click += new System.EventHandler(this.Button_SendCommand_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "命令：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_TelnetPort);
            this.Controls.Add(this.TextBox_TelnetServerAddress);
            this.Controls.Add(this.TextBox_Command);
            this.Controls.Add(this.TextBox_Log);
            this.Controls.Add(this.Button_SendCommand);
            this.Controls.Add(this.Button_Connect);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}

