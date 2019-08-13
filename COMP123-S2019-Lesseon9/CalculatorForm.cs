using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesseon9
{
    public partial class CalculatorForm : Form
    {
        /// <summary>
        /// This is the constructor for the CalculatorForm
        /// </summary>
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// This is a shared event handler for the CalculatorButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            var TheButton = sender as Button;

            int ButtoneValue;
            bool Result = int.TryParse(TheButton.Text, out ButtoneValue);

            if (Result)
            {
                ResultLabel.Text = TheButton.Text;
            }
            else
            {
                ResultLabel.Text = "Not a Number (NAN)";
            }
            
        }
    }
}
