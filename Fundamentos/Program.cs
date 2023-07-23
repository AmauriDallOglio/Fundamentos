using Fundamentos.Models;


InicioDoProcesso();




//ListaArray listaArray = new ListaArray();
//listaArray.Array();
//listaArray.Lista();


//Repeticao repeticao = new Repeticao();
//repeticao.Menu();
////repeticao.ContadorDoWhile();
////repeticao.ContatorDoFor();
////repeticao.ContatorWhile();

//Calculo calculo = new Calculo();
//calculo.Calcular(12, 13);

//Pessoa pessoa = new Pessoa(); //istância de pessoa
//pessoa = pessoa.CarregaDados("Amauri",29, 1.77);
//pessoa.Apresentar(pessoa);

FimDoProcesso();

//Funções  _ -

//static Pessoa CarregaDados(Pessoa pessoa)
//{
//    pessoa.Nome = "Amauri";
//    pessoa.Idade = 29;
//    return pessoa;
//}

static void InicioDoProcesso()
{
    DateTime dateTime = DateTime.Now;
    Console.WriteLine("................... .............................");
    Console.WriteLine($"...................{dateTime}...................");
    Console.WriteLine(".................................................");
}

static void FimDoProcesso()
{
    DateTime dateTime = DateTime.Now;
    Console.WriteLine(".................................................");
    Console.WriteLine($"...................{dateTime}...................");
    Console.WriteLine(".................................................");
}