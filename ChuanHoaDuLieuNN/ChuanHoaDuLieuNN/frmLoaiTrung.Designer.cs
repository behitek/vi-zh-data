namespace ChuanHoaDuLieuNN
{
    partial class frmLoaiTrung
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.btnChuanhoa = new System.Windows.Forms.Button();
            this.lblFileResults = new System.Windows.Forms.Label();
            this.btnChonFileKQ = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnSelectFiles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.selectFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 28);
            this.label3.TabIndex = 84;
            this.label3.Text = "越南 - 华语正常化";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 13);
            this.label2.TabIndex = 85;
            this.label2.Text = "(C) 2019 Lớp Quản trị Thông tin K33";
            // 
            // lblKetQua
            // 
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblKetQua.Location = new System.Drawing.Point(154, 336);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(418, 23);
            this.lblKetQua.TabIndex = 83;
            this.lblKetQua.Text = "label2";
            this.lblKetQua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChuanhoa
            // 
            this.btnChuanhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuanhoa.Location = new System.Drawing.Point(296, 276);
            this.btnChuanhoa.Name = "btnChuanhoa";
            this.btnChuanhoa.Size = new System.Drawing.Size(137, 42);
            this.btnChuanhoa.TabIndex = 82;
            this.btnChuanhoa.Text = "Loại trùng lặp";
            this.btnChuanhoa.UseVisualStyleBackColor = true;
            this.btnChuanhoa.Click += new System.EventHandler(this.btnChuanhoa_Click);
            // 
            // lblFileResults
            // 
            this.lblFileResults.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileResults.Location = new System.Drawing.Point(237, 214);
            this.lblFileResults.Name = "lblFileResults";
            this.lblFileResults.Size = new System.Drawing.Size(399, 43);
            this.lblFileResults.TabIndex = 81;
            this.lblFileResults.Text = "Result File Name";
            // 
            // btnChonFileKQ
            // 
            this.btnChonFileKQ.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonFileKQ.Location = new System.Drawing.Point(98, 207);
            this.btnChonFileKQ.Name = "btnChonFileKQ";
            this.btnChonFileKQ.Size = new System.Drawing.Size(133, 31);
            this.btnChonFileKQ.TabIndex = 79;
            this.btnChonFileKQ.Text = "Chọn file kết quả";
            this.btnChonFileKQ.UseVisualStyleBackColor = true;
            this.btnChonFileKQ.Click += new System.EventHandler(this.btnChonFileKQ_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(237, 158);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(399, 43);
            this.lblFileName.TabIndex = 80;
            this.lblFileName.Text = "Source File Name";
            // 
            // btnSelectFiles
            // 
            this.btnSelectFiles.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFiles.Location = new System.Drawing.Point(98, 152);
            this.btnSelectFiles.Name = "btnSelectFiles";
            this.btnSelectFiles.Size = new System.Drawing.Size(133, 31);
            this.btnSelectFiles.TabIndex = 77;
            this.btnSelectFiles.Text = "Chọn file nguồn";
            this.btnSelectFiles.UseVisualStyleBackColor = true;
            this.btnSelectFiles.Click += new System.EventHandler(this.btnSelectFiles_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(134, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 73);
            this.label1.TabIndex = 78;
            this.label1.Text = "LOẠI TRÙNG LẶP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectFileDialog
            // 
            this.selectFileDialog.FileName = "openFileDialog1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmLoaiTrung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 410);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.btnChuanhoa);
            this.Controls.Add(this.lblFileResults);
            this.Controls.Add(this.btnChonFileKQ);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnSelectFiles);
            this.Controls.Add(this.label1);
            this.Name = "frmLoaiTrung";
            this.Text = "frmLoaiTrung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Button btnChuanhoa;
        private System.Windows.Forms.Label lblFileResults;
        private System.Windows.Forms.Button btnChonFileKQ;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnSelectFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog selectFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}