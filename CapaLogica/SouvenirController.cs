using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDeDatos;

namespace CapaLogica
{
    public static class SouvenirController
    {
        public static void alta(string nombre, string descripcion, int stock, int precio, DateTime fechaAlta)
        {
            SouvenirModelo souvenir = new SouvenirModelo();
            souvenir.nombre = nombre;
            souvenir.descripcion = descripcion;
            souvenir.stock = stock;
            souvenir.precio = precio;
            souvenir.fechaAlta = fechaAlta;
            souvenir.altaSouvenir();
        }
        public static void baja(int id)
        {
            SouvenirModelo souvenir = new SouvenirModelo();
            souvenir.id = id;
            souvenir.bajaSouvenir();
        }
        public static void modificar(int id, string nombre, string descripcion, int stock, int precio, DateTime fechaAlta)
        {
            SouvenirModelo souvenir = new SouvenirModelo();
            souvenir.id = id;
            souvenir.nombre = nombre;
            souvenir.descripcion = descripcion;
            souvenir.stock = stock;
            souvenir.precio = precio;
            souvenir.fechaAlta = fechaAlta;
            souvenir.modificarSouvenir();
        }
        public static List<string> obtener(int id)
        {
            List<string> datosSouvenir = new List<string>();
            SouvenirModelo souvenir = new SouvenirModelo();
            souvenir.id = id;
            souvenir.obtenerSouvenir();
            datosSouvenir.Add(souvenir.id.ToString());
            datosSouvenir.Add(souvenir.nombre);
            datosSouvenir.Add(souvenir.descripcion);
            datosSouvenir.Add(souvenir.precio.ToString());
            datosSouvenir.Add(souvenir.fechaAlta.ToString("dd/MM/yyyy"));
            return datosSouvenir;

        }
        public static DataTable listar()
        {
            SouvenirModelo souvenir = new SouvenirModelo();
            return souvenir.listarSouvenirs();
        }
    }
}
