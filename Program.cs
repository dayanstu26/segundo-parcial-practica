using System;

Console.Write("Nombre del estudiante: ");
string nombre = Console.ReadLine() ?? "";

while (string.IsNullOrWhiteSpace(nombre))
{
    Console.Write("El nombre no puede estar vacío. Intente de nuevo: ");
    nombre = Console.ReadLine() ?? "";
}

double suma = 0;

for (int i = 1; i <= 3; i++)
{
    double nota = LeerNota(i);
    suma = suma + nota;
}

double promedio = CalcularPromedio(suma, 3);
string resultado = ObtenerResultado(promedio);

Console.WriteLine("\nRESULTADO DEL ESTUDIANTE");
Console.WriteLine($"Estudiante: {nombre}");
Console.WriteLine($"Promedio: {promedio:F2}");
Console.WriteLine($"Resultado: {resultado}");

static double LeerNota(int numeroNota)
{
    double nota;

    Console.Write($"Nota {numeroNota}: ");

    while (!double.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 100)
    {
        Console.Write("Nota inválida. Escriba un número entre 0 y 100: ");
    }

    return nota;
}

static double CalcularPromedio(double suma, int cantidad)
{
    return suma / cantidad;
}

static string ObtenerResultado(double promedio)
{
    if (promedio >= 70)
    {
        return "Aprobado";
    }
    else
    {
        return "Reprobado";
    }
}