using _240318_02___Atv_Aula_5.Models;

Imovel casa1 = new Imovel();
Imovel casa2 = new Imovel();
Imovel casa3 = new Imovel();

//Casa Moderna

casa1.ImovelId = 1;
casa1.Nome = "Casa Moderna";
casa1.Discretion = "Uma bela casa moderna";
casa1.Valor = 1000000;
casa1.Comodos = 5;
casa1.LocalityType = LocalityType.Urbano;
casa1.BusinessType = BusinessType.Venda;

//Casa de Praia

casa2.ImovelId = 2;
casa2.Nome = "Casa de Praia";
casa2.Discretion = "Uma bela casa beira Mar";
casa2.Valor = 35000;
casa2.Comodos = 6;
casa2.LocalityType = LocalityType.Urbano;
casa2.BusinessType = BusinessType.Location;

// Casa no Interior / Fazenda

casa3.ImovelId = 3;
casa3.Nome = "Casa Rural";
casa3.Discretion = "Uma bela Fazenda no Interior";
casa3.Valor = 5000000;
casa3.Comodos = 8;
casa3.LocalityType = LocalityType.Rural;
casa3.BusinessType = BusinessType.Venda;


Console.WriteLine("CASA MODERNA: ");
Console.WriteLine();

Console.WriteLine($"----------------------------------------------------------------------------------------------------");
Console.WriteLine($"        NOME       |        DESCRIÇÃO        |    VALOR    |   COMODOS   |   LOCAL   |   NEGOCIO   | ");
Console.WriteLine($"----------------------------------------------------------------------------------------------------");
Console.WriteLine($"    {casa1.Nome}   |  {casa1.Discretion}  |   {casa1.Valor}   |      {casa1.Comodos}      |   {casa1.LocalityType}  |    {casa1.BusinessType}    |");
Console.WriteLine($"----------------------------------------------------------------------------------------------------");

Console.WriteLine("\n");

Console.WriteLine("CASA DE PRAIA: ");
Console.WriteLine();

Console.WriteLine($"----------------------------------------------------------------------------------------------------");
Console.WriteLine($"        NOME       |        DESCRIÇÃO        |    VALOR    |   COMODOS   |   LOCAL   |   NEGOCIO   | ");
Console.WriteLine($"----------------------------------------------------------------------------------------------------");
Console.WriteLine($"   {casa2.Nome}   | {casa2.Discretion} |    {casa2.Valor}    |      {casa2.Comodos}      |   {casa2.LocalityType}  |   {casa2.BusinessType}  |");
Console.WriteLine($"----------------------------------------------------------------------------------------------------");

Console.WriteLine("\n");

Console.WriteLine("CASA RURAL / FAZENDA: ");
Console.WriteLine();

Console.WriteLine($"-----------------------------------------------------------------------------------------------------------");
Console.WriteLine($"        NOME       |           DESCRIÇÃO          |     VALOR     |   COMODOS   |   LOCAL   |   NEGOCIO   | ");
Console.WriteLine($"-----------------------------------------------------------------------------------------------------------");
Console.WriteLine($"     {casa3.Nome}    | {casa3.Discretion} |    {casa3.Valor}    |      {casa3.Comodos}      |   {casa3.LocalityType}   |    {casa3.BusinessType}    |");
Console.WriteLine($"-----------------------------------------------------------------------------------------------------------");

