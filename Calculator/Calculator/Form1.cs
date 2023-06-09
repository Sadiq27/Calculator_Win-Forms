namespace Calculator
{
    public partial class Form1 : Form
    {
        double result = 0;
        string operation = "";
        bool isOperationComplited = false;
            
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {

            if ((this.textBox_Result.Text == "0") || (isOperationComplited))
                this.textBox_Result.Clear();

            isOperationComplited = false;
            Button clickedButton = (Button)sender;

            if (clickedButton.Text == ",")
            {
                if (!this.textBox_Result.Text.Contains(","))
                    this.textBox_Result.Text += clickedButton.Text;
            }
            else
            {
                this.textBox_Result.Text += clickedButton.Text;
            }
        }

        private void operation_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (result != 0)
            {
                button_equal.PerformClick();
                operation = clickedButton.Text;

                history_label.Text = result + " " + operation;
                isOperationComplited = true;

            }
            else
            {
                operation = clickedButton.Text;
                result = double.Parse(this.textBox_Result.Text);
                history_label.Text = result + " " + operation;
                isOperationComplited = true;
            }
            
        }

        private void button_CE_Click(object sender, EventArgs e)
        {
            this.textBox_Result.Text = "0";
            this.history_label.Text = "";
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            this.textBox_Result.Text = "0";
            result = 0;
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            switch (operation) 
            {
                case "+":
                    textBox_Result.Text = (result + double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (result - double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (result * double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (result / double.Parse(textBox_Result.Text)).ToString();
                    break;

                default:
                    break;
            }

            result = double.Parse(this.textBox_Result.Text);
            history_label.Text = " ";
        }

    }
}