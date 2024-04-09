using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaiXiu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int currentMoney = 100;
        int rollCount = 0;


        private List<string> diceImages = new List<string>
        {
            "1.png", "2.png", "3.png", "4.png", "5.png", "6.png"
        };
        private void btRoll_Click(object sender, EventArgs e)
        {
            int betAmount;
            if (!int.TryParse(txtBet.Text, out betAmount) || betAmount <= 0 || betAmount > currentMoney)
            {
                MessageBox.Show("Số tiền cược không hợp lệ hoặc vượt quá số tiền hiện tại!");
                return;
            }
            List<string> randomDice = GetRandomDice();

            // Hiển thị 3 file ảnh tương ứng lên PictureBoxes
            pic1.Image = Image.FromFile(Path.Combine("D:\\C# Project\\TaiXiu\\images", randomDice[0]));
            pic2.Image = Image.FromFile(Path.Combine("D:\\C# Project\\TaiXiu\\images", randomDice[1]));
            pic3.Image = Image.FromFile(Path.Combine("D:\\C# Project\\TaiXiu\\images", randomDice[2]));
            int total = randomDice.Select(d => int.Parse(Path.GetFileNameWithoutExtension(d))).Sum();

            // Xác định người chơi đã chọn tài hay xỉu
            bool chosenTai = rbtTai.Checked;
            // Xử lý logic đặt cược và cập nhật số tiền
            HandleBet(total, chosenTai, betAmount);
            string s = chosenTai ? rbtTai.Text.ToString() : rbtXiu.Text.ToString();
            s = s.Substring(0, 3);
            // Lưu kết quả lịch sử vào ListView
            ListViewItem item = new ListViewItem((++rollCount).ToString()); // Tăng số lần chơi và lấy số thứ tự mới
            item.SubItems.Add(total.ToString());
            item.SubItems.Add((betAmount.ToString()) +" "+ s );
            item.SubItems.Add((total <= 10 && !chosenTai) || (total > 10 && chosenTai) ? "Thắng" : "Thua");
            listHistory.Items.Add(item);
        }
        private List<string> GetRandomDice()
        {
            // Lấy ra 3 file ngẫu nhiên từ danh sách mặt xúc xắc
            return diceImages.OrderBy(x => random.Next()).Take(3).ToList();
        }
        private void HandleBet(int total, bool chosenTai, int betAmount)
        {
            // Xử lý logic đặt cược và cập nhật số tiền
            if ((total <= 10 && !chosenTai) || (total > 10 && chosenTai))
            {
                currentMoney += betAmount;
            }
            else
            {
                currentMoney -= betAmount;
            }

            // Cập nhật số tiền hiện tại
            txtCurrent.Text = currentMoney.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            rbtTai.Checked = true;
            txtCurrent.Text = currentMoney.ToString();
            listHistory.Columns[0].Width = (int)(0.25 * listHistory.Width);
            listHistory.Columns[1].Width = (int)(0.25 * listHistory.Width);
            listHistory.Columns[2].Width = (int)(0.25 * listHistory.Width);
            listHistory.Columns[3].Width = (int)(0.25 * listHistory.Width);
        }
    }
}
