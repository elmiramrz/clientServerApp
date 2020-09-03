using System;
using System.Windows.Forms;
using System.Net.Sockets;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
   
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {                     
              clientSocket.Connect("127.0.0.1", 8888);
            lmsg.Text = "Chatting process started...";
               
        }
        private void button1_Click(object sender, EventArgs e)
        {// these codes are sending arithmatic expression only one time to server
            NetworkStream netStream = clientSocket.GetStream();
            byte[] outp = System.Text.Encoding.ASCII.GetBytes(tmsgtoserver.Text + "$");
            netStream.Write(outp, 0, outp.Length);
            netStream.Flush();

            byte[] inp = new byte[20000];
            string returndata = System.Text.Encoding.ASCII.GetString(inp);

            tmsgtoserver.Text = "";
            tmsgtoserver.Focus();
            //these codes are for retrieving answer from server
            byte[] bytes = new byte[clientSocket.ReceiveBufferSize];

            // Read can return anything from 0 to numBytesToRead.
            netStream.Read(bytes, 0, (int)clientSocket.ReceiveBufferSize);

            // Returns the data received from the host to the console.
            string dat = System.Text.Encoding.UTF8.GetString(bytes);

            lans.Text = dat;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

        }

     
    

