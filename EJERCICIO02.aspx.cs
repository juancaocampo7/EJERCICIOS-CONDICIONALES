using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EJERCICIOS_CONDICIONALES
{
    public partial class EJERCICIO2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncalcular_Click(object sender, EventArgs e)
        {
            //VARIABLES 
                double cal1, cal2, cal3, prom;
                    //DATOS DE ENTRADA
                        cal1 = Convert.ToDouble(txtcal1.Text);
                        cal2 = Convert.ToDouble(txtcal2.Text);
                        cal3 = Convert.ToDouble(txtcal3.Text);
                            //PROCEDIMIENTO
                                prom = (cal1 + cal2 + cal3)/3;
                                if (prom >= 70.0)
                                {
                                    lblrptausuario.Text = "Alumno Aprobado";
                                    lblprom.Text = System.Convert.ToString(prom);
                                }
                                else if (prom < 70.0) 
                                {
                                    lblrptausuario.Text = "Alumno reprobado";
                                    lblprom.Text = System.Convert.ToString(prom);
                                }
        }       
    }
}