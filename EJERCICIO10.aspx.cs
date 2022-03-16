using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EJERCICIOS_CONDICIONALES
{
    public partial class EJERCICIO10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncalcular_Click(object sender, EventArgs e)
        {
            //VARIABLES
                double numpza, costopza, totcomp, cantinv, prestamo, credito, interes;
                    
                    //DATOS DE ENTRADA 
                        numpza = Convert.ToDouble(txtnumpzas.Text);
                        costopza = Convert.ToDouble(txtcostopza.Text);
                    
                            //PROCEDIMIENTO 
                                totcomp = numpza * costopza;
                                if (totcomp >= 500000)
                                {
                                    cantinv = totcomp * 0.55;
                                    prestamo = totcomp * 0.30;
                                    credito = totcomp * 0.15;
                                    lblcantinvt.Text = System.Convert.ToString(cantinv);
                                    lblprestamo.Text = System.Convert.ToString(prestamo);
                                    lblcredito.Text = System.Convert.ToString(credito);
                                }
                                else 
                                {
                                    cantinv = totcomp * 0.70;
                                    credito = totcomp * 0.15;
                                    prestamo = 0;
                                    lblcantinvt.Text = System.Convert.ToString(cantinv);
                                    lblcredito.Text = System.Convert.ToString(credito);
                                    lblprestamo.Text = System.Convert.ToString(prestamo);
                                }
                                    interes = credito * 0.20;
                                        
                                        //DATOS DE SALIDA 
                                            lblinteres.Text = System.Convert.ToString(interes);
                                    
        }
    }
}