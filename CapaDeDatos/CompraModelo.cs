using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDeDatos
{
    public class CompraModelo : ConexionModelo
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public int id_souvenir { get; set; }
        public int cantidad { get; set; }


        public void comprar()
        {
            string texto =
                "INSERT INTO compra(id_souvenir, cantidad, fecha) " +
                "VALUES (@id_souvenir, @cantidad, @fecha";
            comando.CommandText = texto;
            comando.Parameters.AddWithValue("@id_souvenir", id);
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.Parameters.AddWithValue("@fecha", DateTime.Now);
            ejecutarComando();
        }
        public DataTable listarCompras()
        {
            string texto =
                "SELECT id, nombre, precio, cantidad, precio*cantidad AS `precio total`, fecha " +
                "FROM compra " +
                "JOIN souvenirs ON souvenirs.id = compra.id_souvenir " +
                "ORDER BY fecha";
            comando.CommandText = texto;
            leerComando();
            return leerTabla();
        }
       
    }
}
