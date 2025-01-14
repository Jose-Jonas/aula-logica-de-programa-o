// Tipos de dados

string nome = "Jonas";
Console.WriteLine("O nome do usuário é: " + nome);

int idade = 21;
// Console.WriteLine(O nome do usuário é "+ idade" + "anos");
Console.WriteLine($"A idade do usuário é: {idade} anos");

float carteira = 2.63f;

char  classificacao = 'A';
Console.WriteLine($"O cliente é dp tipo {classificacao}");

bool dinheiroNaConta = true;
Console.WriteLine(dinheiroNaConta);

double limitecredito = 2000.0;
Console.WriteLine("Seu limete de crédito é: " + limitecredito);

string sobrenome = "Araújo";

string nomeCompleto  = nome + sobrenome;
Console.WriteLine(nomeCompleto);

double valorConta = 53.73;
Console.WriteLine ($"O valor na conta é { valorConta}");

double limireTotal = valorConta + limitecredito;
Console.WriteLine($"O saldo + limite é {limireTotal}");
