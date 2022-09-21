using System;
using System.Collections.Generic;
namespace compuertas
{
    public class CompuertaAND : ICompuertasLogicas
    {
        public string Nombre {get;set;}
        public Dictionary<string,ICalculable> Entradas {get; set;} 

        public CompuertaAND(string nombre)
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
            bool resultado = true;
            foreach(ICalculable valores in this.Entradas.Values)
            {
                if (valores.Calculate() == false)
                {
                    resultado = false;
                    return resultado;
                }
            }
            return resultado;
        }
    }
}