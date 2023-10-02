

CalculatorR calculator = new CalculatorR();
Int32 a = calculator.Summ(5, 5);
Int32 b = calculator.Minys(115, 5);
Console.WriteLine(a.ToString() + " " + b.ToString());


interface ISummator
{
    Int32 Summ(Int32 a, Int32 b);
}


class CalculatorR : ISummator
{
    public Int32 Summ(Int32 a, Int32 b) //а вот сюда больше или меньше не напишешь
    {
        int g = 342;
        g = a + 55;
        // и еще много чего сюдв можно написать
        return a + b;
    }

    public Int32 Minys(Int32 a, Int32 b)
    {
        return a - b;
    }

    public Int32 Umnojenie(Int32 a, Int32 b)
    {
        return a * b;
    }

    public Int32 Delenie(Int32 a, Int32 b)
    {
        return a / b;
    }
}



