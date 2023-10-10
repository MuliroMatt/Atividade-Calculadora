namespace Atividade_Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            lblOper.Text = "+";
        }
    }
}