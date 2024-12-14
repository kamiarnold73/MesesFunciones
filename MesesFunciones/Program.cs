namespace MesesFunciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Ingrese un numero entre el 1 y 12 para obtener el mes:");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int numeroMes))
                {
                    if (numeroMes >= 1 && numeroMes <= 12)
                    {
                        string nombreMes = ObtenerNombreDelMes(numeroMes);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"El mes {numeroMes} es: {nombreMes}");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("No valido: Porfavor introduzca un numero del 1 al 12");
                    }

                    Console.ResetColor();
                    Console.WriteLine();
                }
            }
            static string ObtenerNombreDelMes(int mes)
            {
                string[] meses =
                {
                   "Enero",
                   "Febrero",
                   "Marzo",
                   "Abil",
                   "Mayo",
                   "Junio",
                   "Julio",
                   "Agosto",
                   "Septiembre",
                   "Octubre",
                   "Noviembre",
                   "Diciembre"
                };

                return meses[mes - 1];


            }
        }
    }
}