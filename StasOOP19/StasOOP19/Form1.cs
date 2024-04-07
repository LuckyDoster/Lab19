using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StasOOP19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Рядок не повинен бути пустим!", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rep = RepeatingChars(textBox1.Text);
            int uniq = UniqChars(textBox1.Text);
            labelRes.Text = $"{rep} / {uniq} / {textBox1.Text.Length}";
        }

        // підрахунок повторюючих символів
        private int RepeatingChars(string str)
        {
            int result = 0;
            string temp = string.Empty;

            foreach (char chars in str)
            {
                if (!temp.Contains(chars))
                {
                    temp += chars;
                }
                else
                {
                    result++;
                }
            }
            return result;
        }

        // підрахунок унікальних символів
        private int UniqChars(string str)
        {
            int result = 0;
            string temp = string.Empty;

            foreach (char chars in str)
            {
                if (!temp.Contains(chars))
                {
                    temp += chars;
                    result++;
                }
            }
            return result;
        }
    }
}
