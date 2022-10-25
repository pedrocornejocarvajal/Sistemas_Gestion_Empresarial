using Entidades;

namespace DAL
{
    public class clsListadosDepartamentosDAL
    {

        /// <summary>
        /// Accedemos a la base de datos y devolvemos un listado completo de los departamentos
        /// Precondiciones: la base de datos esta disponible
        /// Postcondiciones: ninguna
        /// </summary>
        /// <returns> List<clsDepartamentos> </returns>
        /// 
        public List<clsDepartamentos> ListadoCompletoDepartamentos()
        {
            List<clsDepartamentos> lista = new List<clsDepartamentos>();


            lista.Add(new clsDepartamentos(1,"Finanzas"));
            lista.Add(new clsDepartamentos(2, "RRHH"));
            lista.Add(new clsDepartamentos(3, "Marqueting"));
            lista.Add(new clsDepartamentos(4, "Transportes"));


            return lista;
        }
    }
}