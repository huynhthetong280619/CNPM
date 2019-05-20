using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.IO;

namespace QuanLyCuaHang
{
    public partial class chat : UserControl
    {
        private TcpClient client;
        public StreamReader str;
        public StreamWriter swr;

        public string receive;
        public string textSend;

        public chat()
        {
            InitializeComponent();
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach(IPAddress address in localIP)
            {
                if(address.AddressFamily == AddressFamily.InterNetwork)
                {
                    bunifuMaterialTextbox2.Text = address.ToString();
                }
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(bunifuMaterialTextbox1.Text));
            listener.Start();
            client = listener.AcceptTcpClient();
            str = new StreamReader(client.GetStream());
            swr = new StreamWriter(client.GetStream());
            swr.AutoFlush = true;

            backgroundWorker1.RunWorkerAsync(); //Receive data.
            backgroundWorker2.WorkerSupportsCancellation = true;//Ability  to cancel this thread


        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    receive = str.ReadLine();
                    this.richTextBox2.Invoke(new MethodInvoker(delegate () { richTextBox2.AppendText("You :" + receive + "\n"); }));
                    receive = "";
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                swr.WriteLine(textSend);
                this.richTextBox2.Invoke(new MethodInvoker(delegate () { richTextBox2.AppendText("Me :" + textSend + "\n"); }));
            }
            else
            {
                MessageBox.Show("Send failed !");
            }

            backgroundWorker2.CancelAsync();
        }

        private void circleButton1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                textSend = richTextBox1.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            richTextBox1.Text = "";
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint IP_end = new IPEndPoint(IPAddress.Parse(bunifuMaterialTextbox4.Text), int.Parse(bunifuMaterialTextbox3.Text));

            try
            {
                client.Connect(IP_end);
                if (client.Connected)
                {
                    richTextBox2.AppendText("Connect to server!" + "\n");
                    swr = new StreamWriter(client.GetStream());
                    str = new StreamReader(client.GetStream());
                    swr.AutoFlush = true;

                    backgroundWorker1.RunWorkerAsync(); //Receive data.
                    backgroundWorker2.WorkerSupportsCancellation = true;//Ability  to cancel this thread
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
