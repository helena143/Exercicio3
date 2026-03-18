using Exercicio3;

Banco santanderBank = new Banco();
int opcao = 0;

while (opcao != 7)
{
    Console.WriteLine("===== BANCO SANTANDER =====");
    Console.WriteLine("1 - criar conta");
    Console.WriteLine("2 - depositar");
    Console.WriteLine("3 - sacar");
    Console.WriteLine("4 - transferir");
    Console.WriteLine("5 - listar contas");
    Console.WriteLine("6 - remover conta");
    Console.WriteLine("7 - sair");
    Console.Write("Escolha: ");

    opcao = int.Parse(Console.ReadLine());
    Console.WriteLine();
    switch (opcao)
    {
        case 1:
            Console.WriteLine("Numero da conta: ");
            string numero = Console.ReadLine();
            Console.WriteLine("Titular: ");
            string titular = Console.ReadLine();

            santanderBank.CriarConta(numero, titular);
            Console.WriteLine("Conta criada com sucesso!");
            break;
        case 2:
            Console.WriteLine("Numero da conta: ");
            numero = Console.ReadLine();
            Conta contaDeposito = santanderBank.BuscarConta(numero);

            if (contaDeposito != null)
            {
                Console.WriteLine("Valor: ");
                double valor = double.Parse(Console.ReadLine());
                contaDeposito.Depositar(valor);
                Console.WriteLine("Deposito realizado!");
            }
            else
            {
                Console.WriteLine("Conta nao encontrada!");
            }
            break;
        case 3:
            Console.WriteLine("Numero da conta: ");
            numero = Console.ReadLine();
            Conta contaSacar = santanderBank.BuscarConta(numero);


            if (contaSacar != null)
            {
                Console.WriteLine("Valor: ");
                double valor = double.Parse(Console.ReadLine());
                contaSacar.Sacar(valor);
                Console.WriteLine("Saque realizado!");
            }
            else
            {
                Console.WriteLine("Conta nao encontrada!");
            }
            break;

        case 4:
            Console.WriteLine("Conta origem: ");
            string origem = Console.ReadLine();

            Console.WriteLine("Conta destino: ");
            string destino = Console.ReadLine();

            Console.WriteLine("Valor: ");
            double valorTransferencia = double.Parse(Console.ReadLine());

            santanderBank.Transferir(origem, destino, valorTransferencia);

            break;
        case 5:
            santanderBank.ListarContas();
            Console.WriteLine();
            break;

        case 6:
            Console.WriteLine("Numero da conta que deseja remover: ");
            string numeroRemover = Console.ReadLine();

            Conta contaRemover = santanderBank.BuscarConta(numeroRemover);

            if (contaRemover != null)
            {
                santanderBank.RemoverConta(numeroRemover);
            }
            else
            {
                Console.WriteLine("Conta não encontrada :(");
            }

            break;





    }

}





