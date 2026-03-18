using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{


    class Conta
    {
        public string Numero;
        private double Saldo = 0;
        public String Titular;

        //Criar método mostrar dados.
        public void mostrarDados()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine("");
            Console.WriteLine("Titular: " + Titular);
            Console.WriteLine("Numero da Conta: " + Numero);
            Console.WriteLine("Saldo: R$" + Saldo);

        }

        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor invalido ou nulo!");
            }
            else
            {
                Saldo = Saldo + valor;
                Console.WriteLine("O valor R$ " + valor + " foi depositado corretamente.");
            }

        }

        public Boolean Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo = Saldo - valor;
                Console.WriteLine("O valor R$" + valor + " foi sacado corretamente.");
                return true;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente! ");
                return false;
            }
        }
    }
}
//livro
