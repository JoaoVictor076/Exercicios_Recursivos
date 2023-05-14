




using System.Runtime.Serialization;


double[] valores = {2.0, 4.5, 10, 20};

double soma = Soma(valores, valores.Length);

Console.WriteLine(soma);
double Soma( double [] valores, int n)
{
    //  vetor de tamanho 0, soma = 0
    if (n == 0)
        return 0;
    // Passo da recursão: soma = primeiro elemento + soma do restante do vetor
    return valores[n - 1] + Soma(valores, n - 1);
}


