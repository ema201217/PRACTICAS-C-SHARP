namespace UsoChecked
{
    internal class Program
    {
        private static void Main(string[] args)
        {
           unchecked
            {

                int numero = int.MaxValue;

                int resultado = checked(numero + 20);

                Console.WriteLine(resultado);
            }
                
        }
    }
}