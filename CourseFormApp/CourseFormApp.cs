using CourseFormApp.Exceptions;
using System.Diagnostics;

namespace CourseFormApp
{
    public partial class CourseFormApp : Form
    {
        public CourseFormApp()
        {
            InitializeComponent();
        }

        private void DoNotButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do not click...");
            var throwExceptionExample = new ThrowExceptionExample();
            try
            {
                throwExceptionExample.Run();
                MessageBox.Show("You are a rebel!");
            }
            catch(OurOwnException ex)
            {
                LogsTextBox.Text += ex.Message + "\r\n";
                LogsTextBox.Text += ex.StackTrace + "\r\n";
            }
            catch(Exception ex)
            {
                LogsTextBox.Text += ex.Message + "\r\n";
                LogsTextBox.Text += ex.StackTrace + "\r\n";
            }
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShoutDown_Click(object sender, EventArgs e)
        {
            //Process.Start("shutdown", "/s /t 0"); //wy³¹czy komputer
            throw new OurOwnException("Do not click this button!");
            Process.Start("shutdown", "/s /t 0");
        }

        private void HaightButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"Your hight is: {HeightTextBox.Text} cm.");
            MessageBox.Show($"Your height is {HeightTextBox.Text} cm!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //MessageBox.Show($"Your height is {textBox1.Text} cm!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                var xNumber = Convert.ToDouble(XnumberBox.Text);
                var yNumber = Convert.ToDouble(YnumberBox.Text);
                ResultTextBox.Text = PerformOperation(xNumber, yNumber).ToString();
                LogsTextBox.Text += "\n Operation performed successfully!\r\n";

            }
            catch(FormatException ex)
            {
                var exceptionMessage = "\nFormat Exception caught!\r\n";
                LogsTextBox.Text += exceptionMessage;
                LogsTextBox.Text += ex.Message;
                LogsTextBox.Text += ex.StackTrace;
            }
            catch(Exception ex)
            {
                //MessageBox.Show("Exception caught!");
                var exceptionMessage = "\nException caught!\r\n";
                LogsTextBox.Text += exceptionMessage;
                LogsTextBox.Text += ex.Message;
                LogsTextBox.Text += ex.StackTrace;
                LogsTextBox.Text += ex.Source;

                ResultTextBox.Text = "Invalid operation!";
            }
            finally
            {
                //MessageBox.Show("Operation Performed...");
                LogsTextBox.Text += "\n Operation Performed..\r\n";
            }
        }

        private double PerformOperation(double x, double y)
        {
            if (AddRadioButton.Checked)
                return x + y;
            else if (SubstractRadioButton.Checked)
                return x - y;
            else if (MultiplyRadioButton.Checked)
                return x * y;
            else
               return x / y;
        }
    }
}