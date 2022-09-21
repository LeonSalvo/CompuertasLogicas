//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;

namespace compuertas
{
    class Program
    {
        static void Main(string[] args)
        {
            CompuertaAND And1 = new CompuertaAND("AND-1");
            And1.Connect("A", new BoolValue(true));
            And1.Connect("B",new BoolValue(true));
            Console.WriteLine($"Resultado intermedio de compuerta {And1.Nombre}: {And1.Calculate()}");

            CompuertaOR Or2 = new CompuertaOR("OR-2");
            Or2.Connect("C", new BoolValue(false));
            Or2.Connect(And1.Nombre, And1);
            Console.WriteLine($"Resultado intermedio de compuerta {Or2.Nombre}: {Or2.Calculate()}");

            CompuertaNOT Not3 = new CompuertaNOT("NOT-3");
            Not3.Connect(Or2.Nombre, Or2);
            Console.WriteLine($"Resultado final: {Not3.Calculate()}");
        }
    }
}