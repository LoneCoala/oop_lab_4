using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_лаба
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {



            int a = (int)numericUpDown1.Value;

            if (a <= 10)
            {
                dataGridView1.ColumnCount = a;
                for (int i = 0; i < a; i++)
                {
                    dataGridView1.Columns[i].Width = 22;
                    dataGridView1.Columns[i].HeaderCell.Value = string.Format((i + 1).ToString(), "0");
                }
                dataGridView2.ColumnCount = a;
                for (int i = 0; i < a; i++)
                {
                    dataGridView2.Columns[i].Width = 22;
                    dataGridView2.Columns[i].HeaderCell.Value = string.Format((i + 1).ToString(), "0");
                }
                dataGridView3.ColumnCount = a;
                for (int i = 0; i < a; i++)
                {
                    dataGridView3.Columns[i].Width = 22;
                    dataGridView3.Columns[i].HeaderCell.Value = string.Format((i + 1).ToString(), "0");
                }
                
            }
            else
            {
                MessageBox.Show(
                                 "Введено неверное значение",
                                 "Сообщение",
                                 MessageBoxButtons.OK);
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            int b;
            b = (int)numericUpDown2.Value;
            if (b <= 10)
            {
                dataGridView1.RowCount = b;
                for (int i = 0; i < b; i++)
                {
                    dataGridView1.Rows[i].HeaderCell.Value = string.Format((i + 1).ToString(), "0");
                }
                dataGridView2.RowCount = b;
                for (int i = 0; i < b; i++)
                {
                    dataGridView2.Rows[i].HeaderCell.Value = string.Format((i + 1).ToString(), "0");
                }
                dataGridView3.RowCount = b;
                for (int i = 0; i < b; i++)
                {
                    dataGridView3.Rows[i].HeaderCell.Value = string.Format((i + 1).ToString(), "0");
                }
                

            }
            else
            {
                MessageBox.Show(
                                 "Введено неверное значение",
                                 "Сообщение",
                                 MessageBoxButtons.OK);
            }

            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int g = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int c = 0; c < dataGridView1.Columns.Count; c++)
                {

                    if (dataGridView1.Rows[i].Cells[c].Value == null)
                    {
                        dataGridView1.Rows[i].Cells[c].Value = 0;
                    }
                    else
                    {

                        double l;
                        string k;
                        k = dataGridView1.Rows[i].Cells[c].Value.ToString();

                        bool result2 = double.TryParse(k, out l);
                        if (result2 == true)
                        {
                            g++;


                        }
                        else
                        {

                            label8.Text = "Исходные данные не корректны";
                        }

                    }
                }
            }

            int m = 0;
            for (int q = 0; q < dataGridView2.Rows.Count; q++)
            {
                for (int w = 0; w < dataGridView2.Columns.Count; w++)
                {
                    if (dataGridView2.Rows[q].Cells[w].Value == null)
                    {
                        dataGridView2.Rows[q].Cells[w].Value = 0;
                    }
                    else
                    {
                       double f;
                        string r;
                        r = dataGridView2.Rows[q].Cells[w].Value.ToString();

                        bool result1 = double.TryParse(r, out f);
                        if (result1 == true)
                        {
                            m++;

                        }
                        else
                        {
                            label8.Text = "Исходные данные не корректны";
                        }
                    }
                }
            }
            if (g == m)
            {

                for (int h = 0; h < dataGridView3.Rows.Count; h++)
                {
                    for (int j = 0; j < dataGridView3.Columns.Count; j++)
                    {
                        label8.Text = "";
                        double x, y, z;
                        x = 0;
                        y = 0;
                        z = 0;
                        x = Convert.ToDouble(dataGridView1.Rows[h].Cells[j].Value);
                        y = Convert.ToDouble(dataGridView2.Rows[h].Cells[j].Value);
                        if (radioButton1.Checked)
                            z = x + y;
                        else if (radioButton2.Checked)
                            z = x - y; 
                        dataGridView3.Rows[h].Cells[j].Value = z;
                    }

                }
            }
        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int g = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int c = 0; c < dataGridView1.Columns.Count; c++)
                {

                    if (dataGridView1.Rows[i].Cells[c].Value == null)
                    {
                        dataGridView1.Rows[i].Cells[c].Value = 0;
                    }
                    else
                    {

                       double l;
                        string k;
                        k = dataGridView1.Rows[i].Cells[c].Value.ToString();

                        bool result2 = double.TryParse(k, out l);
                        if (result2 == true)
                        {
                            g++;
                            

                        }
                        else
                        {

                            label8.Text = "Исходные данные не корректны";
                        }

                    }
                }
            }

            int m = 0;
            for (int q = 0; q < dataGridView2.Rows.Count; q++)
            {
                for (int w = 0; w < dataGridView2.Columns.Count; w++)
                {
                    if (dataGridView2.Rows[q].Cells[w].Value == null)
                    {
                        dataGridView2.Rows[q].Cells[w].Value = 0;
                    }
                    else
                    {
                        double f;
                        string r;
                        r = dataGridView2.Rows[q].Cells[w].Value.ToString();

                        bool result1 = double.TryParse(r, out f);
                        if (result1 == true)
                        {
                            m++;
                            
                        }
                        else
                        {
                            label8.Text = "Исходные данные не корректны";
                        }
                    }
                }
            }
            if (g == m)
            {

                for (int h = 0; h < dataGridView3.Rows.Count; h++)
                {
                    for (int j = 0; j < dataGridView3.Columns.Count; j++)
                    {
                        label8.Text = "";
                        double x, y, z;
                        x = 0;
                        y = 0;
                        z = 0;
                        x = Convert.ToDouble(dataGridView1.Rows[h].Cells[j].Value);
                        y = Convert.ToDouble(dataGridView2.Rows[h].Cells[j].Value);
                        if (radioButton1.Checked)
                            z = x + y;
                        else if (radioButton2.Checked)
                            z = x - y;
                        dataGridView3.Rows[h].Cells[j].Value = Convert.ToString(z);
                    }

                }
            }
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView3.Update();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView3.Update();
        }
    }
}

