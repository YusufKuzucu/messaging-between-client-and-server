using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using Dapper;


namespace Client
{
    public partial class Form1 : Form
    {
        private TcpClient Client;
        public StreamReader STR;
        public StreamWriter STW;
        public string recieve;
        public string TextToSend;
        string connectionString = (@"Server=YUSUF_KUZUCU\SQLEXPRESS; Database=ClientAndServer;Trusted_Connection=true");
        DateTime Time = DateTime.Now;
        public Form1()
        {
            InitializeComponent();
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    ServerIPtextBox1.Text = address.ToString();
                }
            }
        }

        private void Başlabutton_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(ServerPorttextBox.Text));
            listener.Start();
            Client = listener.AcceptTcpClient();
            STR = new StreamReader(Client.GetStream());
            STW = new StreamWriter(Client.GetStream());
            STW.AutoFlush = true;
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;
        }

        private void Bağlabutton_Click(object sender, EventArgs e)
        {
            Client = new TcpClient();
            IPEndPoint IpEndPoint = new IPEndPoint(IPAddress.Parse(ClientIPtextBox.Text), int.Parse(ClientPorttextBox.Text));
            Client.Connect(IpEndPoint);
            try
            {

                listBox1.Items.Add("sunucuya bağlandı" + "\n");
                STW = new StreamWriter(Client.GetStream());
                STR = new StreamReader(Client.GetStream());
                STW.AutoFlush = true;
                backgroundWorker1.RunWorkerAsync();
                backgroundWorker2.WorkerSupportsCancellation = true;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (Client.Connected)
            {
                try
                {
                    recieve = STR.ReadLine();
                    this.listBox1.Invoke(new MethodInvoker(delegate ()
                    {
                        listBox1.Items.Add("server: " + recieve + " \n ");
                    }
                    ));


                    recieve = "";
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

            if (Client.Connected)
            {

                STW.WriteLine(TextToSend);
                this.listBox1.Invoke(new MethodInvoker(delegate ()
                {
                    listBox1.Items.Add("client: " + TextToSend + " \n ");

                }
                ));

            }
            else
            {
                MessageBox.Show("mesaj iletilmedi");

            }
            backgroundWorker2.CancelAsync();
        }

        private void Gönderbutton_Click(object sender, EventArgs e)
        {
            if (MesajYazmatextBox.Text != "")
            {
                TextToSend = MesajYazmatextBox.Text;
                backgroundWorker2.RunWorkerAsync();

            }

            else
            {
                MesajYazmatextBox.Text = "";
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Veritabanına kaydedilecek nesne 
                Messages messages = new Messages { Mesajlar = "client:" + MesajYazmatextBox.Text, Tarih = Time };

                // Veritabanına kayıt ekleme
                connection.Execute("INSERT INTO Mesajlar (Mesajlar, Tarih) VALUES (@Mesajlar, @Tarih)", messages);
            }
        }

        public class Messages
        {
            public int Id { get; set; }
            public string Mesajlar { get; set; }
            public DateTime Tarih { get; set; }
        }
    }
}
