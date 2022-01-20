using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhMyPass.models
{
    [Serializable]
    class PassName
    {
        #region Constructores
        public PassName (string pass, string name, string grupo)
        {
            this.pass = pass;
            this.name = name;
            this.grupo = grupo;
            this.id = GenID();
        }
        public PassName(){}
        #endregion

        #region GET & SET
        public string id {get { return GenID(); } set { } }
        public string pass { get; set; }
        public string name { get; set; }
        public string grupo { get; set; }
        #endregion

        #region Metodos
        override
        public string ToString()
        {
            string info = "Contraseña encriptada --> " + pass + " \nNombre --> " + name + " \nGrupo --> " + grupo ;
            return info;
        }
        private string GenID()
        {
            Guid guid = Guid.NewGuid();
            return guid.ToString();
        }
        #endregion
    }
}
