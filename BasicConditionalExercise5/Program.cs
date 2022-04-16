// 21) Faça um algoritmo que leia um determinado ano e mostre se ele é ou não BISSEXTO.

Console.WriteLine("Digite o ano e saiba se ele é bissexto ou não:");
int year = int.Parse(Console.ReadLine());

if (year % 4 == 0 && year % 100 == 0 && year % 400 == 0)
{
    Console.WriteLine($"O ano de {year} é BISSEXTO e tem 366 dias");

}
else if (year % 4 == 0 && year % 100 != 0)
{
    Console.WriteLine($"O ano de {year} é BISSEXTO e tem 366 dias");
}
else
{
    Console.WriteLine($"O ano de {year} não é BISSEXTO e tem 365 dias");
}