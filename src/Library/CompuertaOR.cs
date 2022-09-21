using System;
using System.Collections.Generic;
namespace compuertas
{
    public class CompuertaOR : ICompuertasLogicas
    {
        public string Nombre {get;set;}
        public Dictionary<string,ICalculable> Entradas {get; set;} 

        public CompuertaOR(string nombre)
        {
            this.Nombre = nombre;
            this.Entradas = new Dictionary<string, ICalculable>{};
        }
        public void Connect(string nombre, ICalculable valor)
        {
            this.Entradas[nombre] = valor;
        }
        public bool Calculate()
        {
            bool resultado = false;
            foreach (ICalculable valores in this.Entradas.Values)
            {
                if (valores.Calculate() == true)
                {
                    resultado = true;
                    return resultado;
                }
            }
            return resultado;
        }
    }
}