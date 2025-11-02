using LR1MAT;
class Program
{
    static void Main(string[] args)
    {
        double[] c = { 3, 1, 4 };
        double[,] A = { { 2, 1, 1 }, { 1, 4, 0 }, { 0, 0.5, 1 } };
        double[] b = { 6, 4, 1 };
        Table table = new(c, A, b);
        int exept = table.simplex_metod();
        if (exept == 1)
        {
            throw new Exception("Данная система несовместна");
        }
        else if (exept == 2)
        {
            throw new Exception("Целевая функция не ограничена");
        }
    }
}