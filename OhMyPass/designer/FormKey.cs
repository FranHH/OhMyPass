using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OhMyPass
{
    public partial class FormKey : Form
    {
        #region Declaracion de variables y objetos
        public bool confirmar = false, cerrado=false, forceClouse=false;
        #endregion

        #region Constructor
        public FormKey()
        {
            InitializeComponent();
            this.FormClosing += FormKey_FormClosing;
        }
        #endregion

        #region FormClosing
        private void FormKey_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (cerrado){}
            else
            {
                DialogResult result = MessageBox.Show("¿Desea salir?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    this.Dispose(true);
                    forceClouse = true;
                    this.Close();
                }
            } 
        }
        #endregion

        #region ReturnKey
        public string ReturnKey()
        {
            if (tbKEY.Text.Length != 4 )
            {
                MessageBox.Show("El PIN debe ser de 4 digitos numericos",
                                "ATENCION",
                                MessageBoxButtons.OK);
            }
            else if (!Regex.IsMatch(tbKEY.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("El PIN debe ser numerico",
                               "ATENCION",
                               MessageBoxButtons.OK);
            }
            return tbKEY.Text;
        }
        #endregion

        #region Evento CLICK
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!ReturnKey().Equals(""))
            {
                confirmar = true;
                cerrado = true;
                this.Close();
            }
        }
        private void btnVerOcul_Click(object sender, EventArgs e)
        {
            if (tbKEY.PasswordChar == '*')
            {
                tbKEY.PasswordChar = '\0';
                btnVerOcul.Image = null;
                btnVerOcul.Image = global::OhMyPass.Properties.Resources.ojo;
            }
            else
            {
                tbKEY.PasswordChar = '*';
                btnVerOcul.Image = null;
                btnVerOcul.Image = global::OhMyPass.Properties.Resources.ver;
            }
            tbKEY.Focus();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cerrado = true;
            forceClouse = true;
            this.Close();
        }
        #endregion

    }
}
