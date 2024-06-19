using System;

Console.WriteLine(" BEM VINDO A CALCULADORA!");
Console.WriteLine("\n");

Console.WriteLine(" Qual Operação gostaria de fazer ?");
Console.WriteLine("\n");

Console.WriteLine(" 1 - Adição ");

Console.WriteLine(" 2 - Subtração ");

Console.WriteLine(" 3 - Multiplicação ");

Console.WriteLine(" 4 - Divisão ");

int calculo = Convert.ToInt32(Console.ReadLine());

switch(calculo){
    case 1:
        Console.WriteLine(" Você escolheu adição !!");
        Console.WriteLine(" Digite o primeiro numero ");
        double numero1 = Convert.ToDouble( Console.ReadLine());
        Console.WriteLine(" Digite o Segundo numero ");
        double numero2 = Convert.ToDouble( Console.ReadLine());
        double resultadoAdicao = numero1 + numero2;
        Console.WriteLine($"Resultado: {numero1} + {numero2} = " + resultadoAdicao);
    break;

    case 2:
        Console.WriteLine(" Voce escolheu Subtração !!");
        Console.WriteLine(" Digite o primeiro numero ");
        double numero3 = Convert.ToDouble( Console.ReadLine());
        Console.WriteLine("Digite o Segundo numero ");
        double numero4 = Convert.ToDouble(Console.ReadLine());
        double resultadoSubtracao = numero3 - numero4;
        Console.WriteLine($"Resultado: {numero3} - {numero4} = " + resultadoSubtracao);
    break;

    case 3:
        Console.WriteLine(" Voce escolheu Multiplicação !!");
        Console.WriteLine(" Digite o primeiro numero ");
        double numero5 = Convert.ToDouble( Console.ReadLine());
        Console.WriteLine(" Digite o segundo numero ");
        double numero6 = Convert.ToDouble( Console.ReadLine());
        double resultadoMultiplicacao = numero5 * numero6;
        Console.WriteLine($"Resultado: {numero5} * {numero6} = " + resultadoMultiplicacao);
    break;

    case 4:
        Console.WriteLine(" Voce escolheu Divisão !!");
        Console.WriteLine(" Digite o primeiro numero ");
        double numero7 = Convert.ToDouble( Console.ReadLine());
        Console.WriteLine(" Digite o segundo numero ");
        double numero8 = Convert.ToDouble( Console.ReadLine());
        double resultadoDivisao = numero7 / numero8;
        Console.WriteLine($"Resultado: {numero7} / {numero8} = " + resultadoDivisao);
    break;
    default:
    break;
}
Console.WriteLine("\n");
Console.WriteLine(" OBRIGADO POR USAR NOSSA CALCULADORA");

// Completo //