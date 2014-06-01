using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Potz_TDD
{
    public class CupomPotz
    {
        private string numeroCupom;
        private int qtdePotz;

        public CupomPotz(string numeroCupom)
        {
            this.numeroCupom = numeroCupom.Replace("-", "");
            this.qtdePotz = Int32.Parse(numeroCupom.Substring(0,3));
        }

        public int getPotz()
        {
            return qtdePotz;
        }

        public bool isValido()
        {
            int total = 0;
            int i = 1;
            for (int j = numeroCupom.Length - 1; j > 0; j--)
            {
                //Substring na posição j e a quantidade de caracteres que é igual a 1
                total = total + (Int32.Parse(numeroCupom.Substring(j, 1)) * i);
                i++;
            }
            return (total % 11) == 0;
        }
    }
}