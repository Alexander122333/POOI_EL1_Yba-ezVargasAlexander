using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta1
{
    public class Cusco : Central
    {
        public override decimal Costo()
        {
            decimal CostoEquipo = 0;
            switch (Equipo)
            {
                case "Motorola One Macro":
                    CostoEquipo = 750;
                    break;

                case "Samsung Galazy A30S":
                    CostoEquipo = 930;
                    break;

                case "Huawei P40 Lite Negro":
                    CostoEquipo = 1050;
                    break;

            }
            return CostoEquipo;
        }

        
        public override decimal Descuento()
        {
            decimal DescuentoEquipo = 0;

            if (SubTotal() <= 10000)
            { DescuentoEquipo = SubTotal() * 3 / 100; }
            else
            { DescuentoEquipo = SubTotal() * 10 / 100; }

            return DescuentoEquipo;
        }
        

    }
}
