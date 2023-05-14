
Console.Write("digite a base da potencia : " + " ");

int x = int.Parse(Console.ReadLine());


Console.Write("digite a expoente da potencia : " + " ");
int n = int.Parse(Console.ReadLine());

int resultado = Potencia(x, n);


Console.WriteLine("O resultado é : " + resultado);
int Potencia(int x, int n)
{
    // Caso base: x^0 = 1
    if (n == 0)
        return 1;

    // Passo da recursão: x^n = x * x^(n-1)
    return x * Potencia(x, n - 1);
}


