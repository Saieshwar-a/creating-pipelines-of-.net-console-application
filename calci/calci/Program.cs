public class Class1
{
    public float result;
    public float calculate(string value, decimal valueFirst, decimal valueSecond)
    {

        switch (value)
        {
            case "+":
                result = (float)(valueFirst + valueSecond);
                break;
            case "-":
                result = (float)(valueFirst - valueSecond);
                break;
            case "*":

                result = (float)(valueFirst * valueSecond);
                break;
            case "/":
                result = (float)(valueFirst / valueSecond);
                break;
            //case "%":
            //    result = (float)(valueFirst % valueSecond);
            //    break;

        }
        return result;
    }

}
namespace cal
{
   class Test
    {
        static void Main(string[] args)
        {
            Class1 x = new Class1();
            float ans = x.calculate("+", 3, 4);
            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }

}


