using Ejercicios1;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            DivisionCero.Dividir(10, 0);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("La division entre cero no esta permitida.");
        }
        finally
        {
            Console.WriteLine("Fin del programa");
        }

        Console.WriteLine("Presiona cualquier tecla para cerrar la consola");
        Console.ReadLine();
    }
}