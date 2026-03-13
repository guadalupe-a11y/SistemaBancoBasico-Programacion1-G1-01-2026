using DAL;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClienteBLL
    {
        // instancia de nuestra clase ClienteDAL
        public ClienteDALADO _clienteDAL;

        // crear un metodo para almacenar un cliente
        public int Guardar(Cliente cliente)
        {

            // inicializar la instancia de ClienteDALA
            _clienteDAL = new ClienteDALADO();

            int resultado = _clienteDAL.Guardar(cliente);

            return resultado;
        }
    }
}
