using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void adelante_Load(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.youtube.com");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void ir_Click(object sender, EventArgs e)
        {

            webView21.Source = new Uri(txtURL.Text);
        }

        private void atras_Click(object sender, EventArgs e)
        {
            webView21.GoBack();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webView21.GoForward();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            webView21.Stop();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.google.com/?hl=es");

        }
    }
}
