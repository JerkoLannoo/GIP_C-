namespace WindowsFormsApp2
{
    partial class dashboard
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
            this.kredietPnl = new System.Windows.Forms.Panel();
            this.kredietLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.devicesPnl = new System.Windows.Forms.Panel();
            this.showDeviceInfo = new System.Windows.Forms.Button();
            this.addDeviceBtn = new System.Windows.Forms.Button();
            this.activeDevices = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gDevicesPnl = new System.Windows.Forms.Panel();
            this.showGDeviceInfo = new System.Windows.Forms.Button();
            this.addGDeviceBtn = new System.Windows.Forms.Button();
            this.activeGdevicesLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kredietPnl.SuspendLayout();
            this.devicesPnl.SuspendLayout();
            this.gDevicesPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // kredietPnl
            // 
            this.kredietPnl.Controls.Add(this.kredietLbl);
            this.kredietPnl.Controls.Add(this.label1);
            this.kredietPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.kredietPnl.Location = new System.Drawing.Point(0, 0);
            this.kredietPnl.Name = "kredietPnl";
            this.kredietPnl.Size = new System.Drawing.Size(784, 52);
            this.kredietPnl.TabIndex = 0;
            // 
            // kredietLbl
            // 
            this.kredietLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.kredietLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kredietLbl.Location = new System.Drawing.Point(67, 0);
            this.kredietLbl.Name = "kredietLbl";
            this.kredietLbl.Size = new System.Drawing.Size(66, 52);
            this.kredietLbl.TabIndex = 1;
            this.kredietLbl.Text = "laden...";
            this.kredietLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Krediet:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // devicesPnl
            // 
            this.devicesPnl.Controls.Add(this.showDeviceInfo);
            this.devicesPnl.Controls.Add(this.addDeviceBtn);
            this.devicesPnl.Controls.Add(this.activeDevices);
            this.devicesPnl.Controls.Add(this.label2);
            this.devicesPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.devicesPnl.Location = new System.Drawing.Point(0, 52);
            this.devicesPnl.Name = "devicesPnl";
            this.devicesPnl.Size = new System.Drawing.Size(784, 50);
            this.devicesPnl.TabIndex = 1;
            // 
            // showDeviceInfo
            // 
            this.showDeviceInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.showDeviceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDeviceInfo.Location = new System.Drawing.Point(310, 0);
            this.showDeviceInfo.Name = "showDeviceInfo";
            this.showDeviceInfo.Size = new System.Drawing.Size(237, 50);
            this.showDeviceInfo.TabIndex = 3;
            this.showDeviceInfo.Text = "apparaat info";
            this.showDeviceInfo.UseVisualStyleBackColor = true;
            this.showDeviceInfo.Click += new System.EventHandler(this.showDeviceInfo_Click);
            // 
            // addDeviceBtn
            // 
            this.addDeviceBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.addDeviceBtn.Enabled = false;
            this.addDeviceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDeviceBtn.Location = new System.Drawing.Point(547, 0);
            this.addDeviceBtn.Name = "addDeviceBtn";
            this.addDeviceBtn.Size = new System.Drawing.Size(237, 50);
            this.addDeviceBtn.TabIndex = 2;
            this.addDeviceBtn.Text = "apparaat tevoegen";
            this.addDeviceBtn.UseVisualStyleBackColor = true;
            this.addDeviceBtn.Click += new System.EventHandler(this.addDeviceBtn_Click);
            // 
            // activeDevices
            // 
            this.activeDevices.Dock = System.Windows.Forms.DockStyle.Left;
            this.activeDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeDevices.Location = new System.Drawing.Point(189, 0);
            this.activeDevices.Name = "activeDevices";
            this.activeDevices.Size = new System.Drawing.Size(100, 50);
            this.activeDevices.TabIndex = 1;
            this.activeDevices.Text = "laden...";
            this.activeDevices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "Geactiveerde apparaten:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gDevicesPnl
            // 
            this.gDevicesPnl.Controls.Add(this.showGDeviceInfo);
            this.gDevicesPnl.Controls.Add(this.addGDeviceBtn);
            this.gDevicesPnl.Controls.Add(this.activeGdevicesLbl);
            this.gDevicesPnl.Controls.Add(this.label4);
            this.gDevicesPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.gDevicesPnl.Location = new System.Drawing.Point(0, 102);
            this.gDevicesPnl.Name = "gDevicesPnl";
            this.gDevicesPnl.Size = new System.Drawing.Size(784, 50);
            this.gDevicesPnl.TabIndex = 2;
            // 
            // showGDeviceInfo
            // 
            this.showGDeviceInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.showGDeviceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showGDeviceInfo.Location = new System.Drawing.Point(310, 0);
            this.showGDeviceInfo.Name = "showGDeviceInfo";
            this.showGDeviceInfo.Size = new System.Drawing.Size(237, 50);
            this.showGDeviceInfo.TabIndex = 4;
            this.showGDeviceInfo.Text = "gast apparaat info";
            this.showGDeviceInfo.UseVisualStyleBackColor = true;
            this.showGDeviceInfo.Click += new System.EventHandler(this.showGDeviceInfo_Click);
            // 
            // addGDeviceBtn
            // 
            this.addGDeviceBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.addGDeviceBtn.Enabled = false;
            this.addGDeviceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGDeviceBtn.Location = new System.Drawing.Point(547, 0);
            this.addGDeviceBtn.Name = "addGDeviceBtn";
            this.addGDeviceBtn.Size = new System.Drawing.Size(237, 50);
            this.addGDeviceBtn.TabIndex = 3;
            this.addGDeviceBtn.Text = "gast apparaat tevoegen";
            this.addGDeviceBtn.UseVisualStyleBackColor = true;
            // 
            // activeGdevicesLbl
            // 
            this.activeGdevicesLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.activeGdevicesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeGdevicesLbl.Location = new System.Drawing.Point(222, 0);
            this.activeGdevicesLbl.Name = "activeGdevicesLbl";
            this.activeGdevicesLbl.Size = new System.Drawing.Size(100, 50);
            this.activeGdevicesLbl.TabIndex = 1;
            this.activeGdevicesLbl.Text = "laden...";
            this.activeGdevicesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 50);
            this.label4.TabIndex = 0;
            this.label4.Text = "Geactiveerde gast apparaten:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.gDevicesPnl);
            this.Controls.Add(this.devicesPnl);
            this.Controls.Add(this.kredietPnl);
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.kredietPnl.ResumeLayout(false);
            this.devicesPnl.ResumeLayout(false);
            this.gDevicesPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel kredietPnl;
        private System.Windows.Forms.Label kredietLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel devicesPnl;
        private System.Windows.Forms.Label activeDevices;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel gDevicesPnl;
        private System.Windows.Forms.Label activeGdevicesLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addDeviceBtn;
        private System.Windows.Forms.Button addGDeviceBtn;
        private System.Windows.Forms.Button showDeviceInfo;
        private System.Windows.Forms.Button showGDeviceInfo;
    }
}