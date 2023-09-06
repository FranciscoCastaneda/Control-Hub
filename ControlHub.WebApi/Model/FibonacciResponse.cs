namespace ControlHub.WebApi.Model
{
    public class FibonacciResponse : IFibonacciResponse
    {
        public int Input { get; set; }
        public int Output { get; set; }
        public string Result { get; set; }
    }

    public interface IFibonacciResponse
    {
        int Input { get; set; }
        int Output { get; set; }
        string Result { get; set; }
    }
}
