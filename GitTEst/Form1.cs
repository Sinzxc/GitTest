using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitTEst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static double SafeDivision(double x, double y)
        {
            if (y == 0)
                throw new DivideByZeroException();
            return x / y;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double a = 98, b = 0;
            double result;
            int [] A = new int[5];
            try
            {
                result = SafeDivision(a, b);
                Console.WriteLine("{0} divided by {1} = {2}", a, b, result);
                A[6] = 1;
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Attempted divide by zero.");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            MessageBox.Show(DateTime.Now.ToString());
        }
    }
}   
