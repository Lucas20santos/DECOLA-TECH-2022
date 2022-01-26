using System;

namespace Projeto2.models
{
    public class Data
    {
        private int mes;
        private bool mesValido;

        public int getMes()
        {
            return this.mes;
        }
        public void setMes(int mes)
        {
            if (mes > 0 && mes < 12)
            {
                this.mes = mes;
                this.mesValido = true;
            }
        }

        public int Mes 
        { 
            get
            {
                return this.mes;
            }
            set
            {
                if(value > 0 && value <= 12)
                {
                    this.mes = value;
                    this.mesValido = true;
                }
                else
                {
                    Console.WriteLine("Valor invalido");
                }
            }
        }

        public void ApresentarMes()
        {
            if(this.mesValido)
            {
                Console.WriteLine(this.mes);
            }
            else
            {
                Console.WriteLine("Mês Invalido");
            }
        }
    }
}