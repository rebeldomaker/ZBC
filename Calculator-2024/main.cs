using System;
using System.Windows.Forms;

namespace GuiCalculator
{
    public partial class MainForm : Form
    {
        private TextBox num1TextBox;
        private TextBox num2TextBox;
        private ComboBox operationComboBox;
        private Button calculateButton;
        private Label resultLabel;

        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.num1TextBox = new TextBox();
            this.num2TextBox = new TextBox();
            this.operationComboBox = new ComboBox();
            this.calculateButton = new Button();
            this.resultLabel = new Label();

            // num1TextBox
            this.num1TextBox.Location = new System.Drawing.Point(12, 12);
            this.num1TextBox.Size = new System.Drawing.Size(100, 20);
            
            // num2TextBox
            this.num2TextBox.Location = new System.Drawing.Point(12, 40);
            this.num2TextBox.Size = new System.Drawing.Size(100, 20);
            
            // operationComboBox
            this.operationComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.operationComboBox.Items.AddRange(new object[] {"+", "-", "*", "/"});
            this.operationComboBox.Location = new System.Drawing.Point(118, 12);
            this.operationComboBox.Size = new System.Drawing.Size(121, 21);
            this.operationComboBox.SelectedIndex = 0;
            
            // calculateButton
            this.calculateButton.Location = new System.Drawing.Point(12, 66);
            this.calculateButton.Size = new System.Drawing.Size(227, 23);
            this.calculateButton.Text = "Beregn";
            this.calculateButton.Click += new EventHandler(this.calculateButton_Click);
            
            // resultLabel
            this.resultLabel.Location = new System.Drawing.Point(12, 92);
            this.resultLabel.Size = new System.Drawing.Size(227, 23);
            
            // MainForm
            this.ClientSize = new System.Drawing.Size(251, 124);
            this.Controls.Add(this.num1TextBox);
            this.Controls.Add(this.num2TextBox);
            this.Controls.Add(this.operationComboBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resultLabel);
            this.Text = "Simpel Regner";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(num1TextBox.Text);
                int num2 = int.Parse(num2TextBox.Text);
                string operation = operationComboBox.SelectedItem.ToString();
                int result = Calculate(num1, num2, operation);
                resultLabel.Text = "Resultat: " + result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fejl: " + ex.Message);
            }
        }

        private int Calculate(int num1, int num2, string operation)
        {
            switch (operation)
            {
                case "+": return num1 + num2;
                case "-": return num1 - num2;
                case "*": return num1 * num2;
                case "/":
                    if (num2 == 0)
                        throw new DivideByZeroException("Division med nul er ikke tilladt.");
                    return num1 / num2;
                default:
                    throw new InvalidOperationException("Ugyldig operation.");
            }
        }
    }
}
 
