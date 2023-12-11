namespace pr3
{
    public interface ICalculationService
    {
        T Substract<T>(T first, T second) where T : struct;
        T Sum<T>(T first, T second) where T : struct;
        T Divide<T>(T first, T second) where T : struct;
        T Multiply<T>(T first, T second) where T : struct;
    }

    public class CalculationService : ICalculationService
    {
        public T Substract<T>(T first, T second) where T : struct => (dynamic)first - second;
        public T Sum<T>(T first, T second) where T : struct => (dynamic)first + second;
        public T Divide<T>(T first, T second) where T : struct => (dynamic)first / second;
        public T Multiply<T>(T first, T second) where T : struct => (dynamic)first * second;
    }
}