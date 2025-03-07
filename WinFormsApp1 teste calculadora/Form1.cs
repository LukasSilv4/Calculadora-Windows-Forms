namespace WinFormsApp1_teste_calculadora
{
    public partial class Form1 : Form
    {
      
        private decimal Resultado { get; set; }
        private decimal Valor { get; set; }
        private Operacao OperacaoSelecionada { get; set; }
        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {

                textBox1.Text = "";
                return;
            }
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "";
            label1.Text = "+";

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
               
                textBox1.Text = "";
                return;
            }
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "";
            label1.Text = "-";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {

                textBox1.Text = "";
                return;
            }
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "";
            label1.Text = " X";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {

                textBox1.Text = "";
                return;
            }
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "";
            label1.Text = "/";
           

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";



        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            label1.Text = " ";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {

                textBox1.Text = "";
                return;
            }

            switch (OperacaoSelecionada)
            {
            
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(textBox1.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(textBox1.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(textBox1.Text);
                    break;
                case Operacao.Divisao:
                    if (Convert.ToDecimal(textBox1.Text) == 0)
                    {
                        textBox1.Text = "Não é Possível Dividir por Zero";
                        label1.Text = "";
                        return; 
                    }
                    Resultado = Valor / Convert.ToDecimal(textBox1.Text);
                    break;
            }
            
           
                    textBox1.Text = Convert.ToString(Resultado);
            label1.Text = "=";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
                textBox1.Text += " , ";

        }
    }



}
