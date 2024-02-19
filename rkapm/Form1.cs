using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rkapm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int number = (int)numericUpDown1.Value;
            if (number >= 7000)
            {
                MessageBox.Show(Convert.ToString("Данное число слишком велико для отображения"));
            } else
            {
                BigInteger factorial = CalculateFactorial(number);
                MessageBox.Show(Convert.ToString(factorial));
            }
        }

        static BigInteger CalculateFactorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * CalculateFactorial(n - 1);
        }
    }    
}
