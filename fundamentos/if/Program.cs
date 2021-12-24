// See https://aka.ms/new-console-template for more information

// var a = 3;
// var b = 2;
// var ativo = true;
// if (a > b && ativo == true)
// {
//     Console.WriteLine("Verdadeira");
//     Console.WriteLine("É maior");
// }
// Console.WriteLine("Final");

var idade = 16;
var nota = 7;
if (idade >= 18)
{
    Console.WriteLine("Maior de idade");
    Console.WriteLine("Cadastro autorizado");
}
else if(idade >= 16 && idade < 18)
{
    Console.WriteLine("Menor de idade (> 16 anos)");
    Console.WriteLine("Cadastro autoriado com responsáveis");
}
else
{
    Console.WriteLine("Menor de idade");
    Console.WriteLine("Cadastro não autorizado");
}

if (nota > 7)
{
    Console.WriteLine("aprovado");
}
else
{
    Console.WriteLine("reprovado");
}
Console.WriteLine("Finalizado");

/* Operador ternário */

var mensagem = "";
var nota1 = 9;
// if (nota > 7)
//     mensagem = "Aprovado";
// else
//     mensagem = "Reprovado";

mensagem = idade >= 18 ? "Maior de idade" : "Menor de idade";
mensagem = nota > 7 ? "Aprovado" : "Reprovado";

    Console.WriteLine(mensagem);
