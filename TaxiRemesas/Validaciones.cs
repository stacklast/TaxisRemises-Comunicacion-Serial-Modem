using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TaxiRemesas
{
    public class Validaciones
    {
        #region ///////////////--VALIDACIONES--///////////////
        //VALIDAR SOLO NUMEROS

        public static void SoloNumeros(KeyPressEventArgs pE)
        {
            if (pE.KeyChar == (char)Keys.Space) // espacios en blanco
            {
                pE.Handled = true;

            }
            else
            {
                pE.Handled = false;
            }
            if (char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }
        public static void SoloNumerosConDosDecimales(KeyPressEventArgs pE, TextBox decim)
        {
            if (pE.KeyChar == (char)Keys.Space) // espacios en blanco
            {
                pE.Handled = true;

            }
            else
            {
                pE.Handled = false;
            }

            if (pE.KeyChar == 8)
            {
                pE.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < decim.Text.Length; i++)
            {
                if (decim.Text[i] == ',')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    pE.Handled = true;
                    return;
                }


            }

            if (pE.KeyChar >= 48 && pE.KeyChar <= 57) // 48 al 57 del 0 al 9 en assci
                pE.Handled = false;
            else if (pE.KeyChar == 44) // 46 es (,) en codigo assci
                pE.Handled = (IsDec) ? true : false;
            else
                pE.Handled = true;
        }

        //VALIDAR SOLO LETRAS
        public static void SoloLetras(KeyPressEventArgs pE)
        {
            if (pE.KeyChar == (char)Keys.Space) // espacios en blanco
            {
                pE.Handled = true;
            }
            else
            {
                pE.Handled = false;
            }
            if (Char.IsLetter(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsSeparator(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }

        }
        public static bool es_email(Control mitextbox)
        {

            Regex regex = new Regex(@"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$");

            // Resultado: 
            //       Valid: david.jones@proseware.com 
            //       Valid: d.j@server1.proseware.com 
            //       Valid: jones@ms1.proseware.com 
            //       Invalid: j.@server1.proseware.com 
            //       Invalid: j@proseware.com9 
            //       Valid: js#internal@proseware.com 
            //       Valid: j_9@[129.126.118.1] 
            //       Invalid: j..s@proseware.com 
            //       Invalid: js*@proseware.com 
            //       Invalid: js@proseware..com 
            //       Invalid: js@proseware.com9 
            //       Valid: j.s@server1.proseware.com

            return regex.IsMatch(mitextbox.Text);

        }
        public static bool es_domicilio(Control mitextbox)
        {

            Regex regex = new Regex(@"^.*(?=.*[0-9])(?=.*[a-zA-ZñÑ\s]).*$");

            return regex.IsMatch(mitextbox.Text);

        }

        #endregion
    }
}
