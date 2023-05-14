
int[] numeros = {10,20, 30,40,50,60};

Console.WriteLine("Vetor na ordem normal [{0}]",  string.Join( ",", numeros));

Inverter(numeros, numeros.Length);

Console.WriteLine("Vetor na ordem inversa [{0}]", string.Join(",", numeros));




void Inverter(int[]vetor, int n)
{
    int centro = n / 2;
    for(int i = 0; i < centro; i++)
    {
        //  vetor de tamanho 0 ou 1 (não precisa inverter)
        // Passo da recursão: inverte o primeiro e último elemento, e chama a função recursivamente
        
        int temporaria = vetor[i];

        vetor[i] = vetor[n - 1 - i];

        vetor[n - 1 - i ] = temporaria;

    }
}