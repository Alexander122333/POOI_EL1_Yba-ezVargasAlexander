using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta1
{
    public class Central

    {
        public int Modelo { get; set; }

        public int Cantidad { get; set; }
        public string Equipo { get; set; }
       

        //Metodos Costo ,Subtotal,Descuento - Total a pagar

        public virtual decimal Costo()
        {
            decimal CostoEquipo = 0;
            switch (Equipo)
            {
                case "Motorola One Macro":
                  CostoEquipo = 650; 
                   break;

                case "Samsung Galazy A30S":
                  CostoEquipo = 850;
                    break;

                case "Huawei P40 Lite Negro":
                    CostoEquipo = 950;
                    break;

            }
            return CostoEquipo;
        }

        public decimal SubTotal()
        {   
            
            return Costo() * Cantidad;
        }




        public virtual decimal Descuento()
        {
            decimal DescuentoEquipo = 0;

            if (Cantidad > 10)
            { DescuentoEquipo = SubTotal() * 10 / 100; }

            return DescuentoEquipo;

        }       
        public Decimal NetoPagar()
        {
            return SubTotal() - Descuento();
        }
    }
}
