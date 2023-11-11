﻿namespace WindowsFormsApp2
{
    partial class gastInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.gebruikersnaam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duratief = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apparaten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wachtwoord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.showPswdBtn = new System.Windows.Forms.Button();
            this.filterChk = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataView
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gebruikersnaam,
            this.duratief,
            this.apparaten,
            this.wachtwoord});
            this.dataView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataView.Location = new System.Drawing.Point(0, 61);
            this.dataView.Name = "dataView";
            this.dataView.ReadOnly = true;
            this.dataView.Size = new System.Drawing.Size(784, 380);
            this.dataView.TabIndex = 0;
            // 
            // gebruikersnaam
            // 
            this.gebruikersnaam.Frozen = true;
            this.gebruikersnaam.HeaderText = "Gebruikersnaam";
            this.gebruikersnaam.Name = "gebruikersnaam";
            this.gebruikersnaam.ReadOnly = true;
            this.gebruikersnaam.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gebruikersnaam.Width = 200;
            // 
            // duratief
            // 
            this.duratief.Frozen = true;
            this.duratief.HeaderText = "Duratief";
            this.duratief.Name = "duratief";
            this.duratief.ReadOnly = true;
            this.duratief.Width = 200;
            // 
            // apparaten
            // 
            this.apparaten.Frozen = true;
            this.apparaten.HeaderText = "Aantal apparaten";
            this.apparaten.Name = "apparaten";
            this.apparaten.ReadOnly = true;
            this.apparaten.Width = 200;
            // 
            // wachtwoord
            // 
            this.wachtwoord.Frozen = true;
            this.wachtwoord.HeaderText = "Wachtwoord";
            this.wachtwoord.Name = "wachtwoord";
            this.wachtwoord.ReadOnly = true;
            this.wachtwoord.Width = 200;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.filterChk);
            this.panel1.Controls.Add(this.showPswdBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 55);
            this.panel1.TabIndex = 1;
            // 
            // showPswdBtn
            // 
            this.showPswdBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.showPswdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPswdBtn.Location = new System.Drawing.Point(515, 0);
            this.showPswdBtn.Name = "showPswdBtn";
            this.showPswdBtn.Size = new System.Drawing.Size(269, 55);
            this.showPswdBtn.TabIndex = 0;
            this.showPswdBtn.Text = "Wachtwoord van geselect. rij tonen";
            this.showPswdBtn.UseVisualStyleBackColor = true;
            this.showPswdBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // filterChk
            // 
            this.filterChk.AutoSize = true;
            this.filterChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterChk.Location = new System.Drawing.Point(353, 16);
            this.filterChk.Name = "filterChk";
            this.filterChk.Size = new System.Drawing.Size(156, 24);
            this.filterChk.TabIndex = 1;
            this.filterChk.Text = "Toon alleen geldig";
            this.filterChk.UseVisualStyleBackColor = true;
            this.filterChk.CheckedChanged += new System.EventHandler(this.filterChk_CheckedChanged);
            // 
            // gastInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataView);
            this.Name = "gastInfo";
            this.Text = "gastInfo";
            this.Load += new System.EventHandler(this.gastInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn gebruikersnaam;
        private System.Windows.Forms.DataGridViewTextBoxColumn duratief;
        private System.Windows.Forms.DataGridViewTextBoxColumn apparaten;
        private System.Windows.Forms.DataGridViewTextBoxColumn wachtwoord;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button showPswdBtn;
        private System.Windows.Forms.CheckBox filterChk;
    }
}