using ControlHub.WebApi.BusinessLogic.Interfaces;
using System.Threading.Tasks;

namespace ControlHub.WebApi.BusinessLogic
{
    public class FibonacciBusinessLogic : IFibonacciBusinessLogic
    {
        public FibonacciBusinessLogic() { }

        /// <summary>
        /// Obtiene el número de Fibonacci a partir de un índice
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public async Task<int> GetFibonacciByIndex(int index)
        {
            return Fibonacci(index);
        }

        private int Fibonacci(int n)
        {
            if ((n == 1) || (n == 2))
                return 1;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
