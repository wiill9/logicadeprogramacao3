// Calcular que recebe 2 numeros e apresenta + - * /

Console.WriteLine("informe o 1° número"); 
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("informe o 1° número");
double num2 = double.Parse(Console.ReadLine());

Console.Clear();
Console.WriteLine("+ : " + (num1 + num2));  
Console.WriteLine("- : "  + (num1 - num2)); 
Console.WriteLine("* : " + (num1 * num2 / num2));   

if (num2 != 0)
Console.WriteLine("/ : " + (num1 / num2 )); 


else
{
    Console.WriteLine("Divisão por ZERO não permitida");
}