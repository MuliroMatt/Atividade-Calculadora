namespace Atividade_Calculadora
{
    public partial class Calculadora : Form
    {
        //decimal num1, num2, mais, menos, mult, div, result;
        double valor1 = 0;
        double valor2 = 0;
        double resultado = 0;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            
        }
        private void btnMenos_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMais_Click_1(object sender, EventArgs e)
        {
            lblOper.Text = "+";
        }

        private void btnMenos_Click_1(object sender, EventArgs e)
        {
            lblOper.Text = "-";
        }

        private void btnMult_Click_1(object sender, EventArgs e)
        {
            lblOper.Text = "X";
        }

        private void btnDiv_Click_1(object sender, EventArgs e)
        {
            lblOper.Text = "/";
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            lblResultado.Text = "";
        }

        private void btnIgual_Click_1(object sender, EventArgs e)
        {
            try
            {
                valor1 = double.Parse(txt1.Text);
                valor2 = double.Parse(txt2.Text);

                switch (lblOper.Text)
                {
                    case "+":
                        resultado = valor1 + valor2;
                        lblResultado.Text = resultado.ToString();
                        break;
                    case "-":
                        resultado = valor1 - valor2;
                        lblResultado.Text = resultado.ToString();
                        break;
                    case "/":
                        resultado = valor1 / valor2;
                        lblResultado.Text = resultado.ToString();
                        if (valor2 == 0)
                        {
                            lblResultado.Text = "NÃO HÁ DIVISÃO POR 0!";
                        }
                        break;
                    case "X":
                        resultado = valor1 * valor2;
                        lblResultado.Text = resultado.ToString();
                        break;
                    default:
                        lblResultado.Text = "ESCOLHA UMA OPERAÇÃO!";
                        break;
                }
            }
            catch
            {
                lblResultado.Text = "PREENCHA OS CAMPOS";
            }
        }
    }
}