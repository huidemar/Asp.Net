using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class ContaPoupanca : Conta
    {
        public override void Sacar(double valor)
        {
            this.Saldo -= valor - 0.1; // quando o saque é de conta poupança cobra 0.1 por operação
        }
    }
}
