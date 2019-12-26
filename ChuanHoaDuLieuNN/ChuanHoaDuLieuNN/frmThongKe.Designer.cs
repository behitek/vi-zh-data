namespace ChuanHoaDuLieuNN
{
    partial class frmThongKe
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnSelectFiles = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.btnDemCapCau = new System.Windows.Forms.Button();
            this.btnDemSoTu = new System.Windows.Forms.Button();
            this.btnChieuDaiTB = new System.Windows.Forms.Button();
            this.selectFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(291, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 28);
            this.label3.TabIndex = 78;
            this.label3.Text = "越南 - 华语正常化";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(170, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 73);
            this.label1.TabIndex = 77;
            this.label1.Text = "THỐNG KÊ DỮ LIỆU NGÔN NGỮ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFileName
            // 
            this.lblFileName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(257, 175);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(399, 43);
            this.lblFileName.TabIndex = 80;
            this.lblFileName.Text = "Source File Name";
            // 
            // btnSelectFiles
            // 
            this.btnSelectFiles.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFiles.Location = new System.Drawing.Point(118, 169);
            this.btnSelectFiles.Name = "btnSelectFiles";
            this.btnSelectFiles.Size = new System.Drawing.Size(133, 31);
            this.btnSelectFiles.TabIndex = 79;
            this.btnSelectFiles.Text = "Chọn file nguồn";
            this.btnSelectFiles.UseVisualStyleBackColor = true;
            this.btnSelectFiles.Click += new System.EventHandler(this.btnSelectFiles_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblKetQua.Location = new System.Drawing.Point(197, 344);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(418, 23);
            this.lblKetQua.TabIndex = 81;
            this.lblKetQua.Text = "label2";
            this.lblKetQua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDemCapCau
            // 
            this.btnDemCapCau.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemCapCau.Location = new System.Drawing.Point(62, 261);
            this.btnDemCapCau.Name = "btnDemCapCau";
            this.btnDemCapCau.Size = new System.Drawing.Size(133, 31);
            this.btnDemCapCau.TabIndex = 79;
            this.btnDemCapCau.Text = "Đếm số cặp câu";
            this.btnDemCapCau.UseVisualStyleBackColor = true;
            this.btnDemCapCau.Click += new System.EventHandler(this.btnDemCapCau_Click);
            // 
            // btnDemSoTu
            // 
            this.btnDemSoTu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemSoTu.Location = new System.Drawing.Point(261, 261);
            this.btnDemSoTu.Name = "btnDemSoTu";
            this.btnDemSoTu.Size = new System.Drawing.Size(133, 31);
            this.btnDemSoTu.TabIndex = 79;
            this.btnDemSoTu.Text = "Đếm số từ";
            this.btnDemSoTu.UseVisualStyleBackColor = true;
            this.btnDemSoTu.Click += new System.EventHandler(this.btnDemSoTu_Click);
            // 
            // btnChieuDaiTB
            // 
            this.btnChieuDaiTB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChieuDaiTB.Location = new System.Drawing.Point(442, 261);
            this.btnChieuDaiTB.Name = "btnChieuDaiTB";
            this.btnChieuDaiTB.Size = new System.Drawing.Size(286, 31);
            this.btnChieuDaiTB.TabIndex = 79;
            this.btnChieuDaiTB.Text = "Tính chiều dài trung bình câu";
            this.btnChieuDaiTB.UseVisualStyleBackColor = true;
            this.btnChieuDaiTB.Click += new System.EventHandler(this.btnChieuDaiTB_Click);
            // 
            // selectFileDialog
            // 
            this.selectFileDialog.FileName = "openFileDialog1";
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 423);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnChieuDaiTB);
            this.Controls.Add(this.btnDemSoTu);
            this.Controls.Add(this.btnDemCapCau);
            this.Controls.Add(this.btnSelectFiles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnSelectFiles;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Button btnDemCapCau;
        private System.Windows.Forms.Button btnDemSoTu;
        private System.Windows.Forms.Button btnChieuDaiTB;
        private System.Windows.Forms.OpenFileDialog selectFileDialog;
    }
}