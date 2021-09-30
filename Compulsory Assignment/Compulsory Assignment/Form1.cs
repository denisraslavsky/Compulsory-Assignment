using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compulsory_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private async void button_Sequential_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            long start = 0;
            long last = 0;
            
            try
            {
                 start = long.Parse(textBox_Start.Text);
                 last = long.Parse(textBox_Last.Text);
            }
            catch (Exception ex)
            {
                textBox_Console.AppendText(ex.Message + Environment.NewLine);
            }

            Stopwatch sw = new Stopwatch();
            sw.Start();
            List<long> primes = await Task.Run(() =>  PrimeGenerator.GetPrimesSequential(start, last) );
            sw.Stop();
            textBox_Console.AppendText("Generating Sequentually took " + sw.Elapsed.TotalSeconds + " seconds " + Environment.NewLine);

            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            await Task.Run(() =>
            {
                foreach (long prime in primes)
                {
                    this.Invoke(new Action(
                        () => listBox1.Items.Add(prime)
                    ));
                }
            });
            sw2.Stop();
            textBox_Console.AppendText("Writing took " + sw2.Elapsed.TotalSeconds + " seconds " + Environment.NewLine);
        }

        private async void button_Parallel_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            long start = 0;
            long last = 0;
            
            try
            {
                start = long.Parse(textBox_Start.Text);
                last = long.Parse(textBox_Last.Text);
            }
            catch (Exception ex)
            {
                textBox_Console.AppendText(ex.Message + Environment.NewLine);
            }

            Stopwatch sw = new Stopwatch();
            sw.Start();
            List<long> primes = await Task.Run(() => PrimeGenerator.GetPrimesParallel(start, last));
            sw.Stop();
            textBox_Console.AppendText("Generating Parallelly took " + sw.Elapsed.TotalSeconds + " seconds " + Environment.NewLine);

            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            await Task.Run(() =>
            {
                foreach (long prime in primes)
                {
                    this.Invoke(new Action(
                        () => listBox1.Items.Add(prime)
                    ));
                }
            });
            sw2.Stop();
            textBox_Console.AppendText("Writing took " + sw2.Elapsed.TotalSeconds + " seconds " + Environment.NewLine);
        }
    }
}
