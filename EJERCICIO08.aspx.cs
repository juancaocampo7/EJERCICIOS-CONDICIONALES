using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EJERCICIOS_CONDICIONALES
{
    public partial class EJERCICIO8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncalcular_Click(object sender, EventArgs e)
        {
            //VARIABLES 
                double clave,prec_orig,prec_desc;
                char nomb;
            
                    //DATOS DE ENTRADA
                        nomb = Convert.ToChar(txtnomart.Text);
                        clave = Convert.ToDouble(txtclave.Text);
                        prec_orig = Convert.ToDouble(txtpreorig.Text);

                            //PROCEDIMIENTO
                                if (clave == 01)
                                {
                                    prec_desc = prec_orig - prec_orig * 0.10;
                                    lblnomart.Text = System.Convert.ToString(nomb);
                                    lblclave.Text = System.Convert.ToString(clave);
                                    lblpreorig.Text = System.Convert.ToString(prec_orig);
                                    lblpredesc.Text = System.Convert.ToString(prec_desc);
                                }
                                else 
                                    if (clave == 02)
                                {
                                    prec_desc = prec_orig - prec_orig * 0.20;
                                    lblnomart.Text = System.Convert.ToString(nomb);
                                    lblclave.Text = System.Convert.ToString(clave);
                                    lblpreorig.Text = System.Convert.ToString(prec_orig);
                                    lblpredesc.Text = System.Convert.ToString(prec_desc);
                                }
        }
    }
}