using OhMyPass.models;
using System;
using System.Configuration;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OhMyPass
{
    public partial class SetKey : Form
    {
        #region Declaracion de variables y objetos
        //public string dirSetKey = Environment.CurrentDirectory + "\\key.cfg";
        private Encriptar encrypt = new Encriptar();
        private bool cerrado = false;
        #endregion

        #region Constructores
        public SetKey()
        {
            InitializeComponent();
            this.FormClosing += FormKey_FormClosing;
        }
        #endregion

        #region Closing FORM
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
                    Application.Exit();
                }
            }
        }
        #endregion

        #region Seguridad
        private void Seguridad(string key)
        {
            Key _key = new Key(encrypt.PassEncrip(key));
            FileStream fsWriter = File.OpenWrite(Environment.CurrentDirectory + ConfigurationManager.AppSettings.Get("dirKey"));
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fsWriter, _key);
            fsWriter.Close();
        }
        #endregion

        #region Evento Click
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cerrado = true;
            Application.Exit();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (tbPIN.Text.Equals(tbRepetirPIN.Text))
            {
                if (tbPIN.Text.Length != 4 || tbRepetirPIN.Text.Length != 4)
                {
                    MessageBox.Show("El PIN debe ser de 4 digitos numéricos",
                                    "ATENCIÓN",
                                    MessageBoxButtons.OK);
                }
                else if (!Regex.IsMatch(tbPIN.Text, @"^[0-9]+$") || !Regex.IsMatch(tbRepetirPIN.Text, @"^[0-9]+$"))
                {
                    MessageBox.Show("El PIN debe ser numérico",
                                    "Atención",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("PIN guardado correctamente",
                                    "Info",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Seguridad(tbPIN.Text);
                    cerrado = true;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("El PIN introducido no coincide",
                                "ATENCION",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Hand);
            }
        }
        private void btnVerOcultar_Click(object sender, EventArgs e)
        {
            if (tbPIN.PasswordChar == '*')
            {
                tbPIN.PasswordChar = '\0';
                btnVerOcultar.Image = null;
                btnVerOcultar.Image = global::OhMyPass.Properties.Resources.ojo;
            }
            else
            {
                tbPIN.PasswordChar = '*';
                btnVerOcultar.Image = null;
                btnVerOcultar.Image = global::OhMyPass.Properties.Resources.ver;
            }
            tbPIN.Focus();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (tbRepetirPIN.PasswordChar == '*')
            {
                tbRepetirPIN.PasswordChar = '\0';
                btnVerOcultarRepetir.Image = global::OhMyPass.Properties.Resources.ojo;
            }
            else
            {
                tbRepetirPIN.PasswordChar = '*';
                btnVerOcultarRepetir.Image = global::OhMyPass.Properties.Resources.ver;
            }
            tbRepetirPIN.Focus();
        }

        #endregion

    }
}
