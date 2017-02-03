using LaserServer2017_2_3.Base;
using LaserServer2017_2_3.Event;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LaserServer2017_2_3
{
    public partial class Form1 : Form
    {
        public event ShowMessageHandle showMessageEvent;

        private BTServer appServer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showMessageEvent += showLog;

            appServer = new BTServer();
            appServer.NewSessionConnected += newSessionConnected;
            appServer.NewRequestReceived += newRequestReceived;
        }

        private void newRequestReceived(BTSession session, BTRequestInfo requestInfo)
        {
            if (requestInfo.command == "supplyWater")
            {
                showMessageEvent("排水");
            }
            else
            {
                showMessageEvent("....");
            }
        }

        private void newSessionConnected(BTSession session)
        {
        }

        private void showLog(string message)
        {
            this.BeginInvoke((MethodInvoker)delegate()
            {
                LogLv.Items.Add(message);
            });
        }

        private void startListenBtn_Click(object sender, EventArgs e)
        {
            if (!appServer.Setup(10111))
            {
                showMessageEvent("faided set up");
            }
            showMessageEvent("success set up");

            if (!appServer.Start())
            {
                showMessageEvent("faided start");
            }

            showMessageEvent("success start");
        }

        private void stopListenBtn_Click(object sender, EventArgs e)
        {
            if (appServer != null)
            {
                appServer.Stop();
            }

            showMessageEvent("success stop");
        }
    }
}