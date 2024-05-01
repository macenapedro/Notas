Console.WriteLine("## Exercício 4 ##\n");

double[,] notas = new double[2, 5];
double notas1 = 0;
double notas2 = 0;

for (int i = 0; i < notas.GetLength(0); i++)
{
    for(int j = 0; j < notas.GetLength(1); j++)
    {
        Console.WriteLine($"Informe o valor da nota do {j + 1}º aluno do {i + 1}º grupo");
        notas[i, j] = Convert.ToDouble(Console.ReadLine());
        if ( i < 1)
        {
            
            notas1 += notas[i, j];
        } else
        {
            notas2 += notas[i, j];
        };
    }
}

Console.WriteLine($"A média das notas do 1º grupo foi de: {notas1 / 5}");
Console.WriteLine($"A média das notas do 2º grupo foi de: {notas2 / 5}");


Console.ReadKey();