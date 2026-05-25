using System.Diagnostics;
using System.Reflection.Emit;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            if (BarraProgreso.Value < BarraProgreso.Maximum)
            {
                BarraProgreso.Value += 10;
            }
            else
            {
                MessageBox.Show("Actualizado");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tiempo.Interval = 1000; // 1 segundo
            tiempo.Start();
        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
            if (BarraProceso2.Value + 10 <= BarraProceso2.Maximum)
            {
                BarraProceso2.Value += 10;
            }
            else
            {
                tiempo.Stop();
                MessageBox.Show("Actualizado");
            }
        }

        private void Obtener_Click(object sender, EventArgs e)
        {
            label3.Text = dateTimePicker1.Value.ToString();
            label1.Text = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            label2.Text = dateTimePicker1.Value.ToString("HH:mm:ss");
        }

        private void Multimedia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Multimedia.LinkVisited = true;
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://learn.microsoft.com/es-es/dotnet/desktop/wpf/graphics-multimedia/",
                UseShellExecute = true
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2= new Form2();
            form2.Show();
        }
    }
}
