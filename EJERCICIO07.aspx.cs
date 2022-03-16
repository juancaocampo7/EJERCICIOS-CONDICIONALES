using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EJERCICIOS_CONDICIONALES
{
    public partial class EJERCICIO7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncalcular_Click(object sender, EventArgs e)
        {
            //VARIABLES
                double actv, tiempo, cg, dormido = 0, sentado = 1;
                    //DATOS DE ENTRADA
                        actv = Convert.ToDouble(txtactiv.Text);
                        tiempo = Convert.ToDouble(txttiempo.Text);
                            //PROCEDIMIENTO
                                if (actv == dormido)
                                {
                                    cg = 1.08 * tiempo;
                                    lblcg.Text = System.Convert.ToString(cg);
                                }
                                else 
                                    if (actv == sentado)
                                    {
                                       cg = 1.66 * tiempo;
                                        lblcg.Text = System.Convert.ToString(cg);
                                    }
                                        
                                            
        }
    }
}