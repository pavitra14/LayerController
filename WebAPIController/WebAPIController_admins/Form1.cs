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

namespace WebAPIController_admins
{
    public partial class Form1 : Form
    {
        String layercommand;
        int version = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //Check for updates
            //try
            //{
               // string updates = sendGet("http://prod.pavitra14.in/update-layer-admins");
                
             //   string updates2 = sendGet("http://prod.pavitra14.in/update-layer-admins2");
             //   if (version < Int16.Parse(updates))
             //   {
             //       MessageBox.Show("This version has expired, please get the latest version from" + updates2 + " . (Sorry, didnt get time to work on update mechanism)", "Version Expired!", MessageBoxButtons.OK, MessageBoxIcon.Error);
             //       Application.Exit();
             //   }
           // }
            //catch (Exception ex)
            //{

            //}
             
            //Disable the Button
            button3.Enabled = false;
            //set the combo box values
            comboBox2.Items.Add("BF3_WEBSPELL");
            comboBox2.Items.Add("BF3_48pATG");
            comboBox2.Items.Add("BF4_SCRIM");
            comboBox2.Items.Add("BF4_DOM");
            comboBox2.Items.Add("BF4_CQ");
            comboBox2.Items.Add("BF4_SCR2");
            //check for server status
            try
            {
                string serveraddress = "http://192.99.168.162:13000";
                string arguments = "/status";
                string url = serveraddress + arguments;
                string reply = sendData2(url);
                if(reply == "Online")
                {
                    label2.ForeColor = Color.Green;
                    label2.Text = "Online [Server is listening]";
                    button3.Enabled = true;
                }
                else
                {
                    label2.ForeColor = Color.Red;
                    label2.Text = "Offline [Server is down, please contact Pavitra to have it up!]";
                    button3.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                label2.ForeColor = Color.Red;
                label2.Text = "Offline [Server is down, please contact Pavitra to have it up!]";
                button3.Enabled = false;
            }
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
            else if (comboBox2.SelectedItem == "BF4_SCR2")
            {
                layercommand = "startup_bf4_scr2.sh";
            }
            else
            {
                MessageBox.Show("PLEASE SELECT A LAYER");
            }
            string serveraddress = "http://192.99.168.162:13000";
            string arguments = String.Format("/{0}/{1}/{2}", "start", "b7537f18889e1bbac6e1881000aba2e7", layercommand);
            string url = serveraddress + arguments;
            sendData1(url);
        }
        private void sendData1(string data)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(data);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream resStream = response.GetResponseStream();
            StreamReader sr = new StreamReader(resStream);
            string reply = sr.ReadToEnd();
            MessageBox.Show(reply, "Reply from server", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private string sendData2(string data)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(data);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream resStream = response.GetResponseStream();
            StreamReader sr = new StreamReader(resStream);
            string reply = sr.ReadToEnd();
            return reply;
        }
        private string sendGet(string data)
        {
            WebClient client = new WebClient();

            // Add a user agent header in case the  
            // requested URI contains a query.

            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

            Stream data2 = client.OpenRead(data);
            StreamReader reader = new StreamReader(data2);
            string s = reader.ReadToEnd();
            return s;
            data2.Close();
            reader.Close();
        }
    }
}
