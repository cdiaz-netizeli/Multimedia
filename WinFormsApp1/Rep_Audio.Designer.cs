namespace WinFormsApp1
{
    partial class Rep_Audio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rep_Audio));
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            Cargar = new Button();
            play = new Button();
            pausar = new Button();
            Detener = new Button();
            openFileDialog1 = new OpenFileDialog();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(3, 6);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(288, 264);
            axWindowsMediaPlayer1.TabIndex = 0;
            axWindowsMediaPlayer1.PlayStateChange += axWindowsMediaPlayer1_PlayStateChange;
            axWindowsMediaPlayer1.Enter += axWindowsMediaPlayer1_Enter;
            // 
            // Cargar
            // 
            Cargar.Location = new Point(1, 276);
            Cargar.Name = "Cargar";
            Cargar.Size = new Size(57, 23);
            Cargar.TabIndex = 1;
            Cargar.Text = "Cargar";
            Cargar.UseVisualStyleBackColor = true;
            Cargar.Click += button1_Click;
            // 
            // play
            // 
            play.Location = new Point(64, 276);
            play.Name = "play";
            play.Size = new Size(57, 23);
            play.TabIndex = 2;
            play.Text = "play";
            play.UseVisualStyleBackColor = true;
            play.Click += play_Click;
            // 
            // pausar
            // 
            pausar.Location = new Point(127, 276);
            pausar.Name = "pausar";
            pausar.Size = new Size(57, 23);
            pausar.TabIndex = 3;
            pausar.Text = "pause";
            pausar.UseVisualStyleBackColor = true;
            pausar.Click += pausar_Click;
            // 
            // Detener
            // 
            Detener.Location = new Point(190, 276);
            Detener.Name = "Detener";
            Detener.Size = new Size(42, 23);
            Detener.TabIndex = 4;
            Detener.Text = "Stop";
            Detener.UseVisualStyleBackColor = true;
            Detener.Click += Detener_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            button1.Location = new Point(238, 276);
            button1.Name = "button1";
            button1.Size = new Size(22, 23);
            button1.TabIndex = 5;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(266, 276);
            button2.Name = "button2";
            button2.Size = new Size(25, 23);
            button2.TabIndex = 6;
            button2.Text = ">";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 7;
            // 
            // Rep_Audio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 305);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Detener);
            Controls.Add(pausar);
            Controls.Add(play);
            Controls.Add(Cargar);
            Controls.Add(axWindowsMediaPlayer1);
            Name = "Rep_Audio";
            Text = "Rep_Audio";
            Load += Rep_Audio_Load;
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Button Cargar;
        private Button play;
        private Button pausar;
        private Button Detener;
        private OpenFileDialog openFileDialog1;
        private Button button1;
        private Button button2;
        private Label label1;
    }
}