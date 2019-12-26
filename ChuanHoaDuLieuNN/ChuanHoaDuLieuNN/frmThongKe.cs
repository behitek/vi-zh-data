using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ChuanHoaDuLieuNN
{
    public partial class frmThongKe : Form
    {
        private String fileIn;
        public frmThongKe()
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

        private void btnDemCapCau_Click(object sender, EventArgs e)
        {
            List<String> lines = File.ReadAllLines(this.fileIn).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
            if (lines.Count % 2 != 0)
            {
                lblKetQua.Text = "Số câu lẻ, hãy chuẩn hóa trước!";
            }
            else
                lblKetQua.Text = lines.Count / 2 + " cặp câu!";
        }

        private void btnDemSoTu_Click(object sender, EventArgs e)
        {
            List<String> lines = File.ReadAllLines(this.fileIn).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
            int viWords = 0, zhWords = 0;
            foreach (String s in lines)
            {
                if (isVietNamSent(s))
                {
                    viWords += Regex.Matches(s, @"\p{L}+").Count;
                }
                else {
                    zhWords += Regex.Matches(s, @"\p{L}+").Count;
                }
            }
            lblKetQua.Text = "Có " + viWords + " từ tiếng Việt và " + zhWords + " từ tiếng Hoa.";
        }

        private bool isVietNamSent(String sent)
        {
            return Regex.IsMatch(sent, "[a-zA-Z]");
        }

        private void btnChieuDaiTB_Click(object sender, EventArgs e)
        {
            List<String> lines = File.ReadAllLines(this.fileIn).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
            int viWords = 0, zhWords = 0;
            int viLines = 0, zhLines = 0;
            foreach (String s in lines)
            {
                if (isVietNamSent(s))
                {
                    viWords += s.Count() - 3;
                    viLines++;
                }
                else
                {
                    zhWords += s.Count() - 3;
                    zhLines++;
                }
            }
            lblKetQua.Text = "Chiều dài TB câu của tiếng Việt: " + (float)viWords/viLines + ", tiếng Hoa: " + (float)zhWords/zhLines + " ký tự.";
        }
    }
}
