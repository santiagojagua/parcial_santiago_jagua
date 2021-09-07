using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onlypan
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            var User = "Empleado";
            var admn = "Admin";
            var contrauser = "Empleado";
            var contradmn = "Admin";
            if (txtUsuario.Text == User && txtContraseña.Text == contrauser)
            {
                Ventas newtrabajo = new Ventas();
                newtrabajo.Show(this);

            }
            if (txtUsuario.Text == admn && txtContraseña.Text == contradmn)
            {
                OpcionesAdmin newadmin = new OpcionesAdmin();
                newadmin.Show(this);
            }
    }
}
