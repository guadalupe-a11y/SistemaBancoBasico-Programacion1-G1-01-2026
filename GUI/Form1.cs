using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using EL;

namespace GUI
{
    public partial class Form1 : Form
    {
        private ClienteBLL _BLL; // <-- declaración del campo

        public Form1()
        {
            InitializeComponent();
            _BLL = new ClienteBLL(); // <-- inicialización opcional aquí
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                // un objeto de tipo Cliente
                Cliente cliente = new Cliente();

                cliente.Nombres = txtNombre.Text;
                cliente.Apellidos = txtApellido.Text;
                cliente.Documento = txtDocumento.Text;
                cliente.Email = txtEmail.Text;
                cliente.Telefono = txtTelefono.Text;

                // inicializar el objeto _bll
                _BLL = new ClienteBLL();

                int resultado = _BLL.Guardar(cliente);


                if (resultado > 0)
                {

                }
                else
                {

                }

            }
            else
            {

            }
        }

        private bool ValidarCampos()
        {
            bool esValido = false;

            if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtApellido.Text) && !string.IsNullOrEmpty(txtDocumento.Text))
            {
                esValido = true;
            }


            return esValido;
        }

    }
}


