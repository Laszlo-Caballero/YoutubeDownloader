namespace YoutubeDownloader.ModalDownload
{
    partial class Modal
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
            progreso = new ProgressBar();
            btnClose = new Button();
            txtDownload = new Label();
            SuspendLayout();
            // 
            // progreso
            // 
            progreso.Location = new Point(34, 62);
            progreso.Name = "progreso";
            progreso.Size = new Size(479, 29);
            progreso.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Enabled = false;
            btnClose.Location = new Point(207, 119);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(126, 38);
            btnClose.TabIndex = 1;
            btnClose.Text = "Aceptar";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtDownload
            // 
            txtDownload.AutoSize = true;
            txtDownload.Font = new Font("Segoe UI", 15F);
            txtDownload.Location = new Point(150, 9);
            txtDownload.Name = "txtDownload";
            txtDownload.Size = new Size(233, 35);
            txtDownload.TabIndex = 2;
            txtDownload.Text = "Descarga Completa";
            txtDownload.Visible = false;
            // 
            // Modal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 194);
            Controls.Add(txtDownload);
            Controls.Add(btnClose);
            Controls.Add(progreso);
            Name = "Modal";
            Text = "Modal";
            Load += Modal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progreso;
        private Button btnClose;
        private Label txtDownload;
    }
}