using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.Titular.Nome = "gabriela";
            conta.Titular.CPF = "158.369.312-24";
            conta.Titular.Profissao = "Desenvolvedora";
            conta.Saldo = 520;
            conta.Agencia = 563;
            conta.Numero = 5634527;
        }
    }
}
