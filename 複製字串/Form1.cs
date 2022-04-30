using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime;

namespace 複製字串
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        List<Thread> threads;
        List<string> copyedStringList;
        string copyingString;


        void Copy()
        {
            string s = "";
            for (int i = 1000; i > 0; i--)
                s += copyingString;
            copyedStringList.Add(s);
        }

        private void Form1_Load(object sender, EventArgs e) => input.Focus();

        private void start_Click(object sender, EventArgs e)
        {
            output.Text = "";
            groupBox.Enabled = false;
            threads = new List<Thread>();
            copyedStringList = new List<string>();
            copyingString = input.Text;
            string allString = "";
            for (int count = (int)(times.Value / 1000), index = 0; count > 0; count--, index++)
            {
                threads.Add(new Thread(Copy));
                threads[threads.Count - 1].Start();
                timesLeft.Text = count.ToString();
                Application.DoEvents();
            }
            for (int i = (int)(times.Value % 1000); i > 0; i--)
                allString += input.Text;
            while (true)
            {
                int i;
                for (i = 0; i < threads.Count && !threads[i].IsAlive; i++)
                { }
                if (i >= threads.Count)
                    break;
                timesLeft.Text = (threads.Count - 1).ToString();
                Application.DoEvents();
            }
            for (int i = 0; i < copyedStringList.Count; i++)
            {
                allString += copyedStringList[i];
                timesLeft.Text = (copyedStringList.Count - i).ToString();
                Application.DoEvents();
            }
            output.Text = allString;
            Console.Beep();
            timesLeft.Text = "複製完成";
            Clipboard.SetData(DataFormats.Text, output.Text);
            groupBox.Enabled = true;
            input.Focus();
        }

        private void input_TextChanged(object sender, EventArgs e) => inputLenth.Text = string.Format("{0:N0}", input.Text.Length) + " 字";

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;
            if (!e.Shift)
            {
                e.Handled = true;
                start_Click(null, null);
            }
        }
    }
}
