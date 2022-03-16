using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EJERCICIOS_CONDICIONALES
{
    public partial class EJERCICIO_10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncalcular_Click(object sender, EventArgs e)
        {
            //VARIABLES 
                double num_camisas,precio,total_pag,total_compr;

                    //DATOS DE ENTRADA
                        num_camisas = Convert.ToDouble(txtnumcamisas.Text);
                        precio = Convert.ToDouble(txtprecio.Text);
                    
                            //PROCEDIMIENTO
                                total_compr  = num_camisas * precio;
                                if (num_camisas >= 3)
                                {
                                    total_pag = total_compr - total_compr * 0.20;
                                    lbltotalcompra.Text = System.Convert.ToString(total_compr);
                                    lbltotalpag.Text = System.Convert.ToString(total_pag);
                                }
                                else
                                {
                                    total_pag = total_compr - total_compr * 0.10;
                                    lbltotalcompra.Text = System.Convert.ToString(total_compr);
                                    lbltotalpag.Text = System.Convert.ToString(total_pag);
                                }            
        }
    }
}