using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Util
{
    public class GeneralState
    {
        protected GeneralState()
        {

        }
        public static string ENABLED { get { return "Habilitado"; } }

        public static string DISABLED { get { return "Deshabilitado"; } }
    }
}
