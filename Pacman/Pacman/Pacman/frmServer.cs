using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Net.Security;
using System.Windows.Forms;

namespace Pacman
{

    public partial class frmServer : Form
    {
        TcpClient tcpclient = new TcpClient();
        private Hashtable ht = new Hashtable();
        IPAddress myIP = IPAddress.Parse("127.0.0.1");
        TcpListener myList;

        public void StartServer()
        {
            myList = new TcpListener(myIP, 65000);

            lstEvents.Items.Add("Starter server, IP: " + myIP + "Port: 65000...");

            myList.Start();
            while (true)
            {
                Socket s = myList.AcceptSocket();
                NetworkStream socketStream = new NetworkStream(s);
                BinaryReader reader = new BinaryReader(socketStream);
            }
        }

        public frmServer()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartServer();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
