﻿// Se o total de quilômetros por litro for maior que 9 exibir a mensagem "carro econômico", se o consumo médio entre 6, 5 e 9 exibir a mensagem: "Carro com consumo mediano", abaixo de 6,5 exibir a mensagem: "Carro com consumo alto". Você não deve apagar nenhuma linha escrita até então. Exceto se for para melhorar o exercicio 

Console.WriteLine("Quantidade em litros abastecidos");
int litrosAbastecidos = int.Parse(Console.ReadLine());

Console.WriteLine("Quantidade de quilômetros percorridos");
int quilometros = int.Parse(Console.ReadLine());

int totalKmPorLitro = quilometros / litrosAbastecidos;
Console.WriteLine("você fez " + totalKmPorLitro + " quilometros por litro");


if (totalKmPorLitro <=6.5)
{
    Console.WriteLine($"consumo elevado: {totalKmPorLitro} ");

}
