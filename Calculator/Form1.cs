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

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string inputMem = "";
        private bool returnedValue = false;

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (returnedValue)
            {
                inputMem = "";
                txtDisplay.Text = "";
                txtStringDisplay.Text = "";
                returnedValue = false;
                inputMem = inputMem + "1";
                txtStringDisplay.Text = inputMem;
            }
            else
            {
                inputMem = inputMem + "1";
                txtStringDisplay.Text = inputMem;
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (returnedValue)
            {
                inputMem = "";
                txtDisplay.Text = "";
                txtStringDisplay.Text = "";
                returnedValue = false;
                inputMem = inputMem + "2";
                txtStringDisplay.Text = inputMem;
            }
            else
            {
                inputMem = inputMem + "2";
                txtStringDisplay.Text = inputMem;
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (returnedValue)
            {
                inputMem = "";
                txtDisplay.Text = "";
                txtStringDisplay.Text = "";
                returnedValue = false;
                inputMem = inputMem + "3";
                txtStringDisplay.Text = inputMem;
            }
            else
            {
                inputMem = inputMem + "3";
                txtStringDisplay.Text = inputMem;
            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (returnedValue)
            {
                inputMem = "";
                txtDisplay.Text = "";
                txtStringDisplay.Text = "";
                returnedValue = false;
                inputMem = inputMem + "4";
                txtStringDisplay.Text = inputMem;
            }
            else
            {
                inputMem = inputMem + "4";
                txtStringDisplay.Text = inputMem;
            }
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (returnedValue)
            {
                inputMem = "";
                txtDisplay.Text = "";
                txtStringDisplay.Text = "";
                returnedValue = false;
                inputMem = inputMem + "5";
                txtStringDisplay.Text = inputMem;
            }
            else
            {
                inputMem = inputMem + "5";
                txtStringDisplay.Text = inputMem;
            }
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (returnedValue)
            {
                inputMem = "";
                txtDisplay.Text = "";
                txtStringDisplay.Text = "";
                returnedValue = false;
                inputMem = inputMem + "6";
                txtStringDisplay.Text = inputMem;
            }
            else
            {
                inputMem = inputMem + "6";
                txtStringDisplay.Text = inputMem;
            }
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (returnedValue)
            {
                inputMem = "";
                txtDisplay.Text = "";
                txtStringDisplay.Text = "";
                returnedValue = false;
                inputMem = inputMem + "7";
                txtStringDisplay.Text = inputMem;
            }
            else
            {
                inputMem = inputMem + "7";
                txtStringDisplay.Text = inputMem;
            }
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (returnedValue)
            {
                inputMem = "";
                txtDisplay.Text = "";
                txtStringDisplay.Text = "";
                returnedValue = false;
                inputMem = inputMem + "8";
                txtStringDisplay.Text = inputMem;
            }
            else
            {
                inputMem = inputMem + "8";
                txtStringDisplay.Text = inputMem;
            }
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (returnedValue)
            {
                inputMem = "";
                txtDisplay.Text = "";
                txtStringDisplay.Text = "";
                returnedValue = false;
                inputMem = inputMem + "9";
                txtStringDisplay.Text = inputMem;
            }
            else
            {
                inputMem = inputMem + "9";
                txtStringDisplay.Text = inputMem;
            }
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            if (returnedValue)
            {
                inputMem = "";
                txtDisplay.Text = "";
                txtStringDisplay.Text = "";
                returnedValue = false;
                inputMem = inputMem + "0";
                txtStringDisplay.Text = inputMem;
            }
            else
            {
                inputMem = inputMem + "0";
                txtStringDisplay.Text = inputMem;
            }
        }

        private void BtnDec_Click(object sender, EventArgs e)
        {
            if (returnedValue)
            {
                inputMem = "";
                txtDisplay.Text = "";
                txtStringDisplay.Text = "";
                returnedValue = false;
                inputMem = inputMem + ".";
                txtStringDisplay.Text = inputMem;
            }
            else
            {
                inputMem = inputMem + ".";
                txtStringDisplay.Text = inputMem;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (Regex.Match(inputMem, @"[\d\.]$").Success) {
                inputMem = inputMem + "+";
                txtStringDisplay.Text = inputMem;
            }
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            if (Regex.Match(inputMem, @"[\d\.]$").Success)
            {
                inputMem = inputMem + "-";
                txtStringDisplay.Text = inputMem;
            }
        }

        private void BtnMult_Click(object sender, EventArgs e)
        {
            if (Regex.Match(inputMem, @"[\d\.]$").Success)
            {
                inputMem = inputMem + "*";
                txtStringDisplay.Text = inputMem;
            }
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            if (Regex.Match(inputMem, @"[\d\.]$").Success)
            {
                inputMem = inputMem + "/";
                txtStringDisplay.Text = inputMem;
            }
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if (Regex.Match(inputMem, @"[\d\.]$").Success)
            {

                DataTable dt = new DataTable();
                string dispCacl = dt.Compute(inputMem, "").ToString();
                txtDisplay.Text = dispCacl;
                returnedValue = true;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            inputMem = "";
            txtDisplay.Text = "";
            txtStringDisplay.Text = "";
            returnedValue = false;
        }
    }
}
