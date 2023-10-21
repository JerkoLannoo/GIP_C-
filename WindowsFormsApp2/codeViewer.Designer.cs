namespace WindowsFormsApp2
{
    partial class codeViewer
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
            this.info = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.codelbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // info
            // 
            this.info.Dock = System.Windows.Forms.DockStyle.Top;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.Location = new System.Drawing.Point(0, 0);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(784, 73);
            this.info.TabIndex = 0;
            this.info.Text = "Wacht even...";
            this.info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(784, 285);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // codelbl
            // 
            this.codelbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.codelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codelbl.ForeColor = System.Drawing.Color.Blue;
            this.codelbl.Location = new System.Drawing.Point(0, 73);
            this.codelbl.Name = "codelbl";
            this.codelbl.Size = new System.Drawing.Size(784, 77);
            this.codelbl.TabIndex = 3;
            this.codelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.codelbl.TextChanged += new System.EventHandler(this.label1_TextChanged);
            // 
            // codeViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.codelbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.info);
            this.Name = "codeViewer";
            this.Text = "codeViewer";
            this.Load += new System.EventHandler(this.codeViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label info;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label codelbl;
    }
}