namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            BarraProgreso = new ProgressBar();
            Aceptar = new Button();
            BarraProceso2 = new ProgressBar();
            tiempo = new System.Windows.Forms.Timer(components);
            dateTimePicker1 = new DateTimePicker();
            Obtener = new Button();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            Multimedia = new LinkLabel();
            button1 = new Button();
            SuspendLayout();
            // 
            // BarraProgreso
            // 
            BarraProgreso.AccessibleRole = AccessibleRole.None;
            BarraProgreso.Location = new Point(53, 47);
            BarraProgreso.Name = "BarraProgreso";
            BarraProgreso.Size = new Size(601, 23);
            BarraProgreso.TabIndex = 0;
            // 
            // Aceptar
            // 
            Aceptar.Location = new Point(579, 76);
            Aceptar.Name = "Aceptar";
            Aceptar.Size = new Size(75, 23);
            Aceptar.TabIndex = 1;
            Aceptar.Text = "Aceptar";
            Aceptar.UseVisualStyleBackColor = true;
            Aceptar.Click += Aceptar_Click;
            // 
            // BarraProceso2
            // 
            BarraProceso2.AccessibleRole = AccessibleRole.None;
            BarraProceso2.BackColor = Color.FromArgb(64, 0, 64);
            BarraProceso2.ForeColor = Color.Fuchsia;
            BarraProceso2.Location = new Point(53, 105);
            BarraProceso2.Name = "BarraProceso2";
            BarraProceso2.Size = new Size(601, 21);
            BarraProceso2.Style = ProgressBarStyle.Continuous;
            BarraProceso2.TabIndex = 2;
            // 
            // tiempo
            // 
            tiempo.Tick += tiempo_Tick;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(53, 180);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(299, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // Obtener
            // 
            Obtener.Location = new Point(277, 242);
            Obtener.Name = "Obtener";
            Obtener.Size = new Size(75, 23);
            Obtener.TabIndex = 4;
            Obtener.Text = "Obtener";
            Obtener.UseVisualStyleBackColor = true;
            Obtener.Click += Obtener_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 242);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 7;
            label3.Text = "label3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 272);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 8;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 303);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 9;
            label2.Text = "label2";
            // 
            // Multimedia
            // 
            Multimedia.AutoSize = true;
            Multimedia.Location = new Point(55, 391);
            Multimedia.Name = "Multimedia";
            Multimedia.Size = new Size(68, 15);
            Multimedia.TabIndex = 10;
            Multimedia.TabStop = true;
            Multimedia.Text = "Multimedia";
            Multimedia.LinkClicked += Multimedia_LinkClicked;
            // 
            // button1
            // 
            button1.Location = new Point(277, 440);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 525);
            Controls.Add(button1);
            Controls.Add(Multimedia);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(Obtener);
            Controls.Add(dateTimePicker1);
            Controls.Add(BarraProceso2);
            Controls.Add(Aceptar);
            Controls.Add(BarraProgreso);
            Cursor = Cursors.PanNW;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar BarraProgreso;
        private Button Aceptar;
        private ProgressBar BarraProceso2;
        private System.Windows.Forms.Timer tiempo;
        private DateTimePicker dateTimePicker1;
        private Button Obtener;
        private Label label3;
        private Label label1;
        private Label label2;
        private LinkLabel Multimedia;
        private Button button1;
    }
}
