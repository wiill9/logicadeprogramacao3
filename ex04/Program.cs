// Tipos de dados 

string nome = "Wilder"; 
Console.WriteLine("O nome do usuário é: " + nome);

int idade = 18;
//Console.WriteLine("A idade do usuário é: " + idade + " anos ");
Console.WriteLine($"A idade do usuário é: {idade} anos");

float carteira = 2.63f;

char classificacao = 'A';
Console.WriteLine($"O cliente é do tipo {classificacao}");

bool dinheiroNaconta = true;
Console.WriteLine(dinheiroNaconta);

double limitecredito = 2000.0;
Console.WriteLine("Seu limite de crédito é: " + limitecredito);

string sobrenome = " Ribeiro";

string nomeCompleto = nome + sobrenome;
Console.WriteLine(nomeCompleto);

double valorconta = 53.73;
Console.WriteLine($"O valor na conta é: {valorconta}");

double limitetotal = valorconta + limitecredito;
Console.WriteLine($"O saldo + limite é: {limitetotal}");

