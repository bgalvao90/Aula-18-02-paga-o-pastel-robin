Console.WriteLine("Robinho paga o pastel");

Console.WriteLine("Exercicio 02");

int a, b, c;
double r, s, d;

Console.WriteLine("Digite o número A:");
a = int.Parse(Console.ReadLine());


Console.WriteLine("Digite o número B:");
b = int.Parse(Console.ReadLine());


Console.WriteLine("Digite o número C:");
c = int.Parse(Console.ReadLine());

r = Math.Pow(a + b, 2);

s = Math.Pow(c + b, 2);

d = ((r + s) / 2);

Console.WriteLine(d);

Console.WriteLine("Exercicio 3");

double nota1, nota2, nota3, media;

Console.WriteLine("Digite as 3 notas de um aluno");

nota1 = int.Parse(Console.ReadLine());

nota2 = int.Parse(Console.ReadLine());

nota3 = int.Parse(Console.ReadLine());

media = (((nota1 * 2) + (nota2 * 3) + (nota3 * 5))/ 3);

Console.WriteLine(media);

Console.WriteLine("Exercicio 4");

int numero;

Console.WriteLine("Digite um número e descubra se é par ou impar");
numero = int.Parse(Console.ReadLine());


if (numero % 2 == 0)
{
    Console.WriteLine("Seu número é par");
}
else
{
    Console.WriteLine("Seu número é impar");
}