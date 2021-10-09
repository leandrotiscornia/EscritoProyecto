using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDeDatos;

namespace CapaLogica
{
    public static class CompraController
    {
        public static void comprar(int id_souvenir, int cantidad, DateTime fecha)
        {
            CompraModelo compra = new CompraModelo();
            compra.id_souvenir = id_souvenir;
            compra.cantidad = cantidad;
            compra.fecha = fecha;
            compra.comprar();
        }
        public static DataTable listarComrpas()
        {
            CompraModelo compra = new CompraModelo();
            return compra.listarCompras();
        }
    }
}
