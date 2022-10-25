using DAL;
using Entidades;
using System.Security.Principal;

namespace EditarPersona_UI_MVC.Models.ViewModels
{
    public class clsEditarPersonaVM
    {
        #region atributos

        private List<clsDepartamentos> listadoCompletoDepartamentos;
        private clsPersona persona;

        #endregion

        #region propiedades
        public List<clsDepartamentos> ListadoCompletoDepartamentos { get => this.listadoCompletoDepartamentos;}
        public clsPersona Persona { get => persona; set => persona = value; }


        #endregion

        #region contructores

        clsEditarPersonaVM()
        {
            this.persona = clsManejadoraPersonaDAL.obtenerPersonaPorID;
            this.listadoCompletoDepartamentos = clsListadosDepartamentosDAL.ListadoCompletoDepartamentos();

        }

        #endregion

    }


}
