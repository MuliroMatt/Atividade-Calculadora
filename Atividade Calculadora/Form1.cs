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
            valor1 = double.Parse(txt1.Text);
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            valor2 = double.Parse(txt2.Text);
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            lblOper.Text = "+";
        }
        private void btnMenos_Click(object sender, EventArgs e)
        {
            lblOper.Text = "-";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            lblOper.Text = "X";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            lblOper.Text = "/";
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {   if(txt1 == null || txt2 == null)
            {
                lblResultado.Text = "PREENCHA OS CAMPOS!";
            }
            else
            {
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
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            lblResultado.Text = "";
        }
    }
}