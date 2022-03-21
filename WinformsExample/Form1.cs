using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsExample
{
    public partial class Form1 : Form
    {
        TreeNode mainNode;
        public Form1()
        {
            InitializeComponent();
            mainNode = new TreeNode();
            Thread thr = new Thread(new ThreadStart(this.Sever));
            thr.Start();

            numA.Text = "0";
            numB.Text = "0";
        }

        private void add_Click(object sender, EventArgs e)
        {
            int res = int.Parse(this.numA.Text) + int.Parse(this.numB.Text);
            this.result.Text = res.ToString();
            this.mainNode.Name = "mainNode";
            this.mainNode.Text = "Main";
            this.treeView1.Nodes.Add(mainNode);
        }
        private void InvokeUI(Action a)
        {
            this.BeginInvoke(new MethodInvoker(a));
        }
        private string ToString(byte[] bytes)
        {
            string response = string.Empty;

            foreach (byte b in bytes)
                response += (Char)b;

            return response;
        }
        public void Sever()
        {
            TcpListener server = new TcpListener(IPAddress.Any, 9999);
            server.Start();
            TcpClient client = server.AcceptTcpClient();  //if a connection exists, the server will accept it

            NetworkStream ns = client.GetStream(); //networkstream is used to send/receive messages

           
            while (client.Connected)  //while the client is connected, we look for incoming messages
            {
                byte[] msg = new byte[1024];     //the messages arrive as byte array
                ns.Read(msg, 0, msg.Length);   //the same networkstream reads the message sent by the client
                InvokeUI(() => {
                    this.recv.Text = ToString(msg);
                });
               // this.recv.Text = ToString(msg);
            }
        }
    }
}
