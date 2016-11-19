using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heranca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            Conta conta = new ContaPoupanca();
            conta.Depositar(1000);
            conta.Sacar(100);
            MessageBox.Show("Poupança:\n"+"Foi feito um depósito de $1000 foi sacado $100 o saldo é $"+conta.Saldo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta conta = new ContaCorrente();
            conta.Depositar(1000);
            conta.Sacar(100);
            MessageBox.Show("Corrente:\n" + "Foi feito um depósito de $1000 foi sacado $100 o saldo é $" + conta.Saldo);
        }
    }
}
