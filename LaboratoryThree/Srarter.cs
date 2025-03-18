using LaboratoryThree.Equations;

internal class Starter
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Приветсвую");
            Console.WriteLine("Программа высчитывает x в случаи когда AX^2 + BX + C = 0");
            Console.WriteLine("Введите коофециенты квадратного уравнения A B C:");
            QuadraticEquation equation = new QuadraticEquation(getCoof("A"), getCoof("B"), getCoof("C"));
            ResultQuadraticEquation result = equation.GetRoot();
            if (!String.IsNullOrWhiteSpace(result.Error))
            {
                Console.WriteLine(result.Error);
            }
            else
            {
                if (result.SecondRoot == result.FirstRoot)
                {
                    Console.WriteLine($"Уравнение имеет два равных корня: X1 = X2 = {result.FirstRoot}");
                }
                else
                {
                    Console.WriteLine($"Уравнение имеет два корня: \n" +
                        $" X1 = {result.FirstRoot} \n" +
                        $" X2 = {result.SecondRoot}");
                }
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }


    }

    private static double getCoof(string coofName)
    {
        Console.Write($"{coofName} координата: ");
        string? coorAsString = Console.ReadLine();

        if (double.TryParse(coorAsString, out double parsedX))
        {
            return parsedX;
        }
        else
        {
            throw new FormatException($"Не верно введен формат числа {coofName}: {coorAsString}. Ожидается число в формате ##0,###");
        }
    }
}