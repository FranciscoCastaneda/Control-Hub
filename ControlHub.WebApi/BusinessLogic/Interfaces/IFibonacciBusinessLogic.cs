namespace ControlHub.WebApi.BusinessLogic.Interfaces
{
    public interface IFibonacciBusinessLogic
    {
        /// <summary>
        /// Obtiene el número de Fibonacci a partir de un índice
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int GetFibonacciByIndex(int index);
    }
}
