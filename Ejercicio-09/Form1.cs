namespace Ejercicio_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(txt1.Text);
            int number2 = int.Parse(txt2.Text);
            int number3 = int.Parse(txt3.Text);
            if ((number1 > number2) && (number1 > number3))
            {
                lblresult.Text = "El primero es mayor";
            }
            else if ((number2 > number1) && (number2 > number3))
            {
                lblresult.Text = "El segundo es mayor";
            }
            else if ((number3 > number1) && (number3 > number2))
            {
                lblresult.Text = "El tercero es mayor";
            }
        }
    }
}