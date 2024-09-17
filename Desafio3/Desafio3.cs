using System;
using System.Collections.Generic;
using System.ComponentModel;

class Program
{
    static List<string> senhas = new List<string>();


    
    static void Main(string[] args)
    {
        Console.WriteLine("digite a Senha");
        string senhaDigitada1 = Console.ReadLine();
       Console.WriteLine("Digite novamente");
        string senhaDigitada2 = Console.ReadLine();

        

    if (senhaDigitada1 == senhaDigitada2)
    {
    Console.WriteLine("Tudo Certo! senha cadastrada");
     CadastrarSenha(senhaDigitada1);
    }
    else
     {
    Console.WriteLine(" senha não corresponde");
     }
        CadastrarSenha("123456");
        CadastrarSenha("senhaSegura");

        // Console.WriteLine("Digite a senha para validar: ");
        

        // if (ValidarSenha(senhaDigitada1))
        // {
        //     Console.WriteLine("Acesso permitido!");
        // }
        // else
        // {
        //     Console.WriteLine("Acesso negado!");
        // }
    }





    static void CadastrarSenha(string senha)
    {
        senhas.Add(senha);
    }

    static bool ValidarSenha(string senha)
    {
        return senhas.Contains(senha);
    }
}