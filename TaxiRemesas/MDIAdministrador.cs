using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxiRemesas
{
    public partial class MDIAdministrador : Form
    {
        private int childFormNumber = 0;
        private string user;

        public MDIAdministrador()
        {
            InitializeComponent();
        }
        public MDIAdministrador(string user)
            : this()
        {
            this.user = user;
        }
        private frmConfiguraModem form = null;
        //FORMULARIO USUARIOS
        private frmConfiguraModem FormInstance
        {
            get
            {
                if (form == null)
                {
                    form = new frmConfiguraModem();
                    form.MdiParent = this;
                    form.Disposed += new EventHandler(form_Disposed);
                    form.FormClosed += new FormClosedEventHandler(form_FormClosed);
                    form.Load += new EventHandler(form_Load);

                }

                return form;
            }
        }
        void form_Disposed(object sender, EventArgs e)
        {
            form = null;

        }
        void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("Se ha cerrado el Formulario");
        }
        void form_Load(object sender, EventArgs e)
        {
            // MessageBox.Show( "Formulario abierto");
        }
        private void mostrarElementos()
        {
            string nombre_maquina = Environment.MachineName;
            string fecha = DateTime.Now.ToShortDateString();
            string hora = DateTime.Now.ToLongTimeString();
            lblFecha.Text = fecha;
            lblMaquina.Text = nombre_maquina;
            lblHora.Text = hora;
            toolStripUser.Text = this.user;
        }
   
        
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
           // this.Close();
            Application.Exit();
        }

       

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIAdministrador_Load(object sender, EventArgs e)
        {
            
            mostrarElementos();
        }

        private void MDIAdministrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void módemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfiguraModem frm = this.FormInstance;
            // se varifica si el formulario no esta minimizado, en caso de estarlo
            // se lo cambia a un estado normal
            if (frm.WindowState == FormWindowState.Minimized)
                frm.WindowState = FormWindowState.Normal;

            frm.Show();
        }
    }
}
