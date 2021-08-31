//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            ///
            for (int tren = 1; tren < 101; tren++)
            {
                var train = new Train($"{tren}");
            }
            Console.WriteLine(Train.Contador);

            ///Crea 10.000.100 trenes ya que el metodo Main no había terminado su ejecución, por lo cual la variable Contador de la Clase Train seguía acumulando valores
            for (int i = 1; i < 10000001; i++)
            {
                var train = new Train($"{i}");
            }
            Console.WriteLine(Train.Contador);
            ///train.StartEngines();
            Train t1 = new Train("Last Train To London");
            Train t2 = new Train("Last Train To London");
            Train t3 = new Train("Runaway Train");
            Console.WriteLine(t1.IdentificadorTrenes);
            Console.WriteLine(t2.IdentificadorTrenes);
            Console.WriteLine(t3.IdentificadorTrenes);
            ///t1 == t2 es falso, porque a los objetos que se esta refiriendo cada variable son diferentes, cada cual ocupa su propio espacio heap
            ///t2 == t3 es falso, porque cada uno es un objeto independiente (cada cual ocupa un diferente espacio heap) y sus variables son diferentes
        }
    }
}