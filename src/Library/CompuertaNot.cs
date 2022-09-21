using System;
namespace compuertas
{
    public class CompuertaNOT : ICompuertasLogicas
    {
        public string Nombre {get;set;}
        public Tuple<string, ICalculable> Entrada {get;set;}

        public CompuertaNOT(string nombre)
        {
            this.Nombre = nombre;
            this.Entrada = new Tuple <string, ICalculable> (null,null);
        }
        public void Connect(string nombre, ICalculable valor)
        {
            var tupla = Tuple.Create(nombre,valor);
            this.Entrada = tupla;
        }
        public bool Calculate()
        {
            bool resultado = true;
            if (this.Entrada.Item2.Calculate() == true)
            {
                resultado = false;
                return resultado;
            }
            else
            {
                return resultado;
            }
        }
    }
}