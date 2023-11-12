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
            this.nonActiveDevicesLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.showDeviceInfo = new System.Windows.Forms.Button();
            this.addDeviceBtn = new System.Windows.Forms.Button();
            this.activeDevicesLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gDevicesPnl = new System.Windows.Forms.Panel();
            this.nonActiveGDevicesLbl = new System.Windows.Forms.Label();
            this.showGDeviceInfo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
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
            this.devicesPnl.Controls.Add(this.nonActiveDevicesLbl);
            this.devicesPnl.Controls.Add(this.label3);
            this.devicesPnl.Controls.Add(this.showDeviceInfo);
            this.devicesPnl.Controls.Add(this.addDeviceBtn);
            this.devicesPnl.Controls.Add(this.activeDevicesLbl);
            this.devicesPnl.Controls.Add(this.label2);
            this.devicesPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.devicesPnl.Location = new System.Drawing.Point(0, 52);
            this.devicesPnl.Name = "devicesPnl";
            this.devicesPnl.Size = new System.Drawing.Size(784, 95);
            this.devicesPnl.TabIndex = 1;
            // 
            // nonActiveDevicesLbl
            // 
            this.nonActiveDevicesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nonActiveDevicesLbl.Location = new System.Drawing.Point(228, 43);
            this.nonActiveDevicesLbl.Name = "nonActiveDevicesLbl";
            this.nonActiveDevicesLbl.Size = new System.Drawing.Size(76, 50);
            this.nonActiveDevicesLbl.TabIndex = 5;
            this.nonActiveDevicesLbl.Text = "laden...";
            this.nonActiveDevicesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-5, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 50);
            this.label3.TabIndex = 4;
            this.label3.Text = "Niet-geactiveerde apparaten";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showDeviceInfo
            // 
            this.showDeviceInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.showDeviceInfo.Enabled = false;
            this.showDeviceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDeviceInfo.Location = new System.Drawing.Point(310, 0);
            this.showDeviceInfo.Name = "showDeviceInfo";
            this.showDeviceInfo.Size = new System.Drawing.Size(237, 95);
            this.showDeviceInfo.TabIndex = 3;
            this.showDeviceInfo.Text = "apparaat info";
            this.showDeviceInfo.UseVisualStyleBackColor = true;
            this.showDeviceInfo.Click += new System.EventHandler(this.showDeviceInfo_Click);
            // 
            // addDeviceBtn
            // 
            this.addDeviceBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.addDeviceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDeviceBtn.Location = new System.Drawing.Point(547, 0);
            this.addDeviceBtn.Name = "addDeviceBtn";
            this.addDeviceBtn.Size = new System.Drawing.Size(237, 95);
            this.addDeviceBtn.TabIndex = 2;
            this.addDeviceBtn.Text = "apparaat tevoegen";
            this.addDeviceBtn.UseVisualStyleBackColor = true;
            this.addDeviceBtn.Click += new System.EventHandler(this.addDeviceBtn_Click);
            // 
            // activeDevicesLbl
            // 
            this.activeDevicesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeDevicesLbl.Location = new System.Drawing.Point(189, 0);
            this.activeDevicesLbl.Name = "activeDevicesLbl";
            this.activeDevicesLbl.Size = new System.Drawing.Size(100, 50);
            this.activeDevicesLbl.TabIndex = 1;
            this.activeDevicesLbl.Text = "laden...";
            this.activeDevicesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
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
            this.gDevicesPnl.Controls.Add(this.nonActiveGDevicesLbl);
            this.gDevicesPnl.Controls.Add(this.showGDeviceInfo);
            this.gDevicesPnl.Controls.Add(this.label5);
            this.gDevicesPnl.Controls.Add(this.addGDeviceBtn);
            this.gDevicesPnl.Controls.Add(this.activeGdevicesLbl);
            this.gDevicesPnl.Controls.Add(this.label4);
            this.gDevicesPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.gDevicesPnl.Location = new System.Drawing.Point(0, 147);
            this.gDevicesPnl.Name = "gDevicesPnl";
            this.gDevicesPnl.Size = new System.Drawing.Size(784, 90);
            this.gDevicesPnl.TabIndex = 2;
            // 
            // nonActiveGDevicesLbl
            // 
            this.nonActiveGDevicesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nonActiveGDevicesLbl.Location = new System.Drawing.Point(261, 41);
            this.nonActiveGDevicesLbl.Name = "nonActiveGDevicesLbl";
            this.nonActiveGDevicesLbl.Size = new System.Drawing.Size(100, 50);
            this.nonActiveGDevicesLbl.TabIndex = 5;
            this.nonActiveGDevicesLbl.Text = "laden...";
            this.nonActiveGDevicesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showGDeviceInfo
            // 
            this.showGDeviceInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.showGDeviceInfo.Enabled = false;
            this.showGDeviceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showGDeviceInfo.Location = new System.Drawing.Point(400, 0);
            this.showGDeviceInfo.Name = "showGDeviceInfo";
            this.showGDeviceInfo.Size = new System.Drawing.Size(180, 90);
            this.showGDeviceInfo.TabIndex = 4;
            this.showGDeviceInfo.Text = "gast apparaat info";
            this.showGDeviceInfo.UseVisualStyleBackColor = true;
            this.showGDeviceInfo.Click += new System.EventHandler(this.showGDeviceInfo_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 50);
            this.label5.TabIndex = 5;
            this.label5.Text = "Niet-geactiveerde gast apparaten";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addGDeviceBtn
            // 
            this.addGDeviceBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.addGDeviceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGDeviceBtn.Location = new System.Drawing.Point(580, 0);
            this.addGDeviceBtn.Name = "addGDeviceBtn";
            this.addGDeviceBtn.Size = new System.Drawing.Size(204, 90);
            this.addGDeviceBtn.TabIndex = 3;
            this.addGDeviceBtn.Text = "gast apparaat tevoegen";
            this.addGDeviceBtn.UseVisualStyleBackColor = true;
            this.addGDeviceBtn.Click += new System.EventHandler(this.addGDeviceBtn_Click);
            // 
            // activeGdevicesLbl
            // 
            this.activeGdevicesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeGdevicesLbl.Location = new System.Drawing.Point(240, 0);
            this.activeGdevicesLbl.Name = "activeGdevicesLbl";
            this.activeGdevicesLbl.Size = new System.Drawing.Size(82, 50);
            this.activeGdevicesLbl.TabIndex = 1;
            this.activeGdevicesLbl.Text = "laden...";
            this.activeGdevicesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
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
        private System.Windows.Forms.Label activeDevicesLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel gDevicesPnl;
        private System.Windows.Forms.Label activeGdevicesLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addDeviceBtn;
        private System.Windows.Forms.Button addGDeviceBtn;
        private System.Windows.Forms.Button showDeviceInfo;
        private System.Windows.Forms.Button showGDeviceInfo;
        private System.Windows.Forms.Label nonActiveDevicesLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label nonActiveGDevicesLbl;
    }
}