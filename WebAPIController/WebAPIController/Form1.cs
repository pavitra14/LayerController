using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace WebAPIController
{
    public partial class Form1 : Form
    {
        String layercommand;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("BF3_WEBSPELL");
            comboBox2.Items.Add("BF3_48pATG");
            comboBox2.Items.Add("BF4_SCRIM");
            comboBox2.Items.Add("BF4_DOM");
            comboBox2.Items.Add("BF4_CQ");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //do nothing :|
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string serveraddress = "http://" + ip.Text + ":" + vpsport.Value;
            string arguments = String.Format(
                "/{0}/{1}/{2}/{3}/{4}/{5}/{6}/{7}/{8}/{9}/{10}",
                "new", //for {0}
                key.Text,//{1}
                servername.Text, //{2}
                serverip.Text,//{3}
                serverPort.Value,//{4}
                serverpass.Text,//{5}
                layerusername.Text,//{6}
                layerpass.Text,//{7}
                Layerport.Value,//{8}
                comboBox1.SelectedItem,//{9}
                initials.Text//{10}
                );
            string url = serveraddress + arguments;
            string msg = String.Format(
                "MAKE SURE YOU HAVE ENTERED THE RIGHT DETAILS! THE FOLLOWING DATA WILL BE SENT TO THE SERVER AT {0} \n DATA = {1}",
                serveraddress,
                arguments
                );
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result;
            result = MessageBox.Show(msg, "WARNING", buttons);
            if(result == System.Windows.Forms.DialogResult.OK)
            {
                //send the data to server
                sendData(url);
                
            }
            else
            {
                //do nothing
            }
        }
        private void sendData(string data)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(data);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream resStream = response.GetResponseStream();
            StreamReader sr = new StreamReader(resStream);
            string reply = sr.ReadToEnd();
            MessageBox.Show(reply, "Reply from server", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string serveraddress = "http://" + ip.Text + ":" + vpsport.Value;
            string arguments = command.Text;
            string url = serveraddress + arguments;
            sendData(url);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void serverpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == "BF3_WEBSPELL")
            {
                layercommand = "startup-bf3-webspell.sh";
            }
            else if (comboBox2.SelectedItem == "BF3_48pATG")
            {
                layercommand = "startup_bf3_atg.sh";
            }
            else if (comboBox2.SelectedItem == "BF4_SCRIM")
            {
                layercommand = "startup-bf4-scrim.sh";
            }
            else if (comboBox2.SelectedItem == "BF4_DOM")
            {
                layercommand = "startup-bf4-dom.sh";
            }
            else if (comboBox2.SelectedItem == "BF4_CQ")
            {
                layercommand = "startup-bf4-cq.sh";
            }
            else
            {
                MessageBox.Show("PLEASE SELECT A LAYER");
            }
            string serveraddress = "http://" + ip.Text + ":" + vpsport.Value;
            string arguments = String.Format("/{0}/{1}/{2}", "start", key.Text, layercommand);
            string url = serveraddress + arguments;
            sendData(url);
        }

        private void button4_Click(object sender, EventArgs e)
        {
           /* if (comboBox2.SelectedItem == "BF3_WEBSPELL")
            {
                layercommand = "shutdown-bf3-webspell.sh";
            }
            else if (comboBox2.SelectedItem == "BF3_48pATG")
            {
                layercommand = "shutdown_bf3_atg.sh";
            }
            else if (comboBox2.SelectedItem == "BF4_SCRIM")
            {
                layercommand = "shutdown-bf4-scrim.sh";
            }
            else if (comboBox2.SelectedItem == "BF4_DOM")
            {
                layercommand = "shutdown-bf4-dom.sh";
            }
            else if (comboBox2.SelectedItem == "BF4_CQ")
            {
                layercommand = "shutdown-bf4-cq.sh";
            }
            else
            {
                MessageBox.Show("PLEASE SELECT A LAYER");
            }
            string serveraddress = "http://" + ip.Text + ":" + vpsport.Value;
            string arguments = String.Format("/{0}/{1}/{2}", "stop", key.Text, layercommand);
            string url = serveraddress + arguments;
            sendData(url);*/
            MessageBox.Show("Not implemented!");
        }
    }
}
