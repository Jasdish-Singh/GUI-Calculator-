namespace assignment_10
{
    public partial class Form1 : Form
    {
        private double _value = 0;
        private double _value2 = 0;
        private double Total = 0;
        private string opreaters = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!txtvalue.Text.Contains("."))
            {
                txtvalue.Text += ".";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbCalculator_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (txtvalue.Text == "0")

                txtvalue.Text = "0";

            else
            {

                txtvalue.Text += "0";

            }
        }
        private void RbdScientific_CheckedChanged(object sender, EventArgs e)
        {
            btn_Pie.Visible = true;
            btn_sin.Visible = true;
            btn_cube.Visible = true;
            btn_cos.Visible = true;
        }

        private void rbdStandard_CheckedChanged(object sender, EventArgs e)
        {
            btn_Pie.Visible = false;
            btn_sin.Visible = false;
            btn_cube.Visible = false;
            btn_cos.Visible = false;
        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.tbCalculator.BackColor = Color.DarkGray;
            this.BackColor = Color.DarkGray;


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.tbCalculator.BackColor = Color.LightBlue;
            this.BackColor = Color.LightBlue;

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (txtvalue.Text == "0")
            {
                if (txtvalue.Text == "0")

                    txtvalue.Text = "1";
            }

            else
            {
                txtvalue.Text += "1";
            }


        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (txtvalue.Text == "0")
            {
                if (txtvalue.Text == "0")

                    txtvalue.Text = "2";
            }

            else
            {
                txtvalue.Text += "2";
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (txtvalue.Text == "0")
            {
                if (txtvalue.Text == "0")

                    txtvalue.Text = "3";
            }

            else
            {
                txtvalue.Text += "3";
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (txtvalue.Text == "0")
            {
                if (txtvalue.Text == "0")

                    txtvalue.Text = "4";
            }

            else
            {
                txtvalue.Text += "4";
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (txtvalue.Text == "0")
            {
                if (txtvalue.Text == "0")

                    txtvalue.Text = "5";
            }

            else
            {
                txtvalue.Text += "5";
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (txtvalue.Text == "0")
            {
                if (txtvalue.Text == "0")

                    txtvalue.Text = "6";
            }

            else
            {
                txtvalue.Text += "6";
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (txtvalue.Text == "0")
            {
                if (txtvalue.Text == "0")

                    txtvalue.Text = "7";
            }

            else
            {
                txtvalue.Text += "7";
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (txtvalue.Text == "0")
            {
                if (txtvalue.Text == "0")

                    txtvalue.Text = "8";
            }

            else
            {
                txtvalue.Text += "8";
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (txtvalue.Text == "0")
            {
                if (txtvalue.Text == "0")

                    txtvalue.Text = "9";
            }

            else
            {
                txtvalue.Text += "9";
            }
        }

        private void Btn_plus_minus_Click(object sender, EventArgs e)
        {
            if (txtvalue.Text.Contains("-"))
            {
                txtvalue.Text = txtvalue.Text.Trim('-');
            }
            else
            {
                txtvalue.Text = "-" + txtvalue.Text;

            }
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            _value = double.Parse(txtvalue.Text);
            txtvalue.Clear();
            opreaters = "+";
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            _value = double.Parse(txtvalue.Text);
            txtvalue.Clear();
            opreaters = "-";
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            _value = double.Parse(txtvalue.Text);
            txtvalue.Clear();
            opreaters = "*";
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            _value = double.Parse(txtvalue.Text);
            txtvalue.Clear();
            opreaters = "/";
        }

        private void btn_underoot_Click(object sender, EventArgs e)
        {
            _value = double.Parse(txtvalue.Text);
            txtvalue.Clear();
            opreaters = "√ ";
        }

        private void btn_Pie_Click(object sender, EventArgs e)
        {
            _value = double.Parse(txtvalue.Text);
            txtvalue.Clear();
            opreaters = "pie";
        }

        private void btn_square_Click(object sender, EventArgs e)
        {
            _value = double.Parse(txtvalue.Text);
            txtvalue.Clear();
            opreaters = "sin";
        }

        private void btn_factorial_Click(object sender, EventArgs e)
        {
            _value = double.Parse(txtvalue.Text);
            txtvalue.Clear();
            opreaters = "cos";
        }

        private void btn_cube_Click(object sender, EventArgs e)
        {
            _value = double.Parse(txtvalue.Text);
            txtvalue.Clear();
            opreaters = "cube";
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            switch (opreaters)
            {
                case "+":

                    _value2 = double.Parse(txtvalue.Text);
                    Total = _value + _value2;
                    txtvalue.Text = Total.ToString();

                    break;
                case "-":
                    _value2 = double.Parse(txtvalue.Text);
                    Total = _value - _value2;
                    txtvalue.Text = Total.ToString();

                    break;
                case "/":
                    _value2 = double.Parse(txtvalue.Text);
                    Total = _value / _value2;
                    txtvalue.Text = Total.ToString();
                    break;
                case "*":
                    _value2 = double.Parse(txtvalue.Text);
                    Total = _value * _value2;
                    txtvalue.Text = Total.ToString();
                    break;
                case "√ ":
                    Total = Math.Sqrt(_value);
                    txtvalue.Text = Total.ToString();
                    break;
                case "pie":
                    Total = _value * 3.14159;
                    txtvalue.Text = Total.ToString();
                    break;
                case "square":

                    Total = _value * _value;
                    txtvalue.Text = Total.ToString();

                    break;
                case "cube":
                    Total = _value * _value * _value;
                    txtvalue.Text = Total.ToString();

                    break;
                case "sin":
                    Total = Math.Sin(_value);
                    txtvalue.Text = Total.ToString();
                    break;
                case "cos":
                    Total = Math.Cos(_value);
                    txtvalue.Text = Total.ToString();
                    break;

            }
        }

        private void btn_inverse_Click(object sender, EventArgs e)
        {
            _value = double.Parse(txtvalue.Text);
            txtvalue.Clear();
            opreaters = "square";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtvalue.Clear();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
