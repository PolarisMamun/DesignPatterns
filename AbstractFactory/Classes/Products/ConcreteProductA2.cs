using AbstractFactory.Interfaces.Products;

namespace AbstractFactory.Classes.Products
{
    public class ConcreteProductA2 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product A2";
        }
    }
}