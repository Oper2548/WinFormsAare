using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsAare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] student = new string[5];
            student[0] = "คิม";
            student[1] = "ไอคิว";
            student[2] = "เขต";
            student[3] = "ขุนมุ่ง";
            student[4] = "เบว";
            string test = "";
            int n = student.Length;
            for (int i = 0; i < n; i++)
            {
                test += student[i] + Environment.NewLine;
            }
            MessageBox.Show(test);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] Fruits = { "แอบเป้น", "หมากหร้าว", "ผักอี่ตู่", "หมากมี้", "มะแง๊ว", "อีเริ่ด", "รังเพิ่ง", "ครับ" };
            string myFruits = "";
            foreach (string str in Fruits)
            {
                myFruits += str + ", ";
            }
            MessageBox.Show(myFruits, "ผมลไม้");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String[] daata = textBox1.Lines; //นำข้อมูลแต่ละบรรทัด ใส่ในอาเร
            String result = "";
            foreach (String str in daata)
            {
                if (str != "") //ถ้าไม่ใช่ที่ว่าง ทำ!
                {
                    result += str + Environment.NewLine;
                }

            }
            //ว่างแล้วทำอันนี้
            label1.Text = result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sum = 0;
            String[] daata = textBox1.Lines; //นำข้อมูลแต่ละบรรทัด ใส่ในอาเร
            String result = "";

            foreach (var str in daata)
            {

                int x = 0;
                if (int.TryParse(str, out x))
                {
                    sum += x;
                    result += x.ToString() + Environment.NewLine;
                }

            }

            label1.Text = result;
            MessageBox.Show(sum.ToString(), "ผลรวม");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[,] student = new string[3, 2];
            student[0, 0] = "ผม";
            student[0, 1] = "ที่ไหน";
            student[1, 0] = "เธอ";
            student[1, 1] = "ที่นั้น";
            student[2, 0] = "เขา";
            student[2, 1] = "ที่นี้";
            string ResultData = "";
            int m = student.GetLength(0);
            int n = student.GetLength(1);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    ResultData += student[i, j];
                    if (j < n - 1) // ถ้าไม่ใช่ค่าสุดท้ายในแถว ให้เพิ่ม -
                    {
                        ResultData += "-";
                    }
                }
                ResultData += Environment.NewLine;
            }
            MessageBox.Show(ResultData, "แสดงข้อมูลใน Array 2 miti");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] Fruits = { "แอบเป้น", "หมากหร้าว", "ผักอี่ตู่", "หมากมี้", "มะแง๊ว", "อีเริ่ด", "รังเพิ่ง", "ครับ" };
            comboBox1.Items.AddRange(Fruits);
            listBox1.Items.AddRange(Fruits);
            checkedListBox1.Items.AddRange(Fruits);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = comboBox1.SelectedIndex.ToString();
            str += comboBox1.SelectedItem;
            MessageBox.Show(str);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = listBox1.SelectedIndex.ToString();
            str += listBox1.SelectedItem;
            MessageBox.Show(str);
        }
    }
}