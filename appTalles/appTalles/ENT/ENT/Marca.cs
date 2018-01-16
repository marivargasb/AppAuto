using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class MarcaVehiculo
    {
        private int id;
        private string marca;
        private Modelo modelo;
  

        public MarcaVehiculo()
        {
        }
        public MarcaVehiculo(int id, string marca, Modelo modelo)
        {
            this.id = id;
            this.marca = marca;
            this.modelo = modelo;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Marca
        {
            get
            {
                return marca;
            }

            set
            {
                marca = value;
            }
        }

        public Modelo Modelo
        {
            get
            {
                return modelo;
            }

            set
            {
                modelo = value;
            }
        }

        public override string ToString()
        {
            return  this.marca + " " + modelo;
        }
    }
}
