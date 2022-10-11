using _03_HelloWorld_EntidadesStandard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _05_HelloWorld_WebForms
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Evento asociado al click del boton Saludar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            clsPersona persona;

            if(String.IsNullOrEmpty(TextBox1.Text))
            {
                Label2.Visible = true;
                Label3.Visible = false;
            }
            else
            {
                persona = new clsPersona(TextBox1.Text);
                Label2.Visible = false;
               
                Label3.Text = "hola " + persona.Nombre;
                Label3.Visible = true;
            }
        }
    }
}