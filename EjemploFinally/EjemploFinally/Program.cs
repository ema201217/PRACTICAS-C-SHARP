internal class Program
{
    private static void Main(string[] args)
    {
        System.IO.StreamReader? file = null;


        try
        {
            string linea;
            int contador = 0;

            string path = @"C:\Users\Emanuel Developer\Desktop\tirar.txt";
            file = new System.IO.StreamReader(path);

            while((linea = file.ReadLine()!) != null)
            {
                Console.WriteLine(linea);
            }
        } catch (Exception e)
        {
            Console.WriteLine("Errorcon la lectura del archivo");
        } finally {
            if (file != null)
            {
                file?.Close();
                Console.WriteLine("Conexión con el fichero cerrada");
            }
        }
    }
}