using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EJERCICIOS_CONDICIONALES
{
    public partial class EJERCICIO3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncalcular_Click(object sender, EventArgs e)
        {
            //VARIABLES
                double compra, descuento, total_pag;
                    //DATOS DE ENTRADA
                        compra = Convert.ToDouble(txtcompra.Text);
                            //PROCEDIMIENTO    
                                if (compra > 1000)
                                {
                                    descuento = compra * 0.20;
                                }
                                else 
                                {
                                    descuento = 0;
                                }
                                    total_pag = compra - descuento;
                                        //DATOS DE SALIDA
                                            lbltotalpag.Text = System.Convert.ToString(total_pag);         
        }
    }
}