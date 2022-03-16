using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EJERCICIOS_CONDICIONALES
{
    public partial class EJERCICIO4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncalcular_Click(object sender, EventArgs e)
        {
            //VARIABLES
            int ht, he, ss;
                //DATOS DE ENTRADA
                    ht = Convert.ToInt32(txthorastraba.Text);
                        //PROCEDIMIENTO 
                            if (ht > 40)
                            {
                                he = ht - 40;
                                ss = he * 20 + 40 * 16;
                            }
                            else 
                            {
                                ss = ht * 16;                
                            }
                                //DATOS DE SALIDA
                                    lblss.Text = System.Convert.ToString(ss);
        }
    }
}