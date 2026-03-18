using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Banco
    {
        public List<Conta> Contas = new List<Conta>();

        public void CriarConta(String numero, String titular)
        {
            Conta novaConta = new Conta();
            novaConta.Titular = titular;
            novaConta.Numero = numero;

            Contas.Add(novaConta); //Adicionando nova conta a lista de contas
        }
        public void ListarContas()
        {
            if (Contas.Count == 0)

            {
                Console.WriteLine("Nenhuma conta cadastrada.");
                Console.WriteLine("------------------------");
            }
            else
            {
                foreach (Conta conta in Contas)
                {
                    conta.mostrarDados();
                }

            }
        }

        public Conta BuscarConta(string numero)
        {
            return Contas.Find(c => c.Numero == numero);
        }

        public void Transferir(String origem, String destino, double valor)
        {
            Conta contaOrigem = BuscarConta(origem);
            Conta contaDestino = BuscarConta(destino);
            if (contaOrigem != null && contaDestino != null)
            {
                if (contaOrigem.Sacar(valor))
                {
                    contaDestino.Depositar(valor);
                    Console.WriteLine("Transferencia realizada!");
                }
                else
                {
                    Console.WriteLine("Transferencia cancelada.");
                }
            }
        }

        public void RemoverConta(string numero)
        {
            Conta conta = BuscarConta(numero);

            if (conta != null)
            {
                Contas.Remove(conta);  // remove da lista
                Console.WriteLine("Conta removida com sucesso!");
            }
            else
            {
                Console.WriteLine("Conta não encontrada :(");
            }
        }
    }

}



//biblioteca