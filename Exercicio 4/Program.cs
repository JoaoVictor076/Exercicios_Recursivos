int decimal_numero;
Console.WriteLine("Digite o numero a transformar em binario : ");

decimal_numero = int.Parse(Console.ReadLine());

string binario_numero = DecimalParaBinario(decimal_numero);

Console.WriteLine("O numero decimal {0} em binario é {1}.", decimal_numero, binario_numero);



 string DecimalParaBinario(int numero)
{
    string binario = "";
    
    while (numero > 0)
    {
        
        // Passo da recursão : para cada inteiração, calcula se o resto da divisão por 2 e concatenamos
        // com a string, em seguida divide o numero por 2 e continua o looping até que o número seja igual a zero.
        int resto = numero % 2;
        binario = resto.ToString() + binario;
        numero = numero / 2;
    }
    return binario;
}