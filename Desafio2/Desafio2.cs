class Desafio2{

public static void Main(string[] args)
{

Console.Write("Digite um numero: ");

    string entrada = Console.ReadLine();
    
    
    int numero;
if(int.TryParse(entrada, out numero))
{
VerificaNegativoPositivo(numero);
}else{
    Console.WriteLine("Entrada invalida! Digite u numero");
}
    

}


static void VerificaNegativoPositivo(int numero)
{
    switch (numero)
    {
        case > 0 :
            Console.WriteLine("Positivo");
            break;
       
        case < 0:
            Console.WriteLine("negativo");
            break;

            case  0:
            Console.WriteLine("Este é Zero");
            break;
        
        default:
           
            
    }
}


// static void VerificaNegativoPositivo(int numero)
// {
//     if (numero < 0 )
//     {
//         Console.WriteLine("Negativo");
//     }
//     else if (numero > 0 )
//     {
//         Console.WriteLine("positivo");
//     }
//     else if (numero == 0)
//     {
//         Console.WriteLine("ente é o numero 0");
//     }
//     else
//     {
//         Console.WriteLine("entrada  inválida.");
//     }
// }

}



    






   

