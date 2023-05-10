using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumericMethodsLab1
{
    public partial class NumericMethods : Form
    {
        Methods method = new Methods();
        double a;
        double b;
        public NumericMethods()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            a = method.GetGap().Item1;
            b = method.GetGap().Item2;
            dichotomyAprior.Text = method.APrioriDichotomy(a, b).ToString();
            SI_aprior.Text = method.AprioriSI(0.5, 0.5).ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dichotomyAprior_Click(object sender, EventArgs e)
        {

        }

        private void dichotomy_checkbox_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                solDichotomy.Text = "Корінь:      х  = " + method.Dichotomy(a, b).ToString("0.00000");
                apost_dichotomy.Text = "Апостеріорна оцінка:      n  = " + method.Apost1;
            } catch(Exception ex)
            {
                errorProvider1.SetError(Owner, ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
            sol_newton.Text = "Корінь:      х  = " + method.MNewtonMethod(a, b).ToString("0.00000");
            apost_newton.Text = "Апостеріорна оцінка:      n  = " + method.Apost2;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(Owner, ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SI_sol.Text = "Корінь:      х  = " + method.SimpleIteration(a, b, 0.5).ToString("0.0000000000000000");
                SI_apost.Text = "Апостеріорна оцінка:      n  = " + method.Apost3;
                label3.Text = "q = " + method.qSI;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(Owner, ex.Message);
            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
    
}
