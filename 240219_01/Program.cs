using System;


// Trabalhando com variaveis C# 

//Strings
//Declarando variavel sem inicialização
string message1 = null;

//Inicializar a variavel com nulo
string message2 = null;

//Inicializar a string vazia
string message3 = System.String.Empty; // "";

// Declarar uma string com valor implicito
var message4 = "mensagem aleatoria";

Console.WriteLine( message4 );

// Concatenando Strings
string concat = (message1 == null ? "" : message1) + " " + message2 + " " + message3 + " " + message4; // if ternario, elegante

Console.WriteLine( "\n" + concat );


Console.WriteLine( 
    "A temperatura hoje {0:D} é {1}°C"
    , DateTime.Now
    , 23 
);


string nome = string.Empty;
Console.WriteLine( "Qual é o seu nome?");
nome = Console.ReadLine();
string resultado = $"Oi, {nome}! Pare de Jaguarice!";
Console.WriteLine(resultado);

// novo comentario 04/03/2024 //

// Substituindo conteudo de string

string nomeCompleto = "Luiz Henrique Gazziotin de Oliveira";
nomeCompleto = nomeCompleto.Replace("Henrique", "Sabido");
Console.WriteLine(nomeCompleto);

// Comparação de Strings

bool isNomeEqual = (nomeCompleto == "Luiz Henrique Gazziotin de Oliveira");

bool isNomeEqual2 = string.Equals(nomeCompleto, "Luiz Henrique Gazziotin de Oliveira");

Console.WriteLine($"Primeiro resultado: {isNomeEqual}");
Console.WriteLine($"Segundo resultado: {isNomeEqual2}");

// Tipo NUMERICOS //

/*
    sbyte: armazena valores entre -128 e 127
    short: armazena valores entre -32,768 e 32,767
    int: armazena valores entre -2,147,483,648 e 2,147,483,647
    long: armazena valores entre -9,223,372,036,854,775,808 e 9,223,372,036,854,775,807

*/

float myFloat = 10f;
double myDouble = 5d;
decimal myDecimal = 7m;
int myInteger = 0;

// BOOL 

bool estaChovendo = true; // Declaração e atribuição de uma variável booleana
bool usuarioLogado = false;

if (estaChovendo) {
    Console.WriteLine("Você precisa de um guarda-chuva!"); // Se estiver chovendo, exibe essa mensagem
}

if (usuarioLogado) {
    Console.WriteLine("Bem-vindo de volta!"); // Se o usuário estiver logado, exibe essa mensagem
} else {
    Console.WriteLine("Por favor, faça login."); // Se o usuário não estiver logado, exibe essa mensagem
}