namespace Calculatrice_1
{
    public partial class Form1 : Form
    {
        decimal reponse = 0.0m;
        decimal num1 = 0.0m;
        decimal num2 = 0.0m;
        string opperation;
        bool verifOpper = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btn7_Click(object sender, EventArgs e)
        {
            if (totalText.Text == "0")
            {
                totalText.Text = "7";
            }
            else
            {
                totalText.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (totalText.Text == "0")
            {
                totalText.Text = "8";
            }
            else
            {
                totalText.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (totalText.Text == "0")
            {
                totalText.Text = "9";
            }
            else
            {
                totalText.Text += "9";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (totalText.Text == "0")
            {
                totalText.Text = "4";
            }
            else
            {
                totalText.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (totalText.Text == "0")
            {
                totalText.Text = "5";
            }
            else
            {
                totalText.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (totalText.Text == "0")
            {
                totalText.Text = "6";
            }
            else
            {
                totalText.Text += "6";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (totalText.Text == "0")
            {
                totalText.Text = "3";
            }
            else
            {
                totalText.Text += "3";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (totalText.Text == "0")
            {
                totalText.Text = "2";
            }
            else
            {
                totalText.Text += "2";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (totalText.Text == "0")
            {
                totalText.Text = "1";
            }
            else
            {
                totalText.Text += "1";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (totalText.Text == "0")
            {
                totalText.Text = "0";
            }
            else
            {
                totalText.Text += "0";
            }
        }


        private void btnVirgule_Click(object sender, EventArgs e)
        {
            if (!totalText.Text.Contains(","))
            {
                totalText.Text += ",";
            }
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            if (totalText.Text == "0")
            {
                totalText.Text = "0";
            }
            else
            {
                totalText.Text = "";
            }
            verifOpper = false;
            btnAC.Text = "C";
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            if (totalText.Text.Contains("-"))
            {
                totalText.Text = totalText.Text.Trim('-');
            }
            else
            {
                totalText.Text = '-' + totalText.Text;
            }
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            if (verifOpper==false)
            {
                num1 = decimal.Parse(totalText.Text);
                opperation = "*";
                totalText.Text = "";
            }
            verifOpper = true;

        }

        private void btnDivision_Click(object sender, EventArgs e)
        {

            if (verifOpper == false)
            {
                num1 = decimal.Parse(totalText.Text);
                opperation = "/";
                totalText.Text = "";
            }
            verifOpper = true;



        }

        private void btnDifference_Click(object sender, EventArgs e)
        {
            if (verifOpper == false)
            {
                num1 = decimal.Parse(totalText.Text);
                opperation = "-";
                totalText.Text = "";
            }
            verifOpper = true;

        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            if (verifOpper == false) 
            {
                num1 = decimal.Parse(totalText.Text);
                opperation = "+";
                totalText.Text = "";
            }
            verifOpper = true;

        }

        private void btnEgale_Click(object sender, EventArgs e)
        {

            num2 = decimal.Parse(totalText.Text);
            if (opperation == "+")
            {
                reponse = num1 + num2;
            }

            if (opperation == "-")
            {
                reponse = num1 - num2;
            }

            if (opperation == "*")
            {
                reponse = num1 * num2;
            }

            if (opperation == "/")
            {
                reponse = num1 / num2;
            }

            totalText.Text = reponse.ToString();

        }

        private void btnPourcentage_Click(object sender, EventArgs e)
        {
            if (totalText.Text!="0")
            {   

                reponse = decimal.Parse(totalText.Text);
                reponse = reponse / 100;
                totalText.Text = reponse.ToString();
            }
        }
    }
}
