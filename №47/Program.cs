void PrintArray(double[,] matr )
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
Random r = new Random();
void FillArray(double[,] matr )
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
            matr [i,j] = r.Next(-100000, 100000) / 10.00;
        }
    }
}
Console.WriteLine ("Введите количество строк Вашего массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите количество столбцов Вашего массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double [,] matrix = new double [m,n];
FillArray(matrix);
PrintArray(matrix);
