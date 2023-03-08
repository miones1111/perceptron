using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miones_PerceptronAlgo
{
    public partial class Form1 : Form
    {
        double weight1, weight2;
        double bias;
        double learningRate;
        int numberOfEpochs;
        int[,] inputs;
        int[] outputs;
        Random rand = new Random(); 

        public Form1()
        {
            InitializeComponent();

            numberOfEpochs = 10;
            learningRate = 0.1;

            inputs = new int[,]
            {
                {0,0 },
                {0,1 },
                {1,0 },
                {1,1 }
            };

            outputs = new int[]
            {
                0,
                0,
                0,
                1
            };

            weight1 = rand.NextDouble();
            weight2 = rand.NextDouble();
            bias = rand.NextDouble();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_train_Click_1(object sender, EventArgs e)
        {
            for (int epochItr = 0; epochItr < numberOfEpochs; epochItr++)
            {
                for (int inputItr = 0; inputItr < inputs.GetLength(0); inputItr++)
                {
                    double result_temp = inputs[inputItr, 0] * weight1 + inputs[inputItr, 1] * weight2 + bias;
                    int result = result_temp > 0 ? 1 : 0;
                    int delta = outputs[inputItr] - result;
                    if (delta != 0)
                    {
                        weight1 += learningRate * delta * inputs[inputItr, 0];
                        weight2 += learningRate * delta * inputs[inputItr, 1];
                        bias += learningRate * delta;
                    }
                }
            }
            MessageBox.Show("Training finished");
            input1_txt.Enabled = true;
            input2_txt.Enabled = true;
            btn_test.Enabled = true;
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            try
            {
                int input_1 = int.Parse(input1_txt.Text);
                int input_2 = int.Parse(input2_txt.Text);
                double result_temp = input_1 * weight1 + input_2 * weight2 + bias;
                int result = (result_temp > 0) ? 1 : 0;
                ouput_txt.Text = "" + result;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Please input only 1 or 0");
            }
        }
    }
}
