namespace Primeiro_projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nome;
            int idade;
            string cidade;



            Console.WriteLine("Qual seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine("Olá, {0}, qual sua idade?", nome);
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Então seu nome é {0}, e você tem {1} anos, de qual cidade você é?", nome, idade);
            cidade = Console.ReadLine();
            Console.WriteLine("Entendi! \n Nome: {0} \n Idade: {1} \n Cidade: {2}", nome, idade, cidade);


            int nmr1;
            int nmr2;
            int soma;
            int mult;
            int div;
            int sub;




            Console.WriteLine("Escolha um número");
            nmr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escolha outro número, divisivel com o primeiro");
            nmr2 = int.Parse(Console.ReadLine());
            soma = nmr1 + nmr2;
            mult = nmr1 * nmr2;
            div = nmr1 / nmr2;
            sub = nmr1 - nmr2;
            Console.WriteLine("soma: {0} \n multiplicação: {1} \n divisão: {2} \n subtração: {3}", soma, mult, div, sub);

        }
    }
}
