Console.WriteLine("Cálculo de IMC");

//Entrada de dados
Console.WriteLine("Qual o seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine($"Olá {nome} seja muito bem vindo");

Console.WriteLine("Qual a sua altura: ");
double altura = double.Parse(Console.ReadLine());

Console.WriteLine("Qual o seu peso: ");
double peso = double.Parse(Console.ReadLine());

//Processamento
double IMC = peso / (altura * altura);

//Saída de dados
Console.WriteLine($"{nome} o seu IMC é de {double.Round(IMC), 2}");

// Testa para saber se o IMC está acima de 35
if(IMC > 35)
{
    Console.WriteLine("Seu IMC não está em um valor adequado procure um nutricionista!");
}
else
{
    Console.WriteLine("Seu IMC está em um valor adequado, parabéns e se mantenha saudável");
}