using static delegatesexercise.Calculator;

namespace delegatesexercise;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Válassza ki a műveletet:\r\n1. Összeadás\r\n2. Kivonás\r\n3. Szorzás\r\n4. Osztás");
        Console.WriteLine("Kérem a választást:");
        int a=int.Parse(Console.ReadLine());
        Console.WriteLine("Kérem az első számot:");
        double b=Double.Parse(Console.ReadLine());
        Console.WriteLine("Kérem a második számot:");
        double c=Double.Parse(Console.ReadLine());
        Calculator calculator = new Calculator();
        if (a == 1)
        {
            MathOperation mathOperation = Add;
            Console.WriteLine(calculator.Calculate(mathOperation, b, c));
        }
        else if (a == 2)
        {
            MathOperation mathOperation2 = Substract;
            Console.WriteLine(calculator.Calculate(mathOperation2, b, c));
        }
        else if (a == 3)
        {
            MathOperation mathOperation3 = Multiply;
            Console.WriteLine(calculator.Calculate(mathOperation3, b, c));
        }else if (a == 4)
        {
            MathOperation mathOperation4 = Divide;
            Console.WriteLine(calculator.Calculate(mathOperation4, b, c));
        }
    }
}
