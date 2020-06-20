using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using ComplexCalculator;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StringToComplex(String str, ref Complex num)
        {
            Regex regex = new Regex(@"\d*\,?\d+[+|-]\d*\,?\d+i");
            if (!regex.IsMatch(str))
            {
                // ResultLabel.Text = "Некорректные данные";

                MessageBox.Show("Некорректные данные", "Ошибка");
                return;
            }

            String n1 = null, n2 = null;
            Boolean minus_sign = false;
            int i, index = 0, first_index = 0;

            if (str[0] == '-' || str[0] == '+')
            {
                n1 += str[0];
                first_index = 1;
            }

            for (i = first_index; i < str.Length; i++)
            {
                if (str[i] == '+' || str[i] == '-')
                {
                    num.Re = Convert.ToSingle(n1);
                    minus_sign = (str[i] == '-') ? true : false;
                    index = i + 1;
                    break;
                }
                n1 += str[i];
            }

            if (minus_sign)
            {
                n2 = "-";
            }

            for (i = index; i < str.Length; i++)
            {
                if (str[i] == 'i')
                {
                    num.Im = Convert.ToSingle(n2);
                    break;
                }
                n2 += str[i];
            }

        }

        private void CalculateButton_Click_1(object sender, EventArgs e)
        {
            Complex left_num = new Complex();
            StringToComplex(LeftNumber.Text, ref left_num);

            Complex right_num = new Complex();
            StringToComplex(RightNumber.Text, ref right_num);

            //if (!(ResultLabel.Text == "Некорректные данные"))

            Regex regex = new Regex(@"\d*\,?\d+[+|-]\d*\,?\d+i");
            if (regex.IsMatch(LeftNumber.Text))
                if (regex.IsMatch(RightNumber.Text))
                {
                    Complex res = new Complex();
                    string selectedState = ActionList.Text;

                    switch (selectedState)
                    {
                        case "Разделить":
                            res = left_num / right_num;
                            break;

                        case "Умножить":
                            res = left_num * right_num;
                            break;

                        case "Сложить":
                            res = left_num + right_num;
                            break;

                        case "Вычесть":
                            res = left_num - right_num;
                            break;
                    }

                    if (res.Im >= 0)
                        ResultLabel.Text = res.Re.ToString() + "+" + res.Im.ToString() + "i";
                    else
                        ResultLabel.Text = res.Re.ToString() + res.Im.ToString() + "i";
                }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Complex left_num = new Complex();
            StringToComplex(LeftNumber.Text, ref left_num);


            string selectedState = comboBox1.SelectedItem.ToString();

            Regex regex = new Regex(@"\d*\,?\d+[+|-]\d*\,?\d+i");
            if (regex.IsMatch(LeftNumber.Text))

                switch (selectedState)
                {
                    case "Аргумент числа 1":
                        ArgAbsLabel.Text = left_num.GetArg().ToString();
                        break;

                    case "Модуль числа 1":
                        ArgAbsLabel.Text = left_num.GetAbs().ToString();
                        break;
                }


        }
    }
}
