using DAL;
using Entidades;
using System.Security.Principal;

namespace EditarPersona_UI_MVC.Models.ViewModels
{
    public class clsEditarPersonaVM
    {
        

        public List<clsDepartamentos> listadoCompletoDepartamentos { get;}

        public clsPersona persona { get; set; }


    }


}
