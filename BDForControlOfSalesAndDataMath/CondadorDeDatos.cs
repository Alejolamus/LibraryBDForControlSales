﻿using BDForControlOfSalesAndDataMath.Context;
using System.Linq;

namespace BDForControlOfSalesAndDataMath
{
    public class CondadorDeDatos
    {
        static void Main()
        {
            using (var context = new RegistrosVentContext())
            {
                var RecUsersr = context.Users.ToArray();
                bool DataInUsers = (RecUsersr.Length > 0);
                var RecProductos = context.Productos.ToArray();
                bool DataInProductos = (RecProductos.Length > 0);
                var RecVentas = context.Ventas.ToArray();
                bool DataInVentas = (RecVentas.Length > 0);
            }
        }
    }
}
