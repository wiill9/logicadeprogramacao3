//escreva um programa que solicite o primeiro nome do usuário em seguida solicite o sobrenome do usuário. O programa deve apresentar uma mensagem de boas vindas e o nome completo 

Console.WriteLine("Escreva seu primeiro nome");
string name = Console.ReadLine();

Console.WriteLine("Escreva seu sobrenome");
string sobrenome = Console.ReadLine();  


Console.WriteLine("Seja bem-vindo (a) " + name  + sobrenome);