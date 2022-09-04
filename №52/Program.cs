void PrintArray(int[,] matr )
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}  ");
        }
    Console.WriteLine( );
    }
}
void FillArray(int[,] matr )
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
            matr [i,j] = new Random().Next(1, 20);
        }
    }
}
Console.WriteLine ("Введите количество строк Вашего массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите количество столбцов Вашего массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [m,n];
FillArray(matrix);
PrintArray(matrix);
double [] ar = new double [n];
int k = 0;
for (int j=0; j<matrix.GetLength(1); j++)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        ar [k] = (ar [k] + matrix [i, j]) ;
    }
    ar [k] = ar [k] / m;
    k++;
}
for (int p=0; p<n; p++)
{
    Console.WriteLine($"Среднее арифм. {p+1} столбца = {ar[p]}");
}

