namespace YoutubeDownloader
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
            label1 = new Label();
            txtLink = new TextBox();
            btnDownload = new Button();
            opciones = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(98, 31);
            label1.Name = "label1";
            label1.Size = new Size(226, 35);
            label1.TabIndex = 0;
            label1.Text = "Descargar Youtube";
            // 
            // txtLink
            // 
            txtLink.Location = new Point(63, 78);
            txtLink.Name = "txtLink";
            txtLink.Size = new Size(431, 27);
            txtLink.TabIndex = 1;
            txtLink.TextChanged += txtLink_TextChanged;
            // 
            // btnDownload
            // 
            btnDownload.Enabled = false;
            btnDownload.Location = new Point(230, 124);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(94, 29);
            btnDownload.TabIndex = 2;
            btnDownload.Text = "Descargar";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // opciones
            // 
            opciones.DropDownStyle = ComboBoxStyle.DropDownList;
            opciones.FormattingEnabled = true;
            opciones.Items.AddRange(new object[] { "Audio", "Video", "Playlist" });
            opciones.Location = new Point(339, 37);
            opciones.Name = "opciones";
            opciones.Size = new Size(151, 28);
            opciones.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 187);
            Controls.Add(opciones);
            Controls.Add(btnDownload);
            Controls.Add(txtLink);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLink;
        private Button btnDownload;
        private ComboBox opciones;
    }
}
