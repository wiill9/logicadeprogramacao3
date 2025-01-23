//escreva um programa que solicita a um usuário a quantidade em litros abastecidos em um automóvel. Em seguida o programa deve solicitar que o usuário informar a quantidade de quilômetros percorridos até o término do tanque. O programa deve exibir a quantidade de quilômetros por litro.

Console.WriteLine("Digite a quantidade de litros abastecidos");
int litrosabastecidos = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade de quilômetros percorridos");
    int quilômetros = int.Parse(Console.ReadLine());    



int totalKmPorLitro = quilômetros / litrosabastecidos;
Console.WriteLine("você fez " + totalKmPorLitro + " quilometros por litro");
