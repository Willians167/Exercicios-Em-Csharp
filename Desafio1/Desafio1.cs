
using System;
class Desafio1
{
 public static void Main(string[] args)
{

      Console.Write("Digite sua idade: ");
      string entrada = Console.ReadLine();
      int idade;

        if (int.TryParse(entrada, out idade))
        {
            VerificaIdade(idade);
        }
        else
        {
            Console.WriteLine("Entrada invalida! Digite u numero");
        }
}

//     static void VerificaIdade(int idade)
// {
//     if (idade > 0 && idade < 18)
//     {
//         Console.WriteLine("Menor");
//     }
//     else if (idade >= 18 && idade < 65)
//     {
//         Console.WriteLine("Maior de idade");
//     }
//     else if (idade >= 65)
//     {
//         Console.WriteLine("Você é idoso");
//     }
//     else
//     {
//         Console.WriteLine("Idade inválida.");
//     }
// }




static void VerificaIdade(int idade)
{
    switch (idade)
    {
        case > 0 and < 18:
            Console.WriteLine("Menor de idade");
            break;
        case >= 18 and < 65:
            Console.WriteLine("Maior de idade");
            break;
        case >= 65:
            Console.WriteLine("Você é idoso");
            break;
        default:
            Console.WriteLine("Idade inválida.");
            break;
    }
}

}