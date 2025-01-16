// Exercício 8: Crie um programa que solicite ao usuário um número e imprima todos os números de 1 até o número informado usando um laço `while`.

Console.WriteLine("Digite um número");
// solicitar um número ao usuário 
int numero = int.Parse(Console.ReadLine());
int contador = 10;


// usar do - while para imprimir de até 10 o número informado (decrementando de 2 em 2)
do
{
    Console.WriteLine(contador);
    contador -= 2; // decrementa o contador em 2 
}
while (contador >= numero);
{

}