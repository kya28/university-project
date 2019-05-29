using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NeuralNetwork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "concentrationDataSet.Аммиак". При необходимости она может быть перемещена или удалена.
            this.аммиакTableAdapter.Fill(this.concentrationDataSet.Аммиак);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            аммиакBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            аммиакBindingSource.MoveNext();
        }

        private void button2_Click(object sender, EventArgs e)
        {          
           // аммиакBindingSource.EndEdit();
            this.аммиакTableAdapter.Update(this.concentrationDataSet.Аммиак);
           // аммиакTableAdapter.Update(concentrationDataSet.Аммиак);
    
            Console.WriteLine("Успешно");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            аммиакBindingSource.RemoveCurrent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            double ContInputs = Double.Parse(textBox1.Text);
            double a =  Predict.Data_MLP_1_2_1(ContInputs);
            textBox5.Text = a.ToString("0.000");




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
