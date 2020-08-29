using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Webnet_Official_Web_Server_v0._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Process.Start("cmd", "/C cd php && call php -S localhost:80");
            ProcessStartInfo sphp = new ProcessStartInfo("cmd", "/C cd php && call php -S localhost:80");
            sphp.UseShellExecute = false;
            sphp.CreateNoWindow = true;
            Process.Start(sphp);

            ProcessStartInfo smysql = new ProcessStartInfo("cmd", "/C cd php\\mysql\\bin && call mysqld");
            smysql.UseShellExecute = false;
            smysql.CreateNoWindow = true;
            Process.Start(smysql);

            Status_Label.Text = "ON";
            Status_Label.ForeColor = Color.Green;
            Status_Label.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ophp = new ProcessStartInfo("cmd", "/C taskkill /im php.exe /f /t");
            ophp.UseShellExecute = false;
            ophp.CreateNoWindow = true;
            Process.Start(ophp);

            ProcessStartInfo omysql = new ProcessStartInfo("cmd", "/C taskkill /im mysqld.exe /f /t");
            omysql.UseShellExecute = false;
            omysql.CreateNoWindow = true;
            Process.Start(omysql);

            Status_Label.Text = "OFF";
            Status_Label.ForeColor = Color.Red;
            Status_Label.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://web-net.ml/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("php\\www");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("http://localhost/www/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("http://localhost/phpmyadmin/");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Webnet Official Mysql & Php Web Server v0.2\nA Product Of Webnet Official By:\nMEGAMIND (M Raahim Khattak)\nKHATTAKS (M Daniyal Khattak)\nKasper", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
