using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Calculadora {
    public partial class Calculadora : Form {
        public Calculadora() {
            InitializeComponent();
        }

        List<int> calculo = new List<int>();
        int numeroSalvo = 0;
        string operadorSalvo;
        private void salvaValorBotao( object sender , EventArgs e ) {
            Button valorBotao = (Button)sender;
            int numero;
            bool result = Int32.TryParse( valorBotao.Text , out numero );
            if( result ) {
                numeroSalvo = numeroSalvo * 10 + numero;
            } else {
                calcMethod( valorBotao.Text );
            }
        }
        private void calcMethod(string operador) {
            calculo.Add( numeroSalvo );
            numeroSalvo = 0;
            switch( operadorSalvo ) {
                case "/":
                    break;
                case "*":
                    break;
                case "+":
                    break;
                case "-":
                    break;
                default:
                    operadorSalvo = operador;
                    break;
            }
        }
            
    }
}
