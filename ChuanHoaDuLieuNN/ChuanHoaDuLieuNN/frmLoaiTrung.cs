using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChuanHoaDuLieuNN
{
    public partial class frmLoaiTrung : Form
    {
        private String fileIn, fileOut;
        public frmLoaiTrung()
        {
            InitializeComponent();
        }

        private void btnSelectFiles_Click(object sender, EventArgs e)
        {
            Stream fileStream = null;
            selectFileDialog.Filter = "Text file (*.txt) | *.txt";
            if (selectFileDialog.ShowDialog() == DialogResult.OK && (fileStream = selectFileDialog.OpenFile()) != null)
            {
                fileIn = selectFileDialog.FileName;
                lblFileName.Text = Path.GetFileName(fileIn);
            }
            selectFileDialog.Dispose();
        }

        private void btnChonFileKQ_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text file (*.txt) | *.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileOut = openFileDialog1.FileName;
                lblFileResults.Text = Path.GetFileName(fileOut);
            }
        }

        private void btnChuanhoa_Click(object sender, EventArgs e)
        {
            int founds = 0;
            // 1. Đọc file, "bỏ qua các dòng trống"
            // Xử lý được TH: Có nhiều dòng trống, hoặc không có dòng trống giữa các cặp câu.
            List<String> lines = File.ReadAllLines(this.fileIn).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
            if (lines.Count() % 2 != 0)
            {
                lblKetQua.Text = "Số dòng lẻ! Vui lòng chuẩn hóa trước!";
                return;
            }
            bool[] checks = new bool[lines.Count];
            for (int i = 0; i < lines.Count; i++) checks[i] = true;
            for (int i = 0; i < lines.Count() - 1; i += 2)
            {
                if (checks[i] == false) continue;
                for (int j = i + 2; j < lines.Count() - 1; j += 2)
                {
                    if (lines[i].ToLower().Equals(lines[j].ToLower()) && lines[i + 1].ToLower().Equals(lines[j + 1].ToLower()))
                    {
                        founds++;
                        checks[j] = false;
                    }
                }
            }

            using (TextWriter tw = new StreamWriter(fileOut))
            {
                for (int i = 0; i < lines.Count() - 1; i += 2)
                {
                    if (checks[i] == true)
                    {
                        tw.WriteLine(lines[i]);
                        tw.WriteLine(lines[i + 1]);
                        tw.WriteLine("");
                    }
                }
            }
            lblKetQua.Text = "Đã xóa " + founds + " cặp câu trùng lặp!";
        }
    }
}
