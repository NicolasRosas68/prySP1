using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySP1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lstModulo.Items.Add("Administracion");
            lstModulo.Items.Add("Sistema");
            lstModulo.Items.Add("Compras");
            lstModulo.Items.Add("Ventas");
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {

        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            txtUsuario.MaxLength = 10;

        }

        private void lstModulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
