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
void FillArray(int [,] matr )
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
            matr [i,j] = new Random().Next(1, 16);
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
Console.WriteLine ("Введите число от 1 до 15, которое хотите найти в Вашем массиве: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("");
for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            if (matrix [i,j] == X)
            {
                Console.WriteLine ($"Элемент массива совпал с введеным Вами числом {X} и он находится на позиции: {i+1} строки и {j+1} столбца");
            }
            else Console.WriteLine ($"На позиции: {i+1} строки и {j+1} столбца Ваше число {X} не найдено в массиве");
        }
    }

    
