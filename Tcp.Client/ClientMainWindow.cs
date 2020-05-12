using System;
using System.Windows.Forms;
using SomeProject.Library.Client;
using SomeProject.Library;

namespace SomeProject.TcpClient
{
    public partial class ClientMainWindow : Form
    {
        byte sessionID = 0;

        public ClientMainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sends text from text box to server. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnMsgBtnClick(object sender, EventArgs e)
        {
            Client client = new Client(sessionID);
            Result res = client.SendMessageToServer(textBox.Text).Result;
            if(res == Result.OK)
            {
                textBox.Text = "";
                labelRes.Text = "Message was sent succefully!";
                labelServRespond.Text = client.ReceiveMessageFromServer().Message;                
            }
            else
            {
                labelRes.Text = "Cannot send the message to the server.";
            }
            sessionID = client.clientSessionID;
            //timer.Interval = 2000;
            //timer.Start();
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            labelRes.Text = "";
            labelServRespond.Text = "";
            timer.Stop();
        }

        /// <summary>
        /// Opens file dialog.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOpF_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBoxFile.Text = openFileDialog1.FileName;
        }


        /// <summary>
        /// Sends file to server.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSndF_Click(object sender, EventArgs e)
        {
            Client client = new Client(sessionID);
            Result res = client.SendFileToServer(textBoxFile.Text).Result;     
            if (res == Result.OK)
            {
                labelRes.Text = "File was sent succefully!";
                labelServRespond.Text = client.ReceiveMessageFromServer().Message;
            }
            else
            {
                labelRes.Text = "Cannot send the file to the server.";
            }
            //timer.Interval = 2000;
            //timer.Start();
        }

        /// <summary>
        /// Sends connect message to server and recieves new client ID.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientMainWindow_Load(object sender, EventArgs e)
        {
            Client client = new Client(sessionID);
            OperationResult result = client.SendMessageToServer("Connected.");
            labelServRespond.Text = client.ReceiveMessageFromServer().Message;
            sessionID = client.clientSessionID;
        }

        /// <summary>
        /// Sends disconnect message to server.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientMainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Client client = new Client(sessionID);
            client.DisconnectFromServer();
            sessionID = client.clientSessionID;
        }
    }
}
