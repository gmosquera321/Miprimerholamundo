// Lea  las coordenadas de dos puntos y que muestre las distancias entre los puntos.

public class Ejercicio1
{
    static void Main(string[] args)
    {
        double coordenadas1, coordenadas2;
        Console.Write("ingrese la coordenada x del primer punto:");
        coordenadas1 = double.Parse(Console.ReadLine());
        Console.Write("ingrese la coordenada y del primer punto:");
        coordenadas1 = double.Parse(Console.ReadLine());
        Console.Write("ingrese la coordenada x del segundo punto:");
        coordenadas2 = double.Parse(Console.ReadLine());
        Console.Write("ingrese la coordenada y del segundo punto:");
        coordenadas2 = double.Parse(Console.ReadLine());

        double distancia = Math.Sqrt(d: coordenadas2 - coordenadas1 * (coordenadas1 - coordenadas2));
        Console.WriteLine($"la distancia entre los dos puntos es:{distancia}");
    }
}
