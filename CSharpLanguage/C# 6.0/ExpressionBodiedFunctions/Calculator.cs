
namespace ExpressionBodiedFunctions
{
    public class Calculator
    {
        public int TimesTwo(int x) => x * 2;
        public string SomeProperty => "Property value";

        public int Foo(int x, int y)
        {
            int r = x * y;
            return r + 10;
        }
    }
}