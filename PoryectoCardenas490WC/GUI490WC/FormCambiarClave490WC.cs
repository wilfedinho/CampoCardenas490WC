using SERVICIOS;
using SERVICIOS490WC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui
{
    public partial class FormCambiarClave490WC : Form 
    {
      
        public FormCambiarClave490WC()
        {
            InitializeComponent();
        }


    

        private void BT_ADMINISTRAR_Click(object sender, EventArgs e)
        {
            if (UserManager490WC.UserManagerSG490WC.VerificarCambioClave490WC(TB_ClaveNueva.Text,TB_ConfirmarClave.Text))
            {
                MessageBox.Show(labelCambioExitoso.Text);
            }
            else
            {
                MessageBox.Show(labelCambioErroneo.Text);
            }
        }

        private void FormCambiarClave_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }
    }
}
