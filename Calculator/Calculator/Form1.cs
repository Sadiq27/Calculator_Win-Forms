using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using System.Text.Json;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double result = 0;
        string operation = "";
        bool isOperationComplited = false;

        private Logs logs = new Logs();

        public Form1()
        {
            InitializeComponent();

            if (this.logs.ToString() != String.Empty)
            {
                if (File.Exists(this.logs.logsPath))
                    LoadLogs();
            }
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

                history_label.Text = $"{result} {operation}";
                isOperationComplited = true;

            }
            else
            {
                operation = clickedButton.Text;
                result = double.Parse(this.textBox_Result.Text);
                history_label.Text = $"{result} {operation}";

                isOperationComplited = true;
            }
            
        }

        private void AddHistory(string message)
        {
            History newLog = new History(message);

            this.HistoryListBox.Items.Add(newLog);
            logs.SaveToFile(newLog);
        }

        private void LoadLogs()
        {
            string json = File.ReadAllText(this.logs.logsPath);

            if (!string.IsNullOrEmpty(json))
            {
                this.logs.logs = JsonSerializer.Deserialize<List<History>>(json);

                foreach (var log in this.logs.logs)
                    this.HistoryListBox.Items.Add(log);
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
            string before = this.textBox_Result.Text;
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
            string historyText = $"{result} {operation} {before} = {this.textBox_Result.Text}";

            result = double.Parse(this.textBox_Result.Text);
            history_label.Text = " ";
            AddHistory(historyText);
        }

    }
}