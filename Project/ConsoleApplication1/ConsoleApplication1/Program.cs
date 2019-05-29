using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{


    public class Predict

    {

        public static void Data_MLP_1_2_1(double[] ContInputs)

        {

            //"Input Variable" comment is added besides Input(Response) variables.



            int Cont_idx = 0;

            double temperature = ContInputs[Cont_idx++]; //Input Variable

            double[] __statist_max_input = new double[1];

            __statist_max_input[0] = 3.10000000000000e+001;



            double[] __statist_min_input = new double[1];

            __statist_min_input[0] = -2.40000000000000e+001;



            double[] __statist_max_target = new double[1];

            __statist_max_target[0] = 8.30000000000000e-002;



            double[] __statist_min_target = new double[1];

            __statist_min_target[0] = 2.40000000000000e-002;





            double[,] __statist_i_h_wts = new double[2, 1];



            __statist_i_h_wts[0, 0] = -1.84347189126133e-001;



            __statist_i_h_wts[1, 0] = 1.21091261296687e+000;



            double[,] __statist_h_o_wts = new double[1, 2];



            __statist_h_o_wts[0, 0] = 2.00186806572112e-001;

            __statist_h_o_wts[0, 1] = -1.17619280657529e+000;



            double[] __statist_hidden_bias = new double[2];

            __statist_hidden_bias[0] = -9.19566585841919e-002;

            __statist_hidden_bias[1] = -3.44473521746725e-001;



            double[] __statist_output_bias = new double[1];

            __statist_output_bias[0] = -3.46188230731474e-001;



            double[] __statist_inputs = new double[1];



            double[] __statist_hidden = new double[2];



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

            int __statist_nhidden = 2;



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
        }
    }
}



        
