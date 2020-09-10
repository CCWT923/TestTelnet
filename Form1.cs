using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WTStudio;
using System.Diagnostics;

namespace TestTelnet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TelnetConnection telnet;
        private void button1_Click(object sender, EventArgs e)
        {
            if(TextBox_TelnetServerAddress.Text.Trim() == string.Empty)
            {
                return;
            }
            var server = TextBox_TelnetServerAddress.Text.Trim();
            var userName = TextBox_UserName.Text.Trim();
            var password = TextBox_Password.Text;
            int port;
            if (!int.TryParse(TextBox_TelnetPort.Text, out port))
            {
                port = 23;
            }

            if(telnet == null || !telnet.IsConnected)
            {
                telnet = new TelnetConnection(server, port);
                try
                {
                    var s = telnet.Login(userName, password, 500);
                    ShowLog(s);
                    Button_Connect.Text = "已连接";
                }
                catch(Exception ex)
                {
                    ShowLog(ex.Message);
                }
                
            }
            else
            {
                return;
                
            }
        }

        private void ShowLog(string s)
        {
            //textBox1.Text += telnet.IsConnected.ToString() + Environment.NewLine;
            TextBox_Log.Text += s + Environment.NewLine;
        }

        private void Button_SendCommand_Click(object sender, EventArgs e)
        {
            if(telnet == null || !telnet.IsConnected)
            {
                ShowLog("请先连接服务器！");
                return;
            }
            if (TextBox_Command.Text.Trim() == "")
            {
                ShowLog("请输入命令！");
                return;
            }
            telnet.WriteLine(TextBox_Command.Text);
            ShowLog(telnet.Read());
        }
    }
}
