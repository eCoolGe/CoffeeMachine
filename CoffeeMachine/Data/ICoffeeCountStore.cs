using CoffeeMachine.Model;

namespace CoffeeMachine.Data
{
    public interface ICoffeeCountStore
    {
        void Save(CoffeeCountItem item);
    }
}
