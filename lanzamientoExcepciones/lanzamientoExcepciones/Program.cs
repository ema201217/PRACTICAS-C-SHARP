internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Introduce el numero del mes");
        int NumeroMes = int.Parse(Console.ReadLine()!);
        Console.WriteLine(NombreDelMes(NumeroMes));
        Console.WriteLine("Aqui continuaría la ejecución del resto del programa");
    }

    public static string NombreDelMes (int mes)
    {
        switch(mes)
        {
            case 1:
                return "Enero";
            case 2:
                return "Febrero";
            case 3:
                return "Marzo";
            case 4:
                return "Abril";
            case 5:
                return "Mayo";
            case 6:
                return "Junio";
            case 7:
                return "Julio";
            case 8:
                return "Agosto";
            case 9:
                return "Septiembre";
            case 10:
                return "Octubre";
            case 11:
                return "Noviembre";
            case 12:
                return "Diciembre";
            default:
                throw new ArgumentOutOfRangeException();
        }
        

    }
}