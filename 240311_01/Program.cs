
//operadores
int a = 3;
int b = a++; //acumulador
//nesse ++ vai somar a + 1
///entretanto o acumulo vai ocorrer depois da atribuicao pois o ++ esta do lado direito de a
WriteLine($"a é {a}, e b é {b}");

int c = 3;
int d = ++c;
//nesse caso o ++ esta do aldo esquerdo de c. portanto o acumulo acontece antes da atribuicao. 
WriteLine($"c é {c}, e d é {d}");

WriteLine();
WriteLine();
WriteLine();

//combinando operadores de atribuicao

int p = 6;
p += 3; //equivalente a p = p+3;
p -= 3; //equivalente a p = p-3;
p *= 3; //equivalente a p = p*3;
p /= 3; //equivalente a p = p/*3;

// operadores logicos

bool b_A = true;
bool b_B = false;

WriteLine($"AND | b_A   | b_B ");
WriteLine($"b_A | {b_A & b_A, -5} | {b_A & b_B, -5}");
WriteLine($"b_B | {b_B & b_A, -5} | {b_B & b_B, -5}");

WriteLine();

WriteLine($"OR  | b_A   | b_B ");
WriteLine($"b_A | {b_A | b_A, -5} | {b_A | b_B, -5}");
WriteLine($"b_B | {b_B | b_A, -5} | {b_B | b_B, -5}");

WriteLine();

WriteLine($"XOR | b_A   | b_B ");
WriteLine($"b_A | {b_A ^ b_A, -5} | {b_A ^ b_B, -5}");
WriteLine($"b_B | {b_B ^ b_A, -5} | {b_B ^ b_B, -5}");
