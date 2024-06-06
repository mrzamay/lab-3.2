using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestInput
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int a;
        private double b;
        private double d;


        private TestClass tClass = new TestClass();
        private Clac2 calc2 = new Clac2();

        //Пример обработки исключения - ошибки присвоения неверного значения
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tClass.a = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            // Пример преобразование целого
            string t = tbA.Text;
            if (!int.TryParse(t, out a))
            {
                MessageBox.Show("Ошибка ввода параметра A !");
                tbA.Focus();
            }
            else
            {
                try
                {
                    calc2.a = a;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                    tbA.Focus();
                    return;
                }
                calc2.a = a;
                calc2.data[comboBox1.Items.Count, 0] = a;
                MessageBox.Show("Параметр a считан!");
            }

            // Пример преобразование вещественного
            t = tbB.Text;
            if (!double.TryParse(t, out b))
            {
                MessageBox.Show("Ошибка ввода параметра B!");
                tbB.Focus();
            }
            else
            {
                try
                {
                    calc2.b = b;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                    tbB.Focus();
                    return;
                }
                calc2.data[comboBox1.Items.Count, 1] = b;
                MessageBox.Show("Параметр b считан!");
            }

            t = tbD.Text;
            if (!double.TryParse(t, out d))
            {
                MessageBox.Show("Ошибка ввода параметра d!");
                tbD.Focus();
            }
            else
            {
                try
                {
                    calc2.d = d;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                    tbB.Focus();
                    return;
                }
                calc2.data[comboBox1.Items.Count, 2] = d;
                MessageBox.Show("Параметр d считан!");
            }

            //Вызов метода для расчета
            double Rez = calc2.getAnsw();
            string newRez = Convert.ToString(Rez);
            calc2.data[comboBox1.Items.Count, 3] = (Math.Round(Rez, 4));
            comboBox1.Items.Add(comboBox1.Items.Count + 1);


            //Вывод результатов с форматированием (4 знака после запятой)
            tbRez.Text = newRez;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbA.Text = Convert.ToString(calc2.data[comboBox1.SelectedIndex, 0]);
            tbB.Text = Convert.ToString(calc2.data[comboBox1.SelectedIndex, 1]);
            tbD.Text = Convert.ToString(calc2.data[comboBox1.SelectedIndex, 2]);
            tbRez.Text = Convert.ToString(calc2.data[comboBox1.SelectedIndex, 3]);
        }
    }
}