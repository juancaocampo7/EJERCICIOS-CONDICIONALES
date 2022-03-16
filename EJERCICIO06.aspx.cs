using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EJERCICIOS_CONDICIONALES
{
    public partial class EJERCICIO6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncalcular_Click(object sender, EventArgs e)
        {
            //VARIABLES
                int num1, num2;
                    //DATOS DE ENTRADA
                        num1 = Convert.ToInt32(txtnum1.Text);
                        num2 = Convert.ToInt32(txtnum2.Text);
                            //PROCEDIMIENTO 
                                if ( num1 < num2)
                                {
                                    lblrspta.Text = System.Convert.ToString(num1);
                                    lblrspta2.Text = System.Convert.ToString(num2);
                                }
                                else
                                {
                                    lblrspta2.Text = System.Convert.ToString(num2);
                                    lblrspta.Text = System.Convert.ToString(num1);
                                    
                                }
        }
    }
}