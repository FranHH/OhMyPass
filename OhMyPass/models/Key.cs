using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhMyPass.models
{
    [Serializable]
    class Key
    {
        #region Constructores
        public Key(string key)
        {
            this.key=key;
        }
        public Key(){}
        #endregion

        #region GET & SET
        public string key { get; set; }
        #endregion
    }
}
