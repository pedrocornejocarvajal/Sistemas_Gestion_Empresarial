using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clsDepartamentos
    {
        #region Atributos
        private String nombreDepartamento { get; set; }

        private int idDepartamento { get; set; }


        #endregion

        #region constructores

        public clsDepartamentos() { }

        public clsDepartamentos(int idDepartamento, String nombre)
        {
            this.idDepartamento = idDepartamento;
            this.nombreDepartamento = nombre;
           
            
        }

        #endregion
    }
}
