using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SequenciaFibonacci
{
    public partial class CalculoFibonacci : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVerificar_Click(object sender, EventArgs e)
        {
            // Obtém o número informado pelo usuário
            int numeroInformado = Convert.ToInt32(txtNumero.Text);

            // Verifica se o número pertence à sequência de Fibonacci
            bool pertence = VerificarSePertenceFibonacci(numeroInformado);

            // Exibe a mensagem correspondente
            if (pertence)
            {
                lblResultado.Text = $"{numeroInformado} pertence à sequência de Fibonacci.";
            }
            else
            {
                lblResultado.Text = $"{numeroInformado} não pertence à sequência de Fibonacci.";
            }
        }

        private bool VerificarSePertenceFibonacci(int numero)
        {
            // Inicia os dois primeiros valores da sequência de Fibonacci
            int a = 0, b = 1;

            // Caso especial para o número 0
            if (numero == 0)
            {
                return true;
            }

            // Calcula a sequência de Fibonacci até ultrapassar o número informado
            while (b < numero)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            // Verifica se o número informado está na sequência
            return b == numero;
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = ""; //limpa a txtNumero
            lblResultado.Text = ""; //limpa a lblResultado
        }
    }
}