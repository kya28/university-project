using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNetwork
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class Predict
    {
        public static double Data_MLP_1_2_1(double ContInputs)
        {
            //"Input Variable" comment is added besides Input(Response) variables.
            double concentration = 0;
            double temperature = ContInputs; //Input Variable
            double[] __statist_max_input = new double[1];

            __statist_max_input[0] = 3.00000000000000e+001;



            double[] __statist_min_input = new double[1];

            __statist_min_input[0] = -1.60000000000000e+001;



            double[] __statist_max_target = new double[1];

            __statist_max_target[0] = 1.78000000000000e-001;



            double[] __statist_min_target = new double[1];

            __statist_min_target[0] = 2.00000000000000e-003;





            double[,] __statist_i_h_wts = new double[8, 1];



            __statist_i_h_wts[0, 0] = 8.09153068023046e-001;



            __statist_i_h_wts[1, 0] = 9.69016751943148e-001;



            __statist_i_h_wts[2, 0] = 2.83674094310709e+000;



            __statist_i_h_wts[3, 0] = 8.44039275647627e-001;



            __statist_i_h_wts[4, 0] = -1.90062402204179e+000;



            __statist_i_h_wts[5, 0] = 1.09400284938386e+001;



            __statist_i_h_wts[6, 0] = 1.69343417341408e+000;



            __statist_i_h_wts[7, 0] = 2.71435668602214e+000;



            double[,] __statist_h_o_wts = new double[1, 8];



            __statist_h_o_wts[0, 0] = -1.21511017595458e+000;

            __statist_h_o_wts[0, 1] = -1.60312773992698e+000;

            __statist_h_o_wts[0, 2] = 9.67221203755169e-001;

            __statist_h_o_wts[0, 3] = -2.36049008296957e+000;

            __statist_h_o_wts[0, 4] = -1.77854268344020e+000;

            __statist_h_o_wts[0, 5] = -2.79114175111965e-001;

            __statist_h_o_wts[0, 6] = 3.04018554769753e+000;

            __statist_h_o_wts[0, 7] = -6.86792152498171e-001;



            double[] __statist_hidden_bias = new double[8];

            __statist_hidden_bias[0] = -9.27005271416471e-002;

            __statist_hidden_bias[1] = 6.60266865830720e-001;

            __statist_hidden_bias[2] = 3.80219753968691e-001;

            __statist_hidden_bias[3] = 3.23682391802115e-001;

            __statist_hidden_bias[4] = 1.82720724281208e+000;

            __statist_hidden_bias[5] = -5.88468850477317e+000;

            __statist_hidden_bias[6] = 1.25759229747923e+000;

            __statist_hidden_bias[7] = 4.81978254319669e-001;



            double[] __statist_output_bias = new double[1];

            __statist_output_bias[0] = 2.16371040775718e+000;



            double[] __statist_inputs = new double[1];



            double[] __statist_hidden = new double[8];



            double[] __statist_outputs = new double[1];

            __statist_outputs[0] = -1.0e+307;

            __statist_inputs[0] = temperature;
            double __statist_delta = 0;
            double __statist_maximum = 1;
            double __statist_minimum = 0;
            int __statist_ncont_inputs = 1;
            /*scale continuous inputs*/
            for (int __statist_i = 0; __statist_i < __statist_ncont_inputs; __statist_i++)
            {
                __statist_delta = (__statist_maximum - __statist_minimum) / (__statist_max_input[__statist_i] - __statist_min_input[__statist_i]);
                __statist_inputs[__statist_i] = __statist_minimum - __statist_delta * __statist_min_input[__statist_i] + __statist_delta * __statist_inputs[__statist_i];
            }
            int __statist_ninputs = 1;
            int __statist_nhidden = 8;
            /*Compute feed forward signals from Input layer to hidden layer*/
            for (int __statist_row = 0; __statist_row < __statist_nhidden; __statist_row++)
            {
                __statist_hidden[__statist_row] = 0.0;
                for (int __statist_col = 0; __statist_col < __statist_ninputs; __statist_col++)
                {
                    __statist_hidden[__statist_row] = __statist_hidden[__statist_row] + (__statist_i_h_wts[__statist_row, __statist_col] * __statist_inputs[__statist_col]);
                }
                __statist_hidden[__statist_row] = __statist_hidden[__statist_row] + __statist_hidden_bias[__statist_row];
            }
            for (int __statist_row = 0; __statist_row < __statist_nhidden; __statist_row++)
            {
                if (__statist_hidden[__statist_row] > 100.0)
                {
                    __statist_hidden[__statist_row] = 1.0;
                }
                else
                {
                    if (__statist_hidden[__statist_row] < -100.0)
                    {
                        __statist_hidden[__statist_row] = 0.0;
                    }
                    else
                    {
                        __statist_hidden[__statist_row] = 1.0 / (1.0 + Math.Exp(-__statist_hidden[__statist_row]));
                    }
                }
            }
            int __statist_noutputs = 1;
            /*Compute feed forward signals from hidden layer to output layer*/
            for (int __statist_row2 = 0; __statist_row2 < __statist_noutputs; __statist_row2++)
            {
                __statist_outputs[__statist_row2] = 0.0;
                for (int __statist_col2 = 0; __statist_col2 < __statist_nhidden; __statist_col2++)
                {
                    __statist_outputs[__statist_row2] = __statist_outputs[__statist_row2] + (__statist_h_o_wts[__statist_row2, __statist_col2] * __statist_hidden[__statist_col2]);
                }
                __statist_outputs[__statist_row2] = __statist_outputs[__statist_row2] + __statist_output_bias[__statist_row2];
            }
            for (int __statist_row = 0; __statist_row < __statist_noutputs; __statist_row++)
            {
                if (__statist_outputs[__statist_row] > 100.0)
                {
                    __statist_outputs[__statist_row] = 1.0;
                }
                else
                {
                    __statist_outputs[__statist_row] = Math.Exp(__statist_outputs[__statist_row]);
                }
            }
            /*Unscale continuous targets*/
            __statist_delta = 0;

            for (int __statist_i = 0; __statist_i < __statist_noutputs; __statist_i++)
            {
                __statist_delta = (__statist_maximum - __statist_minimum) / (__statist_max_target[__statist_i] - __statist_min_target[__statist_i]);
                __statist_outputs[__statist_i] = (__statist_outputs[__statist_i] - __statist_minimum + __statist_delta * __statist_min_target[__statist_i]) / __statist_delta;
            }       

            concentration = Math.Abs((__statist_outputs[0]*100 - 22) *0.1);            
            return concentration;
        }


    }
    }

