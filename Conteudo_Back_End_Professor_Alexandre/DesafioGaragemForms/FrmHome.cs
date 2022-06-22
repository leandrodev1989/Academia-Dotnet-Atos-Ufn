using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garagemteste
{
    public partial class FrmHome : Form
    {
        private Form frmAtivo;

        public FrmHome()
        {
            InitializeComponent();
        }

        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            panelForm.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void ActiveFormClose()
        {
            if (frmAtivo != null)
            
                frmAtivo.Close();
            
        }
        private void ActiveButton(Button frmAtivo)
        {
            foreach (Control ctrl in panelPrincipal.Controls)
                ctrl.ForeColor = Color.White;

            frmAtivo.ForeColor = Color.Red;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActiveButton(btnHome);
            ActiveFormClose();
        }

        private void btnCadastrarVeiculo_Click(object sender, EventArgs e)
        {
            ActiveButton(btnCadastrarVeiculo);
            FormShow(new FrmCadastroVeiculos());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            ActiveButton(btnSair);
            ActiveFormClose();
            Application.Exit();
        }

        List<Veiculo> listaveiculos = new List<Veiculo>();

        private void btnHome_Click(object sender, PaintEventArgs e)
        {

        }
    }
}
