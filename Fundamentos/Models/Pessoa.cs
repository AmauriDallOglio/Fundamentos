namespace Fundamentos.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Altura { get; set; }


        public void Apresentar(Pessoa pessoa) //Método de apresentação
        {
            DateTime dateTime= DateTime.Now;

            Console.WriteLine($"{dateTime} Olá meu nome {pessoa.Nome} , e tenho {pessoa.Idade} anos e tenho { pessoa.Altura} de altura");
        }

 
        public Pessoa CarregaDados(string nome, int idade, double altura)
        {
            if (nome == null)
                Console.WriteLine("Nome não foi informado");

            if (idade == 0)
                Console.WriteLine("Idade não foi informado");

            Pessoa pessoa = new Pessoa();
            pessoa.Nome = nome;
            pessoa.Idade = idade;
            pessoa.Altura = altura;

            return pessoa;
        }
    }
}
