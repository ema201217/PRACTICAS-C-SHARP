namespace excepciones
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random numero = new Random();
            int nRandom = numero.Next(0, 100);
            int intentos = 5;
            Console.WriteLine("Adivina el número aleatorio");

            try
            {
                int respuesta = int.Parse(Console.ReadLine()!);
                do
                {
                    if (respuesta == nRandom)
                    {
                        Console.WriteLine($"Felicitaciones, el número {respuesta} es el correcto");
                        break;
                    }

                    if (--intentos == 0)
                    {
                        Console.WriteLine($"Agotastes el número de intentos, el número aleatorio era {nRandom}!!");
                        break;
                    }
                    else
                    {
                        if (respuesta > nRandom) Console.WriteLine("El número es menor");
                        else if (respuesta < nRandom) Console.WriteLine("El número es mayor");
                        Console.WriteLine($"Te quedan {intentos} intentos");
                        Console.WriteLine("Adivina el número aleatorio");
                        respuesta = int.Parse(Console.ReadLine()!);
                    }

                } while (respuesta != nRandom);
            }
            
            catch (Exception e) when (e.GetType() != typeof(FormatException))
            {
                Console.WriteLine("Ha habido un error.");
                // Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Has introducido texto");
            }
        }
    }
}