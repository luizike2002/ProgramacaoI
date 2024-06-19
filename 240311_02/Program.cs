// Atividade 01 - 11/03/2024


WriteLine("Digite o operador desejado (+, -, *, /): ");
char operador = ReadLine()[0]; // Obtém o primeiro caractere digitado pelo usuário
WriteLine($"Tabuada do operador {operador}:");

for (int i = 1; i <= 9; i++)
{
    for (int j = 1; j <= 9; j++)
    {
    int resultado = 0;

        switch (operador)
        {
            case '+':
                resultado = i + j;
                break;
            case '-':
                resultado = i - j;
                break;
            case '*':
                resultado = i * j;
                break;
            case '/':
                if (j != 0) // Evita divisão por zero
                    resultado = i / j;
                break;
            default:
            WriteLine("Operador inválido.");
            return;
        }
        Write($"{i} {operador} {j} = {resultado,-3}\t");
    }
    WriteLine();
}