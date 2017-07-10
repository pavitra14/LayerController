namespace WebAPIController
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vpsport = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.serverpass = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.layerpass = new System.Windows.Forms.TextBox();
            this.layerusername = new System.Windows.Forms.TextBox();
            this.serverip = new System.Windows.Forms.TextBox();
            this.servername = new System.Windows.Forms.TextBox();
            this.initials = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Layerport = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.serverPort = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.key = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.command = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vpsport)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Layerport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverPort)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "I.P. of VPS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PORT :";
            // 
            // vpsport
            // 
            this.vpsport.Location = new System.Drawing.Point(320, 25);
            this.vpsport.Maximum = new decimal(new int[] {
            65530,
            0,
            0,
            0});
            this.vpsport.Name = "vpsport";
            this.vpsport.Size = new System.Drawing.Size(84, 20);
            this.vpsport.TabIndex = 2;
            this.vpsport.Value = new decimal(new int[] {
            13000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "(default)";
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(109, 24);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(109, 20);
            this.ip.TabIndex = 4;
            this.ip.Text = "192.99.168.162";
            this.ip.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "(default)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.serverpass);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.layerpass);
            this.groupBox1.Controls.Add(this.layerusername);
            this.groupBox1.Controls.Add(this.serverip);
            this.groupBox1.Controls.Add(this.servername);
            this.groupBox1.Controls.Add(this.initials);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.Layerport);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.serverPort);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(19, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 180);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create a new Layer";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // serverpass
            // 
            this.serverpass.Location = new System.Drawing.Point(106, 89);
            this.serverpass.Name = "serverpass";
            this.serverpass.Size = new System.Drawing.Size(126, 20);
            this.serverpass.TabIndex = 22;
            this.serverpass.TextChanged += new System.EventHandler(this.serverpass_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(33, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Rcon pass - ";
            // 
            // layerpass
            // 
            this.layerpass.Location = new System.Drawing.Point(332, 118);
            this.layerpass.Name = "layerpass";
            this.layerpass.Size = new System.Drawing.Size(126, 20);
            this.layerpass.TabIndex = 20;
            // 
            // layerusername
            // 
            this.layerusername.Location = new System.Drawing.Point(332, 92);
            this.layerusername.Name = "layerusername";
            this.layerusername.Size = new System.Drawing.Size(126, 20);
            this.layerusername.TabIndex = 19;
            // 
            // serverip
            // 
            this.serverip.Location = new System.Drawing.Point(110, 42);
            this.serverip.Name = "serverip";
            this.serverip.Size = new System.Drawing.Size(126, 20);
            this.serverip.TabIndex = 18;
            // 
            // servername
            // 
            this.servername.Location = new System.Drawing.Point(110, 17);
            this.servername.Name = "servername";
            this.servername.Size = new System.Drawing.Size(126, 20);
            this.servername.TabIndex = 17;
            // 
            // initials
            // 
            this.initials.Location = new System.Drawing.Point(314, 70);
            this.initials.MaxLength = 4;
            this.initials.Name = "initials";
            this.initials.Size = new System.Drawing.Size(58, 20);
            this.initials.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(404, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "(Get it from Pavitra)";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Battlefield 3";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "bf3",
            "bf4"});
            this.comboBox1.Location = new System.Drawing.Point(314, 42);
            this.comboBox1.MaxDropDownItems = 2;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(103, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(242, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Initials =";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(242, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "game =";
            // 
            // Layerport
            // 
            this.Layerport.Location = new System.Drawing.Point(314, 18);
            this.Layerport.Maximum = new decimal(new int[] {
            65530,
            0,
            0,
            0});
            this.Layerport.Name = "Layerport";
            this.Layerport.Size = new System.Drawing.Size(84, 20);
            this.Layerport.TabIndex = 9;
            this.Layerport.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(242, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Layer port = ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(242, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Layer password = ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(242, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Layer username = ";
            // 
            // serverPort
            // 
            this.serverPort.Location = new System.Drawing.Point(110, 63);
            this.serverPort.Maximum = new decimal(new int[] {
            65530,
            0,
            0,
            0});
            this.serverPort.Name = "serverPort";
            this.serverPort.Size = new System.Drawing.Size(84, 20);
            this.serverPort.TabIndex = 9;
            this.serverPort.Value = new decimal(new int[] {
            47200,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "rcon port = ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Server ip = ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Server name = ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(484, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Process the info AND MAKE SURE YOU HAVE ENTERED CORRECT DETAILS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Authentication key : ";
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(156, 55);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(300, 20);
            this.key.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.command);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(19, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 94);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Custom Commands";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(484, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "SEND";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // command
            // 
            this.command.Location = new System.Drawing.Point(118, 23);
            this.command.Name = "command";
            this.command.Size = new System.Drawing.Size(300, 20);
            this.command.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "command :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Location = new System.Drawing.Point(19, 367);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(509, 100);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Start Default Layers";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Select the layer :";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(214, 24);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(284, 21);
            this.comboBox2.TabIndex = 23;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "START";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(252, 51);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(240, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "STOP";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 479);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.key);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vpsport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "WebAPI Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vpsport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Layerport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverPort)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown vpsport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.NumericUpDown serverPort;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown Layerport;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox initials;
        private System.Windows.Forms.TextBox serverip;
        private System.Windows.Forms.TextBox servername;
        private System.Windows.Forms.TextBox layerusername;
        private System.Windows.Forms.TextBox layerpass;
        private System.Windows.Forms.TextBox serverpass;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox command;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

