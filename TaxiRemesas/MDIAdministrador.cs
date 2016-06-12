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
        #region // configuraciones formularios Hijos
        private frmConfiguraModem form = null;
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

        
        private frmUsuario formUsr = null;
        private frmUsuario FormInstanceUsr
        {
            get
            {
                if (formUsr == null)
                {
                    formUsr = new frmUsuario();
                    formUsr.MdiParent = this;
                    formUsr.Disposed += new EventHandler(formUsr_Disposed);
                    formUsr.FormClosed += new FormClosedEventHandler(formUsr_FormClosed);
                    formUsr.Load += new EventHandler(formUsr_Load);

                }

                return formUsr;
            }
        }

        void formUsr_Disposed(object sender, EventArgs e)
        {
            formUsr = null;

        }
        void formUsr_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("Se ha cerrado el Formulario");
        }
        void formUsr_Load(object sender, EventArgs e)
        {
            // MessageBox.Show( "Formulario abierto");
        }
        private frmCliente frmCli = null;
        private frmCliente FormInstanceCli
        {
            get
            {
                if (frmCli == null)
                {
                    frmCli = new frmCliente();
                    frmCli.MdiParent = this;
                    frmCli.Disposed += new EventHandler(frmCli_Disposed);
                    frmCli.FormClosed += new FormClosedEventHandler(frmCli_FormClosed);
                    frmCli.Load += new EventHandler(frmCli_Load);

                }

                return frmCli;
            }
        }
        
        
        void frmCli_Disposed(object sender, EventArgs e)
        {
            frmCli = null;

        }
        void frmCli_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("Se ha cerrado el Formulario");
        }
        void frmCli_Load(object sender, EventArgs e)
        {
            // MessageBox.Show( "Formulario abierto");
        }

        private frmUnidad frmUni = null;
        private frmUnidad FormInstanceUni
        {
            get
            {
                if (frmUni == null)
                {
                    frmUni = new frmUnidad();
                    frmUni.MdiParent = this;
                    frmUni.Disposed += new EventHandler(frmCli_Disposed);
                    frmUni.FormClosed += new FormClosedEventHandler(frmCli_FormClosed);
                    frmUni.Load += new EventHandler(frmCli_Load);

                }

                return frmUni;
            }
        }


        void frmUni_Disposed(object sender, EventArgs e)
        {
            frmUni = null;

        }
        void frmUni_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("Se ha cerrado el Formulario");
        }
        void frmUni_Load(object sender, EventArgs e)
        {
            // MessageBox.Show( "Formulario abierto");
        }
#endregion
        
        
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

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario frmUsr = this.FormInstanceUsr;
            // se varifica si el formulario no esta minimizado, en caso de estarlo
            // se lo cambia a un estado normal
            if (frmUsr.WindowState == FormWindowState.Minimized)
                frmUsr.WindowState = FormWindowState.Normal;

            frmUsr.Show();
        }

        private void unidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnidad frmUni = this.FormInstanceUni;
            // se varifica si el formulario no esta minimizado, en caso de estarlo
            // se lo cambia a un estado normal
            if (frmUni.WindowState == FormWindowState.Minimized)
                frmUni.WindowState = FormWindowState.Normal;

            frmUni.Show();
            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frmCli = this.FormInstanceCli;
            // se varifica si el formulario no esta minimizado, en caso de estarlo
            // se lo cambia a un estado normal
            if (frmCli.WindowState == FormWindowState.Minimized)
                frmCli.WindowState = FormWindowState.Normal;

            frmCli.Show();
        }
        public void mostrarElementos()
        {
            string nombre_maquina = Environment.MachineName;
            string fecha = DateTime.Now.ToShortDateString();
            string hora = DateTime.Now.ToLongTimeString();
            lblFecha.Text = fecha;
            lblMaquina.Text = nombre_maquina;
            lblHora.Text = hora;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            mostrarElementos();
        }
    }
}
