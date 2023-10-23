namespace WindowsFormsApp2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.info = new System.Windows.Forms.Label();
            this.loading_icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loading_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(582, 337);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.White;
            this.info.Dock = System.Windows.Forms.DockStyle.Top;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.info.Location = new System.Drawing.Point(0, 0);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(800, 156);
            this.info.TabIndex = 0;
            this.info.Text = "Scan je leerlingenkaart.";
            this.info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // loading_icon
            // 
            this.loading_icon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loading_icon.Image = global::WindowsFormsApp2.Properties.Resources.spinning_loading;
            this.loading_icon.InitialImage = global::WindowsFormsApp2.Properties.Resources.spinning_loading;
            this.loading_icon.Location = new System.Drawing.Point(0, 120);
            this.loading_icon.Name = "loading_icon";
            this.loading_icon.Size = new System.Drawing.Size(800, 360);
            this.loading_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loading_icon.TabIndex = 4;
            this.loading_icon.TabStop = false;
            this.loading_icon.Click += new System.EventHandler(this.loading_icon_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.loading_icon);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.focusOpTextbox);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkEnter);
            ((System.ComponentModel.ISupportInitialize)(this.loading_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.PictureBox loading_icon;
    }
}

