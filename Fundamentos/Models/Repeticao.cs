namespace Fundamentos.Models
{
    public class Repeticao
    {
        public void ContatorDoFor()
        {
            string contator = string.Empty;
            int tabuada = 5;
            for (int i = 0; i <= 10; i++)
            {
                contator += i.ToString() + ", ";
                Console.WriteLine($"FOR Numero {tabuada} * {i} = {tabuada * i}");
                Console.WriteLine($"FOR Lido: {contator}");
            }
        }


        public void ContatorWhile()
        {
            string contator = string.Empty;
            int tabuada = 5;
            int posicaoAtual = 0;
            while (posicaoAtual <= 10)
            {
                posicaoAtual++;
                contator += posicaoAtual.ToString() + ", ";
                Console.WriteLine($"While Numero {tabuada} * {posicaoAtual} = {tabuada * posicaoAtual}");
                Console.WriteLine($"While Lido: {contator}");
            }
        }


        public void ContadorDoWhile()
        {
            int soma = 0;
            int numero = 0;
            do
            {
                Console.WriteLine("Digite 0 para parar!");
                numero = Convert.ToInt32(Console.ReadLine());
                soma += numero;

            } while (numero != 0);
            Console.WriteLine($"O numero digitado é {numero} somando: {soma}");
        }


        public void Menu()
        {
            Console.WriteLine("Digite a sua opção:");
            Console.WriteLine("1 Cadastrar Cliente");
            Console.WriteLine("2 Busca Cliente");
            Console.WriteLine("3 Apaga Cliente");
            Console.WriteLine("4 Sair");
            Console.WriteLine("5 Fechar");

            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Cadastro de cliente");
                    break;
                case "2":
                    Console.WriteLine("Busca de cliente");
                    break;
                case "3":
                    Console.WriteLine("Apagar cliente");
                    break;
                case "4":
                    Console.WriteLine("Saindo do sistema");
                    break;
                case "5":
                    Console.WriteLine("Fechando o sistema");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}
