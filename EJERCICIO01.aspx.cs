using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EJERCICIOS_CONDICIONALES
{
    public partial class EJERCICIO1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //VARIABLES
                double p_int, capital, capfinal, interes, respuesta;
                    //DATOS DE ENTRADA
                        capital = Convert.ToDouble(txtcapital.Text);
                        p_int = Convert.ToDouble(txtporcint.Text);
                            //PROCEDIMIENTO 
                                 interes = capital * p_int;
                                    if (interes > 7000)
                                    {
                                        capfinal = capital + interes;
                                        lblrespuesta.Text = "Aprobado para Inventir";
                                        lblcapitalfinal.Text = System.Convert.ToString(capfinal);
                                    }
                                    else if (interes < 7000)
                                    { 
                                        capfinal = capital + interes;
                                        lblrespuesta.Text = "No aprobado para Invertir";
                                        lblcapitalfinal.Text = System.Convert.ToString(capfinal);
                                    }
        }
    }
}