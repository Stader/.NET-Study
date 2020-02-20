using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDoBruno.titular = "Bruno";
            contaDaGabriela.titular = "Gabriela";

            contaDoBruno.Depositar(300);

            bool resultado = contaDoBruno.Sacar(50);

            if (resultado)
                Console.WriteLine("O saque foi um sucesso");
            else
                Console.WriteLine("O saque não é permitido");

            resultado = contaDoBruno.Transferir(200, contaDaGabriela);

            if (resultado)
                Console.WriteLine("A transferência foi um sucesso");
            else
                Console.WriteLine("A transferência não é permitido");
            Console.ReadLine();
        }
    }
}
