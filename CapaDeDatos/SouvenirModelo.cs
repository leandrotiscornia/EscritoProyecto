using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDeDatos
{
    public class SouvenirModelo : ConexionModelo
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int stock { get; set; }
        public int precio { get; set; } //TODO cambiar a double
        public DateTime fechaAlta { get; set; }

        public void altaSouvenir()
        {
            string texto =
                "INSERT INTO souvenirs(nombre, descripcion, stock, precio, fechaAlta) " +
                "VALUES(@nombre, @descripcion, @stock, @precio, @fechaAlta);";
            comando.CommandText = texto;
            comando.Parameters.AddWithValue("@nombre",nombre);
            comando.Parameters.AddWithValue("@descripcion",descripcion);
            comando.Parameters.AddWithValue("@stock",stock);
            comando.Parameters.AddWithValue("@precio",precio);
            comando.Parameters.AddWithValue("@fechaAlta", DateTime.Now);
            ejecutarComando();

        }

        public void bajaSouvenir() //baja lógica
        {
            string texto =
                "UPDATE souvenirs " +
                "SET descripcion = 'Obsoleto', " +
                "stock = 0, " +
                "precio = 0 " +
                "WHERE id = @id;";
            comando.CommandText = texto;
            comando.Parameters.AddWithValue("@id",id);
            ejecutarComando();
        }
        public void modificarSouvenir()
        {
            string texto =
                "UPDATE souvenirs " +
                "SET nombre = @nombre," +
                "descripcion = @descripcion, " +
                "stock = @stock, " +
                "precio = @precio " +
                "WHERE id = @id;";
            comando.CommandText = texto;
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.Parameters.AddWithValue("@precio", precio);
            ejecutarComando();
        }

        public void obtenerSouvenir()
        {
            string texto =
                "SELECT nombre, descripcion, stock, precio, fechaAlta " +
                "FROM souvenir " +
                "WHERE id = @id";
            comando.CommandText = texto;
            comando.Parameters.AddWithValue("@id", id);
            leerComando();
            this.nombre = leerTexto(0);
            this.descripcion = leerTexto(1);
            this.stock = leerEntero(2);
            this.precio = leerEntero(3);
            this.fechaAlta = leerFecha(4);
        }
        public DataTable listarSouvenirs()
        {
            string texto =
                "SELECT nombre, descripcion, stock, precio, fechaAlta " +
                "FROM souvenir";
            comando.CommandText = texto;
            leerComando();
            return leerTabla();
        }
    }
}
