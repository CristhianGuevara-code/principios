using System;
using System.Collections.Generic;

public abstract class Vehiculo
{
    //Encapsulación
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public decimal Precio { get; set; }

    // Abstracción
    public abstract void MostrarDetalles();

    public void MostrarInformacion()
    {
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Precio: {Precio:C}");
    }
}

// Herencia
public class Auto : Vehiculo
{
    public int NumeroDePuertas { get; set; }
    public int Año { get; set; }

    public override void MostrarDetalles()
    {
        Console.WriteLine($"{Marca} {Modelo} con {NumeroDePuertas} puertas año {Año}, Precio: {Precio:C}");
    }
}

// Clase derivada Motocicleta que hereda de Vehiculo
public class Motocicleta : Vehiculo
{
    public int Cilindraje { get; set; }

    public override void MostrarDetalles()
    {
        Console.WriteLine($"{Marca} {Modelo} con {Cilindraje}cc, Precio: {Precio:C}");
    }
}

// Clase principal del programa
//Polimorfismo
class Program
{
    static void Main(string[] args)
    {
        // Lista de vehículos en el autolote
        List<Vehiculo> vehiculos = new List<Vehiculo>
        {
            new Auto { Marca = "Toyota", Modelo = "Hilux", Año = 2018, Precio = 600000, NumeroDePuertas = 4 },
            new Motocicleta { Marca = "Pulsar", Modelo = "NS", Precio = 40000, Cilindraje = 200 }
        };

        // Mostrar información y detalles de cada vehículo
        foreach (Vehiculo vehiculo in vehiculos)
        {
            vehiculo.MostrarInformacion();
            vehiculo.MostrarDetalles();
            Console.WriteLine();
        }
    }
}


