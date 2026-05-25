namespace WinFormsApp1
{
    partial class Form2
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
            button1 = new Button();
            atras = new Button();
            txtURL = new TextBox();
            Home = new Button();
            ir = new Button();
            Stop = new Button();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(84, 31);
            button1.Name = "button1";
            button1.Size = new Size(53, 23);
            button1.TabIndex = 0;
            button1.Text = ">";
            button1.UseVisualStyleBackColor = true;
            // 
            // atras
            // 
            atras.Location = new Point(25, 31);
            atras.Name = "atras";
            atras.Size = new Size(53, 23);
            atras.TabIndex = 1;
            atras.Text = "<";
            atras.UseVisualStyleBackColor = true;
            atras.Click += atras_Click;
            // 
            // txtURL
            // 
            txtURL.Location = new Point(381, 31);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(360, 23);
            txtURL.TabIndex = 2;
            // 
            // Home
            // 
            Home.Location = new Point(166, 32);
            Home.Name = "Home";
            Home.Size = new Size(91, 23);
            Home.TabIndex = 5;
            Home.Text = "Home";
            Home.UseVisualStyleBackColor = true;
            // 
            // ir
            // 
            ir.Location = new Point(747, 32);
            ir.Name = "ir";
            ir.Size = new Size(53, 23);
            ir.TabIndex = 6;
            ir.Text = "ir";
            ir.UseVisualStyleBackColor = true;
            ir.Click += ir_Click;
            // 
            // Stop
            // 
            Stop.Location = new Point(285, 32);
            Stop.Name = "Stop";
            Stop.Size = new Size(75, 23);
            Stop.TabIndex = 7;
            Stop.Text = "Stop";
            Stop.UseVisualStyleBackColor = true;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(12, 78);
            webView21.Name = "webView21";
            webView21.Size = new Size(776, 467);
            webView21.TabIndex = 8;
            webView21.ZoomFactor = 1D;
            webView21.Click += webView21_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 557);
            Controls.Add(webView21);
            Controls.Add(Stop);
            Controls.Add(ir);
            Controls.Add(Home);
            Controls.Add(txtURL);
            Controls.Add(atras);
            Controls.Add(button1);
            Name = "Form2";
            Text = "form2";
            Load += adelante_Load;
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button atras;
        private TextBox txtURL;
        private Button Home;
        private Button ir;
        private Button Stop;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}