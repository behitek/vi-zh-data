using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;
using System.IO;

namespace ChuanHoaDuLieuNN
{
    public partial class frmChuanHoa : Form
    {
        private String fileIn, fileOut;
        public frmChuanHoa()
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
            ChuanHoa();
        }

        private void ChuanHoa()
        {
            // 1. Đọc file, "bỏ qua các dòng trống"
            // Xử lý được TH: Có nhiều dòng trống, hoặc không có dòng trống giữa các cặp câu.
            List<String> lines = File.ReadAllLines(this.fileIn).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
            List<String> pairLines = new List<String>();
            String vi, zh, temp;
            // 2. // Duyệt từng cặp câu (lines[i], lines[i+1])
            for (int i = 0; i < lines.Count - 1; i += 2)
            {
                vi = lines[i];
                zh = lines[i + 1];
                // Thứ tự cặp câu bị đảo lộn, đổi lại
                if (!isVietNamSent(vi) && isVietNamSent(zh) && vi.StartsWith("*") && zh.StartsWith("+"))
                {
                    temp = "+" + zh.Substring(1);
                    zh = "*" + vi.Substring(1);
                    vi = temp;
                }
                // Nếu câu sau là tiếng việt, câu hiện tại không có cặp
                else if (zh.StartsWith("*") && isVietNamSent(zh))
                {
                    --i;
                    continue;
                }
                // lấy dòng tiếng việt, xóa ký tự [*+] đầu dòng và cuối dòng => xóa khoảng trắng thừa
                vi = RemoveExtraSpace(Regex.Replace(vi, @"^[\*\+] *| *[.。,|/\\{}\[\]@#$%\^&\-_]+$", ""));
                // lấy dòng tiếng hoa, xóa ký tự [*+] đầu dòng và cuối dòng => xóa khoảng trắng thừa
                zh = RemoveExtraSpace(Regex.Replace(zh, @"^[\*\+] *| *[.。,|/\\{}\[\]@#$%\^&\-_]+$", ""));

                // Thử tìm text lặp trong câu, tạm thời chỉ search cặp liền nhau
                // Ví dụ như: xin chào, Xin chào, chào bạn
                // Còn xin chào, chào bạn, Xin chào thì chưa xóa được.
                var vis = vi.Split(',').ToList();
                var zhs = zh.Split(',').ToList();
                for (int t = 0; vis.Count == zhs.Count && t < vis.Count - 1; t++)
                {
                    if (vis[t].ToLower().Equals(vis[t + 1].ToLower()) && zhs[t].ToLower().Equals(zhs[t + 1].ToLower()))
                    {
                        vis.RemoveAt(i + 1);
                        zhs.RemoveAt(i + 1);
                    }
                }

                vi = "* " + vi;
                zh = "+ " + zh;

                if (Regex.IsMatch(vi, @"[!;:?]$"))
                {
                    zh += vi[vi.Count() - 1];
                }
                else
                {
                    vi += ".";
                    zh += "。";
                }

                pairLines.Add(vi);
                pairLines.Add(zh);
                pairLines.Add("");
            }
            int totalWords = 0, totalLines = 0;
            // Ghi file
            using (TextWriter tw = new StreamWriter(fileOut))
            {
                foreach (String s in pairLines)
                {
                    // Đếm số từ, số dòng, check nếu không phải dòng trống
                    if (!String.IsNullOrEmpty(s))
                    {
                        // Đếm số dòng, bỏ qua không đếm dòng trống
                        // Nếu muốn đếm cả dòng trống thì bỏ if này đi là được.
                        totalLines += 1;
                        totalWords += Regex.Matches(s, @"\p{L}+").Count;
                    }
                    // Ghi
                    tw.WriteLine(s);
                }
            }
            // Đưa thống kê vào label
            lblKetQua.Text = "Đã ghi " + totalLines + " dòng với " + totalWords + " từ (Click để mở file)";
            lblKetQua.Click += new System.EventHandler(labelKetQuaClick);
        }

        void labelKetQuaClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(fileOut);
        }

        private String RemoveExtraSpace(String txt)
        {
            // Thêm dấu cách cho tiếng Hoa
            if (!isVietNamSent(txt))
                txt = Regex.Replace(txt, @"", " ");
            // Xóa dấu cách thừa
            txt = Regex.Replace(txt, @"\s+", " ").Trim();

            return txt;
        }

        private bool isVietNamSent(String sent)
        {
            return Regex.IsMatch(sent, "[a-zA-Z]");
        }

    }
}
