using System;
namespace compuertas
{
    public class BoolValue : ICalculable
    {
        public bool Value {get;set;}
        public BoolValue (bool valor)
        {
            this.Value = valor;
        }
        public bool Calculate()
        {
            return this.Value;
        }
    }
}