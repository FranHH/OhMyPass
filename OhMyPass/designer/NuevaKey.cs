using OhMyPass.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OhMyPass.designer
{
    public partial class NuevaKey : Form
    {
        #region Variables y objetos
        private bool cerrado = false;
        //private string dirKey = Environment.CurrentDirectory + "\\key.cfg";
        Encriptar encrypt = new Encriptar();
        #endregion

        #region Constructores
        public NuevaKey()
        {
            InitializeComponent();
            this.FormClosing += FormKey_FormClosing;
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
                    this.Close();
                }
            }
        }
        #endregion

        #region Evento Click
        private void btnVerOcultar_Click(object sender, EventArgs e)
        {
            if (tbNuevoPIN.PasswordChar == '*')
            {
                tbNuevoPIN.PasswordChar = '\0';
                btnVerOcultar.Image = null;
                btnVerOcultar.Image = global::OhMyPass.Properties.Resources.ojo;
            }
            else
            {
                tbNuevoPIN.PasswordChar = '*';
                btnVerOcultar.Image = null;
                btnVerOcultar.Image = global::OhMyPass.Properties.Resources.ver;
            }
            tbNuevoPIN.Focus();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cerrado = true;
            this.Close();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¡Atención! Esta acción eliminará el PIN ya existente por el que acabas de introducir." +
                "                                   \n¿Estás seguro de querer modificarlo?",
                                                    "¡ATENCIóN!",
                                                    MessageBoxButtons.YesNoCancel,
                                                    MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                File.Delete(Environment.CurrentDirectory + ConfigurationManager.AppSettings.Get("dirKey"));

                if (tbNuevoPIN.Text.Length != 4)
                {
                    MessageBox.Show("El PIN debe ser de 4 digitos numéricos",
                                    "ATENCIÓN",
                                    MessageBoxButtons.OK);
                }
                else if (!Regex.IsMatch(tbNuevoPIN.Text, @"^[0-9]+$"))
                {
                    MessageBox.Show("El PIN debe ser numérico",
                                    "ATENCIÓN",
                                    MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("PIN guardado correctamente",
                                    "Atención",
                                    MessageBoxButtons.OK);

                    Seguridad(tbNuevoPIN.Text);
                    cerrado = true;
                    this.Close();
                }
            }else if(result == DialogResult.No)
            {
                cerrado = true;
                this.Close();
            }
            else
            {
                cerrado = true;
                this.Close();
            }
        }
        #endregion
   
    }
}
