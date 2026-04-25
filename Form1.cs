    namespace LabAssignment07
    {
        public partial class Form1 : Form
        {
            private double firstNumber = 0;
            private double secondNumber = 0;
            private string operation = "";
            private bool isOperationPressed = false;
            private bool isDecimalAdded = false;

            public Form1()
            {
                InitializeComponent();
            }

            // Keyboard support handler
            protected override void OnKeyDown(KeyEventArgs e)
            {
                base.OnKeyDown(e);
                
                // Map physical keys to calculator functions
                switch (e.KeyCode)
                {
                    case Keys.NumPad0: case Keys.D0: button14.PerformClick(); break;
                    case Keys.NumPad1: case Keys.D1: button1.PerformClick(); break;
                    case Keys.NumPad2: case Keys.D2: button2.PerformClick(); break;
                    case Keys.NumPad3: case Keys.D3: button3.PerformClick(); break;
                    case Keys.NumPad4: case Keys.D4: button4.PerformClick(); break;
                    case Keys.NumPad5: case Keys.D5: button5.PerformClick(); break;
                    case Keys.NumPad6: case Keys.D6: button6.PerformClick(); break;
                    case Keys.NumPad7: case Keys.D7: button7.PerformClick(); break;
                    case Keys.NumPad8: case Keys.D8: button8.PerformClick(); break;
                    case Keys.NumPad9: case Keys.D9: button9.PerformClick(); break;
                    
                    case Keys.Add: button10.PerformClick(); break;
                    case Keys.Subtract: button11.PerformClick(); break;
                    case Keys.Divide: button12.PerformClick(); break;
                    case Keys.Multiply: button13.PerformClick(); break;
                    
                    case Keys.Decimal: 
                    case Keys.OemPeriod: buttonDecimal.PerformClick(); break;
                    
                    case Keys.Enter: button15.PerformClick(); break;
                    
                    case Keys.Back: buttonDelete.PerformClick(); break;
                    case Keys.Escape: buttonClear.PerformClick(); break;
                    
                    case Keys.OemMinus: button11.PerformClick(); break;
                    case Keys.Oemplus: if(e.Shift) button10.PerformClick(); break;
                }
                e.Handled = true;
            }

            // Helper method to add number to display
            private void AddNumber(string number)
            {
                if (isOperationPressed)
                {
                    textBox1.Text = number;
                    isOperationPressed = false;
                }
                else
                {
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = number;
                    }
                    else
                    {
                        textBox1.Text += number;
                    }
                }
            }

            // Number button handlers
            private void button1_Click(object sender, EventArgs e)
            {
                AddNumber("1");
            }

            private void button2_Click(object sender, EventArgs e)
            {
                AddNumber("2");
            }

            private void button3_Click(object sender, EventArgs e)
            {
                AddNumber("3");
            }

            private void button4_Click(object sender, EventArgs e)
            {
                AddNumber("4");
            }

            private void button5_Click(object sender, EventArgs e)
            {
                AddNumber("5");
            }

            private void button6_Click(object sender, EventArgs e)
            {
                AddNumber("6");
            }

            private void button7_Click(object sender, EventArgs e)
            {
                AddNumber("7");
            }

            private void button8_Click(object sender, EventArgs e)
            {
                AddNumber("8");
            }

            private void button9_Click(object sender, EventArgs e)
            {
                AddNumber("9");
            }

            private void button14_Click(object sender, EventArgs e) // 0 button
            {
                AddNumber("0");
            }

            // Operator button handlers
            private void button10_Click(object sender, EventArgs e) // + button
            {
                HandleOperator("+");
            }

            private void button11_Click(object sender, EventArgs e) // - button
            {
                HandleOperator("-");
            }

            private void button12_Click(object sender, EventArgs e) // / button
            {
                HandleOperator("/");
            }

            private void button13_Click(object sender, EventArgs e) // * button
            {
                HandleOperator("*");
            }

            private void HandleOperator(string op)
            {
                if (double.TryParse(textBox1.Text, out double currentValue))
                {
                    if (!isOperationPressed && operation != "")
                    {
                        // Perform the previous operation
                        secondNumber = currentValue;
                        double result = Calculate(firstNumber, secondNumber, operation);
                        textBox1.Text = result.ToString();
                        firstNumber = result;
                    }
                    else
                    {
                        firstNumber = currentValue;
                    }

                    operation = op;
                    isOperationPressed = true;
                    isDecimalAdded = false;
                }
            }

            // Equals button handler
            private void button15_Click(object sender, EventArgs e)
            {
                if (double.TryParse(textBox1.Text, out double currentValue) && operation != "")
                {
                    secondNumber = currentValue;
                    double result = Calculate(firstNumber, secondNumber, operation);
                    textBox1.Text = result.ToString();
                    operation = "";
                    isOperationPressed = true;
                    isDecimalAdded = false;
                }
            }

            // Decimal point handler
            private void buttonDecimal_Click(object sender, EventArgs e)
            {
                if (!isDecimalAdded)
                {
                    if (isOperationPressed)
                    {
                        textBox1.Text = "0.";
                        isOperationPressed = false;
                    }
                    else
                    {
                        textBox1.Text += ".";
                    }
                    isDecimalAdded = true;
                }
            }

            // Clear button handler
            private void buttonClear_Click(object sender, EventArgs e)
            {
                textBox1.Text = "0";
                firstNumber = 0;
                secondNumber = 0;
                operation = "";
                isOperationPressed = false;
                isDecimalAdded = false;
            }

            // Delete button handler (backspace)
            private void buttonDelete_Click(object sender, EventArgs e)
            {
                if (textBox1.Text.Length > 1)
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                    isDecimalAdded = textBox1.Text.Contains(".");
                }
                else
                {
                    textBox1.Text = "0";
                    isDecimalAdded = false;
                }
            }

            // Calculate function
            private double Calculate(double num1, double num2, string op)
            {
                switch (op)
                {
                    case "+":
                        return num1 + num2;
                    case "-":
                        return num1 - num2;
                    case "*":
                        return num1 * num2;
                    case "/":
                        if (num2 != 0)
                        {
                            return num1 / num2;
                        }
                        else
                        {
                            MessageBox.Show("Cannot divide by zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox1.Text = "0";
                            firstNumber = 0;
                            operation = "";
                            isOperationPressed = false;
                            isDecimalAdded = false;
                            return 0;
                        }
                    default:
                        return num2;
                }
            }
        }
    }
