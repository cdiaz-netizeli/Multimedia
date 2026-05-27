using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
using WMPLib;

namespace WinFormsApp1
{
    public partial class Rep_Audio : Form
    {
        // private string ruta;
        private IWMPPlaylist playlist;
        private string[] archivosMultimedia;
        public Rep_Audio()
        {
            // ruta = "";

            InitializeComponent();
        }
        private void Rep_Audio_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.uiMode = "mini";

            //
            axWindowsMediaPlayer1.settings.autoStart = true;

            //se repite automaticamente
            axWindowsMediaPlayer1.settings.setMode("loop", true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog carpeta = new FolderBrowserDialog();

            if (carpeta.ShowDialog() == DialogResult.OK)
            {
                // Buscar archivos compatibles
                archivosMultimedia = Directory
                    .GetFiles(carpeta.SelectedPath)
                    .Where(x =>
                        x.EndsWith(".mp3") ||
                        x.EndsWith(".mp4") ||
                        x.EndsWith(".wav") ||
                        x.EndsWith(".avi") ||
                        x.EndsWith(".wmv"))
                    .ToArray();

                // Verificar si hay archivos
                if (archivosMultimedia.Length == 0)
                {
                    MessageBox.Show(
                        "No se encontraron archivos multimedia");
                    return;
                }
                // Limpiar ListBox
                listBox1.Items.Clear();

                // Crear playlist
                playlist = axWindowsMediaPlayer1
                    .playlistCollection
                    .newPlaylist("Mi Playlist");

                // Agregar archivos
                foreach (string archivo in archivosMultimedia)
                {
                    playlist.appendItem(
                        axWindowsMediaPlayer1.newMedia(archivo));


                    listBox1.Items.Add( Path.GetFileName(archivo));
                }

                // Asignar playlist
                axWindowsMediaPlayer1.currentPlaylist = playlist;


                axWindowsMediaPlayer1.Ctlcontrols.play();

                // Mostrar nombre
                MostrarNombre();
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }



        private void play_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void pausar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void Detener_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.previous();
            ActualizarSeleccion();

            MostrarNombre();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.next();
            ActualizarSeleccion();

            MostrarNombre();
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            MostrarNombre();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             
            if (listBox1.SelectedIndex >= 0)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();

                axWindowsMediaPlayer1.URL =
                    archivosMultimedia[listBox1.SelectedIndex];

                axWindowsMediaPlayer1.Ctlcontrols.play();

                MostrarNombre();
            }
        

        }

       
        // MOSTRAR NOMBRE
        private void MostrarNombre()
        {
            if (axWindowsMediaPlayer1.currentMedia != null)
            {
                label1.Text =
                    axWindowsMediaPlayer1.currentMedia.name;
            }
        }

        // ACTUALIZAR LISTBOX
        private void ActualizarSeleccion()
        {
            if (axWindowsMediaPlayer1.currentMedia != null)
            {
                string nombreActual =
                    axWindowsMediaPlayer1.currentMedia.name;

                for (int i = 0;
                    i < listBox1.Items.Count;
                    i++)
                {
                    if (listBox1.Items[i].ToString().Contains(nombreActual))
                    {
                        listBox1.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

    }
}
