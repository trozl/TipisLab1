using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipisLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProbalityChecker checker = new ProbalityChecker();
            for(int i = 0; i < Convert.ToInt32(textBox1.Text); i++) 
            {
                listBox1.Items.Add(checker.Check());
            }
            chart1.Series["Series1"].LegendText = listBox1.Text;
            for(int i = 0;i < 10; i++)
            {
                chart1.Series["Series1"].Points.AddXY(checker.numbers[i], checker.answer[i]);
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }

    public class ProbalityChecker
    {
        public int[] numbers = {-2,-1,0,1,2,3,4,5,6,7};
        public int[] answer = new int[10];
        private int num { get; set; }

        private Random random = new Random();
        public ProbalityChecker()
        {
            for (int i = 0; i <= 9; i++)
            {
                answer[i] = 0;
            }
        }
        public int Check() {
            num = random.Next(-2,8);
            switch (num)
            {
                    case -2:
                    answer[0]++;
                    break;
                    case -1:
                    answer[1]++;
                    break;
                    case 0:
                    answer[2]++;
                    break;
                    case 1:
                    answer[3]++;
                    break;
                    case 2:
                    answer[4]++;
                    break;
                    case 3:
                    answer[5]++;
                    break;
                    case 4:
                    answer[6]++;
                    break;
                    case 5:
                    answer[7]++;
                    break;
                    case 6:
                    answer[8]++;
                    break;
                    case 7:
                    answer[9]++;
                    break;
            }
            return num;
        }

    }
}
