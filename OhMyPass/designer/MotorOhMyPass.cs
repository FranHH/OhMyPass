using OhMyPass.models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OhMyPass
{
    public partial class MotorOhMyPass : Form
    {
        #region COMENTADO
        //private string dir = Environment.CurrentDirectory + "\\PassEncrypt.cfg";
        //private string dirKey = Environment.CurrentDirectory + "\\key.cfg";
        #endregion

        #region Definicion de variables y objetos
        private Encriptar encrypt = new Encriptar();
        private SetKey sk = new SetKey();
        private bool cb = false;
        private PassName config;
        private object item = null;
        #endregion

        #region Constructores
        public MotorOhMyPass()
        {
            InitializeComponent();
            Cargar(false);
        }
        #region SIN USO
        public MotorOhMyPass(string newDir)
        {
            InitializeComponent();
            //dir = newDir;
            Cargar(false);
        }
        #endregion

        #endregion

        #region Guardar datos
        private void Guardar()
        {
            try
            {
                //Si no existe el directorio, lo creo
                if (!File.Exists(Environment.CurrentDirectory + ConfigurationManager.AppSettings.Get("dir")))
                {
                    if (cb)
                    {
                        //Guardo en una lista cada nueva pass encriptada.
                        PassName ps = new PassName(encrypt.PassEncrip(tbPass.Text), tbNombre.Text, cbGrupo.SelectedItem.ToString());
                        //Guardo en un fichero la nueva pass encriptada.
                        BinaryFormatter bf = new BinaryFormatter();
                        FileStream archivo = File.OpenWrite(Environment.CurrentDirectory + ConfigurationManager.AppSettings.Get("dir"));
                        bf.Serialize(archivo, ps);
                        archivo.Close();
                        exportar.Enabled = true;
                    }
                    else
                    {
                        //Guardo en una lista cada nueva pass encriptada.
                        PassName ps = new PassName(encrypt.PassEncrip(tbPass.Text), tbNombre.Text, tbGrupo.Text);
                        //Guardo en un fichero la nueva pass encriptada.
                        BinaryFormatter bf = new BinaryFormatter();
                        FileStream archivo = File.OpenWrite(Environment.CurrentDirectory + ConfigurationManager.AppSettings.Get("dir"));
                        bf.Serialize(archivo, ps);
                        archivo.Close();
                        exportar.Enabled = true;
                    }
                }
                else //En caso contrario, si existe, leo el fichero y añado lo nuevo.
                {
                    if (cb)
                    {
                        PassName psNuevo = new PassName(encrypt.PassEncrip(tbPass.Text), tbNombre.Text, cbGrupo.SelectedItem.ToString());

                        BinaryFormatter bf = new BinaryFormatter();
                        FileStream fsRead = File.Open(Environment.CurrentDirectory + ConfigurationManager.AppSettings.Get("dir").ToString(), FileMode.Open);
                        IList<PassName> psCargado = new List<PassName>();

                        while (fsRead.Position < fsRead.Length)
                        {
                            psCargado.Add((PassName)bf.Deserialize(fsRead));
                        }

                        fsRead.Close();
                        psCargado.Add(psNuevo);

                        FileStream fsWriter = File.OpenWrite(Environment.CurrentDirectory + ConfigurationManager.AppSettings.Get("dir").ToString());
                        for (int i = 0; i < psCargado.Count; i++)
                        {
                            bf.Serialize(fsWriter, psCargado[i]);
                        }
                        fsWriter.Close();
                        exportar.Enabled = true;
                    }
                    else
                    {
                        PassName psNuevo = new PassName(encrypt.PassEncrip(tbPass.Text), tbNombre.Text, tbGrupo.Text);

                        BinaryFormatter bf = new BinaryFormatter();
                        FileStream fsRead = File.Open(Environment.CurrentDirectory + ConfigurationManager.AppSettings.Get("dir").ToString(), FileMode.Open);
                        IList<PassName> psCargado = new List<PassName>();

                        while (fsRead.Position < fsRead.Length)
                        {
                            psCargado.Add((PassName)bf.Deserialize(fsRead));
                        }

                        fsRead.Close();
                        psCargado.Add(psNuevo);

                        FileStream fsWriter = File.OpenWrite(Environment.CurrentDirectory + ConfigurationManager.AppSettings.Get("dir").ToString());
                        for (int i = 0; i < psCargado.Count; i++)
                        {
                            bf.Serialize(fsWriter, psCargado[i]);
                        }
                        fsWriter.Close();
                        exportar.Enabled = true;
                    }
                }
                Cargar(true);
            }
            catch (IOException ioe)
            {
                // Create the file, or overwrite if the file exists.
                using (FileStream fs = File.Create(Environment.CurrentDirectory + "\\LogError.txt"))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("Error " + ioe.ToString() + "\nDia : " + DateTime.Now + "\nMensaje : " + ioe.Message);
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }
                MessageBox.Show("¡Atencion!" +
                    "            \nHa ocurrido un problema mientras se guardaba la contraseña. Esto no afecta a ninguna de tus contraseñas." +
                    "            \nPara mas informacion consulta el fichero ",
                                 "¡Atencion!",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Save File Import
        private void SaveFileImport(IList<PassName> psImport)
        {
            try
            {
                //Si no existe el directorio, lo creo
                if (!File.Exists(Environment.CurrentDirectory + ConfigurationManager.AppSettings.Get("dir").ToString()))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    FileStream archivo = File.OpenWrite(Environment.CurrentDirectory + ConfigurationManager.AppSettings.Get("dir").ToString());

                    //Recorro la lista recibida 
                    for (int i = 0; i < psImport.Count; i++)
                    {
                        //Serializo los objetos y los guardo en el fichero
                        bf.Serialize(archivo, psImport[i]);
                    }
                    //Cierro flujo de entrada
                    archivo.Close();
                    exportar.Enabled = true;

                }
                else //En caso contrario, si existe, lo borro y guardo lo nuevo
                {
                    //Borro el fichero
                    File.Delete(Environment.CurrentDirectory + ConfigurationManager.AppSettings.Get("dir").ToString());

                    BinaryFormatter bf = new BinaryFormatter();
                    FileStream archivo = File.OpenWrite(Environment.CurrentDirectory + ConfigurationManager.AppSettings.Get("dir").ToString());

                    //Recorro la lista recibida 
                    for (int i = 0; i < psImport.Count; i++)
                    {
                        //Serializo los objetos y los guardo en el fichero
                        bf.Serialize(archivo, psImport[i]);
                    }
                    //Cierro flujo de entrada
                    archivo.Close();
                    exportar.Enabled = true;


                }
                Cargar(true);
            }
            catch (IOException ioe)
            {
                // Create the file, or overwrite if the file exists.
                using (FileStream fs = File.Create(Environment.CurrentDirectory + "\\LogError.txt"))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("Error " + ioe.ToString() + "\nDia : " + DateTime.Now + "\nMensaje : " + ioe.Message);
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }
                MessageBox.Show("¡Atencion!" +
                    "            \nHa ocurrido un problema mientras se guardaba la contraseña. Esto no afecta a ninguna de tus contraseñas." +
                    "            \nPara mas informacion consulta el fichero ",
                                 "¡Atencion!",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Cargar datos
        private void Cargar(bool ree)
        {
            try
            {
                //Muestro el panel de PIN si no existe ningun PIN
                if (!File.Exists(Environment.CurrentDirectory + ConfigurationManager.AppSettings.Get("dirKey")))
                {
                    SetKey _setKey = new SetKey();
                    _setKey.ShowDialog();
                }
                //Si el fichero no existe no cargo nada.
                if (!File.Exists(Environment.CurrentDirectory + ConfigurationManager.AppSettings.Get("dir"))) { }
                else //En caso contario, abro flujo de entrada y obtengo un listado de datos
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    FileStream fsRead = File.Open(Environment.CurrentDirectory + ConfigurationManager.AppSettings.Get("dir").ToString(), FileMode.Open);
                    IList<PassName> psCargado = new List<PassName>();
                    IList<string> auxGrupo = new List<string>();
                    int cont = 0;
                    //Limpio listas
                    auxGrupo.Clear();
                    
                    cbFiltroGrupo.Enabled = true;
                    btnFiltrar.Enabled = true;
                   
                    cbFiltroGrupo.Items.Clear();
                    //Añado item para volver a mostrar sin filtrar
                    cbFiltroGrupo.Items.Add("Mostrar todos");

                    while (fsRead.Position < fsRead.Length)
                    {
                        psCargado.Add((PassName)bf.Deserialize(fsRead));
                        //Obtengo listado para filtrar por grupo

                        if (!auxGrupo.Contains(psCargado[cont].grupo))
                        {
                            //Si el valor del grupo está vacío no hago nada
                            if (psCargado[cont].grupo.Equals("")) { }
                            else//En caso contrario lo añado al filtro
                            {
                                auxGrupo.Add(psCargado[cont].grupo);
                                cbFiltroGrupo.Items.Add(psCargado[cont].grupo);
                            }
                        }
                        cont++;
                    }
                    //Cierro flujo de entrada
                    fsRead.Close();
                    //Si recargar es true limpio la lista y repinto la lista
                    if ((bool)ree)
                    {
                        lvControl.Items.Clear();
                    }
                    //Recorro la lista 
                    for (int i = 0; i < psCargado.Count; i++)
                    {
                        config = psCargado[i];
                        //Añado la pass leida de fichero al lvControl
                        var item = new ListViewItem(new[] { config.pass, config.name, config.grupo });
                        lvControl.Items.Add(item);
                    }
                    exportar.Enabled = true;
                }
            }
            catch (IOException ioe)
            {
                MessageBox.Show("Ha ocurrido un problema al cargar el listado de contraseña, es posible que se haya perdido el archivo .CSV donde guardaban.\n" + ioe.Message);
            }
        }
        #endregion

        #region EVENTOS

        #region EVENTO CLICK
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text.Equals("") || tbNombre.Text.Equals(" "))
            {
                MessageBox.Show("El campo Nombre no puede estar vacio",
                                "¡Atencion!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else if (tbPass.Text.Equals("") || tbPass.Text.Equals(" "))
            {
                MessageBox.Show("El campo Contraseña no puede estar vacio",
                                "¡Atencion!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else if (cbGrupo.SelectedItem == null)
            {
                MessageBox.Show("Debes seleccionar algun grupo",
                                "¡Atencion!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                if (cbGrupo.SelectedItem.ToString().Equals("Otros"))
                {
                    if (tbGrupo.Text.Equals(""))
                    {
                        MessageBox.Show("Por favor, introduce un nombre para el grupo.",
                                "¡Atencion!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //Añado la nueva pass 
                        var item = new ListViewItem(new[] { encrypt.PassEncrip(tbPass.Text), tbNombre.Text, tbGrupo.Text });
                        lvControl.Items.Add(item);
                        cb = false;
                        Guardar();
                        tbPass.Text = "";
                        tbNombre.Text = "";
                        if (tbGrupo.Enabled)
                        {
                            tbGrupo.Enabled = false;
                            tbGrupo.Text = "";
                        }
                        cbGrupo.SelectedItem = null;
                    }
                }
                else
                {
                    //Añado la nueva pass 
                    var item = new ListViewItem(new[] { encrypt.PassEncrip(tbPass.Text), tbNombre.Text, cbGrupo.SelectedItem.ToString() });
                    lvControl.Items.Add(item);
                    cb = true;
                    Guardar();
                    tbPass.Text = "";
                    tbNombre.Text = "";
                    cbGrupo.SelectedItem = null;
                }
            }
        }
        private void lvControl_Click(object sender, EventArgs e)
        {
            //Habilito el boton para desencriptar la contraseña
            btnDesEncrypt.Enabled = true;
            btnEliminar.Enabled = true;
        }
        private void btnDesEncrypt_Click(object sender, EventArgs e)
        {
            if (lvControl.SelectedItems.Count == 0)
            {
                btnDesEncrypt.Enabled = false;
                MessageBox.Show("No hay ningun elemento seleccionado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Creo un objeto del formulario key
                FormKey fk = new FormKey();
                //Creo un objeto key
                Key _key = new Key();
                //Muestro el formulario
                fk.ShowDialog();
                //Abro flujo de salida y leo el fichero con la key
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fsRead = File.Open(Environment.CurrentDirectory + ConfigurationManager.AppSettings.Get("dirKey"), FileMode.Open);
                //Deserializo el ficheo
                _key = (Key)bf.Deserialize(fsRead);
                fsRead.Close();

                if (!fk.forceClouse)
                {
                    if (fk.confirmar && fk.ReturnKey().Equals(encrypt.PassDesEncrip(_key.key)))
                    {
                        //Obtengo el objeto seleccionado y desencripto la contraseña
                        Encriptar desEncrypt = new Encriptar();

                        try
                        {
                            for (int i = 0; i < lvControl.Items.Count; i++)
                            {
                                if (lvControl.Items[i].Selected)
                                {
                                    MessageBox.Show(desEncrypt.PassDesEncrip(lvControl.Items[i].Text),
                                                    "Password",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Information);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ha ocurrido un problema :( Pero no te preocupes la password sigue encriptada.\n" + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("PIN incorrecto",
                                        "Atencion",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                }
                //Deshabilito el boton despues de mostrar la contraseña desencriptada
                btnDesEncrypt.Enabled = false;
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lvControl.SelectedItems.Count == 0)
            {
                btnEliminar.Enabled = false;
                MessageBox.Show("No hay ningun elemento seleccionado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Muestro un mensaje interactivo
                DialogResult resul = MessageBox.Show("¿Estas seguro que quieres eliminar esta contraseña?",
                                "¡ATENCION!",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Warning);

                if (resul == DialogResult.OK)
                {
                    //Creo un objeto del formulario key
                    FormKey fk = new FormKey();
                    //Creo un objeto key
                    Key _key = new Key();
                    //Muestro el formulario
                    fk.ShowDialog();
                    //Abro flujo de salida y leo el fichero con la key
                    BinaryFormatter bfKey = new BinaryFormatter();
                    FileStream fsReadKey = File.Open(Environment.CurrentDirectory + ConfigurationManager.AppSettings.Get("dirKey"), FileMode.Open);
                    //Deserializo el ficheo
                    _key = (Key)bfKey.Deserialize(fsReadKey);
                    fsReadKey.Close();

                    if (!fk.forceClouse)
                    {
                        if (fk.confirmar && fk.ReturnKey().Equals(encrypt.PassDesEncrip(_key.key)))
                        {
                            //Abro flujo de salida
                            BinaryFormatter bf = new BinaryFormatter();
                            FileStream fsRead = File.Open(Environment.CurrentDirectory + ConfigurationManager.AppSettings.Get("dir").ToString(), FileMode.Open);
                            IList<PassName> psCargado = new List<PassName>();
                            IList<PassName> psFinal = new List<PassName>();

                            IList<string> auxGrupo = new List<string>();

                            //Limpio listas
                            auxGrupo.Clear();
                            cbFiltroGrupo.Items.Clear();
                            cbFiltroGrupo.Items.Add("Mostrar todos");

                            //Leo el fichero y guardo en una lista los datos
                            while (fsRead.Position < fsRead.Length)
                            {
                                psCargado.Add((PassName)bf.Deserialize(fsRead));

                            }
                            //Cierro flujo de salida
                            fsRead.Close();

                            try
                            {
                                //Recorro el listado de control y guardo en un listado todas menos la seleccionada
                                for (int i = 0; i < lvControl.Items.Count; i++)
                                {
                                    if (lvControl.Items[i].Selected) { }
                                    else
                                    {
                                        psFinal.Add(psCargado[i]);
                                    }
                                }
                                //Elimino el fichero si solo habia un item
                                if (psFinal.Count == 0)
                                {
                                    File.Delete(Environment.CurrentDirectory + ConfigurationManager.AppSettings.Get("dir").ToString());
                                    lvControl.Items.Clear();
                                    btnEliminar.Enabled = false;
                                    btnDesEncrypt.Enabled = false;
                                    exportar.Enabled = false;
                                    cbFiltroGrupo.Items.Clear();
                                    cbFiltroGrupo.Enabled = false;
                                    btnFiltrar.Enabled = false;

                                }
                                else //En caso contrario elimino el contenido del listado del control y sobreescribo el fichero
                                {
                                    lvControl.Items.Clear();
                                    cbFiltroGrupo.Items.Clear();
                                    //Añado el valor mostrar todos al filtro
                                    cbFiltroGrupo.Items.Add("Mostrar todos");
                                    FileStream fsWriter = File.Create(Environment.CurrentDirectory + ConfigurationManager.AppSettings.Get("dir").ToString());

                                    for (int i = 0; i < psFinal.Count; i++)
                                    {
                                        config = psFinal[i];
                                        //Añado la pass leida de fichero al lvControl
                                        var item = new ListViewItem(new[] { config.pass, config.name, config.grupo });
                                        lvControl.Items.Add(item);

                                        //Guardo en un fichero la nueva pass encriptada.
                                        bf.Serialize(fsWriter, psFinal[i]);

                                        //Compruebo que no existe el grupo a guardar en el auxiliar
                                        if (!auxGrupo.Contains(psFinal[i].grupo))
                                        {
                                            //Si el valor del grupo está vacío no hago nada
                                            if (psFinal[i].grupo.Equals("")) { }
                                            else//En caso contrario lo añado al filtro
                                            {
                                                auxGrupo.Add(psFinal[i].grupo);
                                                cbFiltroGrupo.Items.Add(psFinal[i].grupo);
                                            }
                                        }
                                    }

                                    //Limpio el listado final, la entrada de datos y cierro flujo de entrada.
                                    psFinal.Clear();
                                    fsWriter.Flush();
                                    fsWriter.Close();

                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ha ocurrido un problema :( Pero no te preocupes la password sigue encriptada.\n" + ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("PIN incorrecto",
                                            "Atencion",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        }
                    }
                }
            }

        }
        private void btnVerOcultar_Click(object sender, EventArgs e)
        {
            if (tbPass.PasswordChar == '*')
            {
                tbPass.PasswordChar = '\0';
                btnVerOcultar.Image = global::OhMyPass.Properties.Resources.ojo;
            }
            else
            {
                tbPass.PasswordChar = '*';
                btnVerOcultar.Image = global::OhMyPass.Properties.Resources.ver;
            }
            tbPass.Focus();
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            //Si no existe el fichero, limpio el listado para filtrar
            if(!File.Exists(Environment.CurrentDirectory + ConfigurationManager.AppSettings.Get("dir").ToString()))
            {
                cbFiltroGrupo.Items.Clear();
            }
            else //En caso contrario leo el fichero y agrego los filtros
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fsRead = File.Open(Environment.CurrentDirectory + ConfigurationManager.AppSettings.Get("dir").ToString(), FileMode.Open);
                IList<PassName> psCargado = new List<PassName>();

                while (fsRead.Position < fsRead.Length)
                {
                    psCargado.Add((PassName)bf.Deserialize(fsRead));
                }
                //Cierro flujo de entrada
                fsRead.Close();

                if (cbFiltroGrupo.SelectedItem == null)
                {
                    MessageBox.Show("No hay ningun grupo seleccionado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (cbFiltroGrupo.SelectedItem != null && !cbFiltroGrupo.SelectedItem.ToString().Equals("Mostrar todos"))
                    {
                        //Limpio el control
                        lvControl.Items.Clear();

                        for (int i = 0; i < psCargado.Count; i++)
                        {
                            if (psCargado[i].grupo.Equals(cbFiltroGrupo.Text.ToString()))
                            {
                                config = psCargado[i];
                                //Añado la pass leida de fichero al lvControl
                                var item = new ListViewItem(new[] { config.pass, config.name, config.grupo });
                                lvControl.Items.Add(item);
                            }

                        }
                        exportar.Enabled = true;

                    }
                    else if (cbFiltroGrupo.SelectedItem.ToString().Equals("Mostrar todos"))
                    {
                        //Limpio el control
                        lvControl.Items.Clear();

                        for (int i = 0; i < psCargado.Count; i++)
                        {
                            config = psCargado[i];
                            //Añado la pass leida de fichero al lvControl
                            var item = new ListViewItem(new[] { config.pass, config.name, config.grupo });
                            lvControl.Items.Add(item);
                        }
                        exportar.Enabled = true;
                    }

                }
            }

            

        }
        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://es.linkedin.com/in/francisco-jose-perez-garcia-0a83151b7");
        }
        private void instagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/fran_.jpg/");
        }
        private void youtuveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/akanaret");
        }
        private void modificarPINToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CambiarKEY _cambiarKey = new CambiarKEY();
            _cambiarKey.ShowDialog();
        }
        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version app : " + Application.ProductVersion + "\nUsuario : " + Environment.MachineName + "\nVersion S.O : " + Environment.OSVersion + "\nTiempo activo del sistema: " + Environment.TickCount + " ms", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void borrarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta accion es irreversible, se borrarán todos los datos guardados, incluido el PIN.\n¿Estás seguro de eliminar el registro?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.No) { }
            else
            {
                //Creo un objeto del formulario key
                FormKey fk = new FormKey();
                //Creo un objeto key
                Key _key = new Key();
                //Muestro el formulario
                fk.ShowDialog();
                //Abro flujo de salida y leo el fichero con la key
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fsRead = File.Open(Environment.CurrentDirectory + ConfigurationManager.AppSettings.Get("dirKey"), FileMode.Open);
                //Deserializo el ficheo
                _key = (Key)bf.Deserialize(fsRead);
                fsRead.Close();

                if (!fk.forceClouse)
                {
                    if (fk.confirmar && fk.ReturnKey().Equals(encrypt.PassDesEncrip(_key.key)))
                    {
                        if (File.Exists(Environment.CurrentDirectory + ConfigurationManager.AppSettings.Get("dir").ToString()))
                        {
                            File.Delete(Environment.CurrentDirectory + ConfigurationManager.AppSettings.Get("dir").ToString());
                            File.Delete(Environment.CurrentDirectory + ConfigurationManager.AppSettings.Get("dirKey"));
                            lvControl.Items.Clear();
                            MessageBox.Show("Datos borados correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Cargar(false);

                        }
                        else
                        {
                            MessageBox.Show("No hay datos que borrar", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("PIN incorrecto",
                                        "Atencion",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnExportar(object sender, EventArgs e)
        {
            Task tarea = null;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "All files (*.*)|*.*|*.txt|*.txt";
            saveFileDialog.FilterIndex = 3;
            saveFileDialog.RestoreDirectory = true;

            try
            {
                //Abro cuadro de dialogo para indicar donde quiero guardar el fichero
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(Environment.CurrentDirectory + ConfigurationManager.AppSettings.Get("dir").ToString()))
                    {
                        //Leo el fichero cvs serializado
                        BinaryFormatter bf = new BinaryFormatter();
                        FileStream fsRead = File.Open(Environment.CurrentDirectory + ConfigurationManager.AppSettings.Get("dir").ToString(), FileMode.Open);
                        IList<PassName> psCargado = new List<PassName>();

                        //Deserializo el fichero csv y guardo los datos en una lista
                        while (fsRead.Position < fsRead.Length)
                        {
                            psCargado.Add((PassName)bf.Deserialize(fsRead));
                        }
                        //Cierro flujo de salida
                        fsRead.Close();

                        if (psCargado.Count == 0)
                        {
                            MessageBox.Show("No hay datos para exportar",
                                            "Info",
                                            MessageBoxButtons.OK);
                        }
                        else
                        {

                            //Leo el fichero de la key y guardo la key junto con el fichero exportado
                            FileStream fsReadKey = File.Open(Environment.CurrentDirectory + ConfigurationManager.AppSettings.Get("dirKey"), FileMode.Open);
                            Key _key = ((Key)bf.Deserialize(fsReadKey));
                            fsReadKey.Close();

                            //Abro flujo de entrada y guardo en un txt los datos
                            StringBuilder sb = new StringBuilder();
                            foreach (var linea in psCargado)
                            {
                                sb.AppendLine(linea.ToString());
                            }

                            sb.AppendLine("PIN --> " + _key.key.GetHashCode());

                            //Creo una tarea para que se la lista en segundo plano.
                            tarea = new Task(() => File.WriteAllText(saveFileDialog.FileName, sb.ToString()));
                            //Inicio la tarea
                            tarea.Start();

                            MessageBox.Show("Fichero exportado con exito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay datos para exportar",
                                        "Atencion",
                                        MessageBoxButtons.OK);
                    }
                }
            }
            catch (System.IO.FileNotFoundException fnfe)
            {
                MessageBox.Show("Ha ocurrido un problme al exportar el fichero :(\n" + fnfe.Message);
            }
        }
        private void importarListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string auxPass = "", auxName = "", auxGrupo = "", auxPIN = "";
                bool salir = false;
                IList<PassName> psImport = new List<PassName>();
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "(*.txt)|*.txt";
                ofd.FilterIndex = 3;
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    StreamReader sr = new StreamReader(ofd.FileName);

                    string line = sr.ReadLine();

                    while (line != null)
                    {
                        if (line.Equals("") || line.Equals(" "))
                        {
                            line = sr.ReadLine();
                        }
                        else
                        {
                            auxPass = line.Replace(" ", "").Replace("Contraseñaencriptada-->", "");
                            line = sr.ReadLine();
                            auxName = line.Replace(" ", "").Replace("Nombre-->", "");
                            line = sr.ReadLine();
                            auxGrupo = line.Replace(" ", "").Replace("Grupo-->", "");
                            line = sr.ReadLine();
                            psImport.Add(new PassName(auxPass, auxName, auxGrupo));
                            //Leo el PIN
                            if (line.Contains("PIN"))
                            {
                                auxPIN = line.Replace(" ", "").Replace("PIN-->", "");
                                line = sr.ReadLine();

                            }
                        }

                    }
                    //Cierro flujo de entrada
                    sr.Close();

                    //Solicito al usuario que inserte el PIN para comprobar que las contraseñas importadas son suyas
                    FormKey _fKey = new FormKey();
                    _fKey.ShowDialog();
                    //Valido el PIN

                    if (_fKey.confirmar && encrypt.PassEncrip(_fKey.ReturnKey()).GetHashCode().ToString().Equals(auxPIN))
                    {
                        //Si existe el fichero lo leo
                        if (File.Exists(Environment.CurrentDirectory + ConfigurationManager.AppSettings.Get("dir").ToString()))
                        {
                            BinaryFormatter bf = new BinaryFormatter();
                            FileStream fsRead = File.Open(Environment.CurrentDirectory + ConfigurationManager.AppSettings.Get("dir").ToString(), FileMode.Open);
                            IList<PassName> psCargado = new List<PassName>();

                            while (fsRead.Position < fsRead.Length)
                            {
                                psCargado.Add((PassName)bf.Deserialize(fsRead));
                            }
                            //Cierro flujo de entrada
                            fsRead.Close();

                            //Ordeno la lista importada y la del fichero local
                            IEnumerable<PassName> psImportEnum = psImport.OrderBy(f => f.name);
                            IEnumerable<PassName> psCargadoEnum = psCargado.OrderBy(f => f.name);
                            IList<PassName> psImportFinal = psImportEnum.ToList();
                            IList<PassName> psCargadoFinal = psCargadoEnum.ToList();
                            int cont = 0;

                            for (int i = 0; i < psImportFinal.Count; i++)
                            {

                                if (!psCargadoFinal.Any(x => x.name == psImportFinal[i].name))
                                {
                                    config = psImportFinal[i];
                                    //Muestro la pass en el control 
                                    var item = new ListViewItem(new[] { config.pass, config.name, config.grupo });
                                    lvControl.Items.Add(item);
                                    //Añado a la lista los nuevos items que no existan en el fichero local
                                    psCargadoFinal.Add(psImportFinal[i]);
                                    cont++;
                                }
                            }
                            MessageBox.Show("Se han añadido " + cont + " nuevos registros.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //Guardo la lista en el fichero local
                            SaveFileImport(psCargadoFinal);

                            exportar.Enabled = true;
                        }
                        else//Si no existe el fichero local, muestro el contenido del fichero importado en el control
                        {
                            int cont = 0;
                            for (int i = 0; i < psImport.Count; i++)
                            {
                                config = psImport[i];
                                //Muestro la pass en el control 
                                var item = new ListViewItem(new[] { config.pass, config.name, config.grupo });
                                lvControl.Items.Add(item);
                                cont++;
                            }
                            MessageBox.Show("Se han añadido " + cont + " nuevos registros.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SaveFileImport(psImport);
                        }

                    }
                    else
                    {
                        MessageBox.Show("El PIN introducido no coincide. Por favor, introduce el PIN que usastes antes de exportar el fichero.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
            }
            catch (IOException ioe)
            {

                using (FileStream fs = File.Create(Environment.CurrentDirectory + "\\LogError.txt"))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("Error " + ioe.ToString() + "\nDia : " + DateTime.Now + "\nMensaje : " + ioe.Message);

                    fs.Write(info, 0, info.Length);
                }
                MessageBox.Show("¡Atencion!" +
                    "            \nHa ocurrido un problema mientras se importaba el fichero. Esto no afecta a ninguna de tus contraseñas." +
                    "            \nPara mas informacion consulta el fichero ",
                                 "¡Atencion!",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }



        }
        private void btnBarra_Click(object sender, EventArgs e)
        {
            if (btnBarra.Text.Equals("Ocultar panel"))
            {
                panel2.Visible = false;
                label5.Location = new System.Drawing.Point(430, 655);
                cbFiltroGrupo.Location = new System.Drawing.Point(525, 646);
                btnFiltrar.Location = new System.Drawing.Point(828, 648);
                lvControl.Size = new System.Drawing.Size(1264, 615);

                btnDesEncrypt.Location = new System.Drawing.Point(8, 646);
                btnEliminar.Location = new System.Drawing.Point(170, 644);
                exportar.Location = new System.Drawing.Point(222, 646);
                btnBarra.Text = "Ver panel";
                
            }
            else
            {
                lvControl.Size = new System.Drawing.Size(1264, 479); 
                panel2.Visible = true;
                label5.Location = new System.Drawing.Point(831, 519);
                cbFiltroGrupo.Location = new System.Drawing.Point(928, 512);
                btnFiltrar.Location = new System.Drawing.Point(1221, 512);

                btnDesEncrypt.Location = new System.Drawing.Point(834, 614);
                btnEliminar.Location = new System.Drawing.Point(1080, 606);
                exportar.Location = new System.Drawing.Point(1233, 614);

                btnBarra.Text = "Ocultar panel";
                

            }

        }
        #endregion

        #region EVENTO SELECTED
        private void cbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            item = cbGrupo.SelectedItem;
            if (item == null)
            {
                tbGrupo.Enabled = false;
            }
            else
            {
                if (item.ToString().Equals("Otros"))
                {
                    tbGrupo.Enabled = true;
                }
                else
                {
                    tbGrupo.Enabled = false;
                }
            }



        }
        #endregion

        #endregion

        #region ShowTimeMessage
        private void showTimeMessage(string text, int duracion)
        {
            using (Timer t = new Timer())
            {
                Timer time = new Timer();
                time.Interval = duracion;
                time.Tick += timeTick;
                time.Start();
            }
        }
        private void timeTick(object sender, EventArgs e)
        {
            (sender as Timer).Stop();  //Detiene el Timer 
        }
        #endregion

        #region OTROS
        private void cbFiltroGrupo_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            //if the item state is selected them change the back color 
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.Yellow);//Choose the color

            // Draw the background of the ListBox control for each item.
            e.DrawBackground();
            // Draw the current item text
            e.Graphics.DrawString(cbFiltroGrupo.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }
        private void Message()
        {
            DialogResult d = MessageBox.Show("Has sido hackiado Mr. " + Environment.UserName + ". \nHe mandado todos los archivos de tu carpeta personal a un servicio en la nube a traves de Wetransfer.\nDona 100.000€ al creador de esta aplicacion en menos de 20 minutos o eliminaré " + Environment.GetFolderPath(Environment.SpecialFolder.System), "¡WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if(d == DialogResult.OK)
            {
                MessageBox.Show("Nah es broma (͠≖ ͜ʖ͠≖)👌");
            }
        
        }
        #endregion
    }
}
