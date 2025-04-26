using GUI490WC;
using SERVICIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui
{
    public partial class FormMenu490WC : Form
    {
        FormABMUsuario490WC formABMUSUARIO490WC;
        FormCambiarClave490WC formCambiarClave490WC;
        
        public FormMenu490WC()
        {
            InitializeComponent();
            formABMUSUARIO490WC = new FormABMUsuario490WC(this);
            formCambiarClave490WC = new FormCambiarClave490WC();

            LabelNombreUsuarioa.AutoSize = false;
            LabelNombreUsuarioa.MaximumSize = new Size(panelPrincipal.Width, 0);


            LabelNombreUsuarioa.Height = LabelNombreUsuarioa.PreferredHeight; 

            LabelRolUsuario.AutoSize = false;
            LabelRolUsuario.MaximumSize = new Size(panelPrincipal.Width, 0);
            LabelRolUsuario.Height = LabelRolUsuario.PreferredHeight; 
        

            LabelNombreUsuarioa.Height = LabelNombreUsuarioa.PreferredHeight; 
            LabelRolUsuario.Height = LabelRolUsuario.PreferredHeight; 

            Diseno490WC();
        }
 
        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            SesionManager490WC.GestorSesion490WC.Logout490WC();
            GestorForm490WC.gestorFormSG490WC.DefinirEstado490WC(new EstadoCerrarAplicacion490WC());
        }
        #region Diseno
    
        private void Diseno490WC()
        {
            panelAdministrarSubmenu.Visible = false;
            panelSubmenuPrueba2.Visible = false;
            panelSubmenuPrueba3.Visible = false;
            panelSubmenuPrueba.Visible = false;
        }

        private void hideSubmenu490WC()
        {
            if(panelAdministrarSubmenu.Visible == true)
            {
                panelAdministrarSubmenu.Visible = false;
            }
            if(panelSubmenuPrueba2.Visible == true)
            {
                panelSubmenuPrueba2.Visible = false;
            }
            if(panelSubmenuPrueba3.Visible == true)
            {
                panelSubmenuPrueba3.Visible = false;
            }
            if(panelSubmenuPrueba.Visible == true)
            {
                panelSubmenuPrueba.Visible=false;
            }
        }
        private void showSubmenu490WC(Panel subMenu490WC)
        {
            if(subMenu490WC.Visible == false)
            {
                hideSubmenu490WC();
                subMenu490WC.Visible = true;
            }
            else
            {
                subMenu490WC.Visible = false;
            }
        }
        #endregion

        #region Button Click

        private void BT_ADMINISTRAR_Click(object sender, EventArgs e)
        {
            showSubmenu490WC(panelAdministrarSubmenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            formABMUSUARIO490WC.ShowDialog();
           
            hideSubmenu490WC();
            
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            hideSubmenu490WC();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            hideSubmenu490WC();
            this.Show();
        }

        private void BT_Prueba_Click(object sender, EventArgs e)
        {
            showSubmenu490WC(panelSubmenuPrueba);
        }

        private void BT_Prueba2_Click(object sender, EventArgs e)
        {
            showSubmenu490WC(panelSubmenuPrueba2);
        }

        private void BT_Prueba3_Click(object sender, EventArgs e)
        {
            showSubmenu490WC(panelSubmenuPrueba3);
        }

        private void button8_Click(object sender, EventArgs e)
        {

            formCambiarClave490WC.ShowDialog();
            
            hideSubmenu490WC();
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            SesionManager490WC.GestorSesion490WC.Logout490WC();
            GestorForm490WC.gestorFormSG490WC.DefinirEstado490WC(new EstadoIniciarSesion490WC());
            hideSubmenu490WC();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
       
            hideSubmenu490WC();
          
            this.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            hideSubmenu490WC();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            hideSubmenu490WC();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hideSubmenu490WC();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            hideSubmenu490WC();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            hideSubmenu490WC();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            hideSubmenu490WC();
        }

        private void BT_Salir_Click(object sender, EventArgs e)
        {
            SesionManager490WC.GestorSesion490WC.Logout490WC();
            GestorForm490WC.gestorFormSG490WC.DefinirEstado490WC(new EstadoCerrarAplicacion490WC());
            hideSubmenu490WC();
        }
        #endregion


    }
}
