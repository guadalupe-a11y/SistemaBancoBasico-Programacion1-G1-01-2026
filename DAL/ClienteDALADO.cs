using EL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClienteDALADO
    {

        /**
         * Array, ArrayList, Stack, Queue, List
         **/

        // una método para obtener todos los clientes
        public List<Cliente> GetClientes() 
        {
            // nota: Crear un listado de clientes
            List<Cliente> clientes = new List<Cliente>();

            // 1. Utilizar la clase SqlConnection
            SqlConnection conn = new SqlConnection(Connection.connectionString);

            // 2. Crear la consulta
            string query = "SELECT * FROM Clientes";

            // 3. Crear nuestro comando a ejecutar
            SqlCommand cmd = new SqlCommand(query, conn);

            // 4. Paso abrir la conexión hacia la base de datos
            conn.Open();

            // 5. Ejecutar el comando y almacenar el resultado
            SqlDataReader reader = cmd.ExecuteReader();

            // 6. Manejar la información
            while (reader.Read())
            {
                // 6.1 Crear nuestro objeto Cliente

                // 6.2 Almacenar el objeto Cliente en la Lista de Clientes
            }

            // 7. Cerrar el reader

            reader.Close();

            // 8. Cerrar la conexión
            conn.Close();

            return clientes;
        }

    }
}
