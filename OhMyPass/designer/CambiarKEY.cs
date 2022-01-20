using OhMyPass.designer;
using OhMyPass.models;
using System;
using System.Configuration;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace OhMyPass
{
    public partial class CambiarKEY : Form
    {
        #region Declaracion de variables
        //private string dirKey = Environment.CurrentDirectory + "\\key.cfg";
        private Encriptar encrypt = new Encriptar();
        private bool cerrado = false;
        #endregion

        #region Constructor
        public CambiarKEY()
        {
            InitializeComponent();
        }
        #endregion

        #region Evento Click
        private void btnVerOcultar_Click(object sender, EventArgs e)
        {
            if (tbViejoPIN.PasswordChar == '*')
            {
                tbViejoPIN.PasswordChar = '\0';
                btnVerOcultar.Image = null;
                btnVerOcultar.Image = global::OhMyPass.Properties.Resources.ojo;
            }
            else
            {
                tbViejoPIN.PasswordChar = '*';
                btnVerOcultar.Image = null;
                btnVerOcultar.Image = global::OhMyPass.Properties.Resources.ver;
            }
            tbViejoPIN.Focus();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (tbViejoPIN.Text.Equals(""))
            {
                MessageBox.Show("Introduce tu PIN",
                                "No has introducido ningún PIN",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Hand);
            }
            else
            {
                //Abro flujo de salida
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fsRead = File.Open(Environment.CurrentDirectory + ConfigurationManager.AppSettings.Get("dirKey"), FileMode.Open);
                Key _key = ((Key)bf.Deserialize(fsRead));
                fsRead.Close();

                if (encrypt.PassDesEncrip(_key.key).Equals(tbViejoPIN.Text))
                {
                    NuevaKey _nuevaKey = new NuevaKey();
                    this.Close();
                    _nuevaKey.ShowDialog();
                    cerrado = true;
                }
                else
                {
                    MessageBox.Show("El PIN introducido no es correcto",
                                     "¡Error!",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                }
            }            
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
