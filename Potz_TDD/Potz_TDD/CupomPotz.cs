using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Potz_TDD
{
    public class CupomPotz
    {
        public string numeroCupom;
        public int qtdePotz;


        public CupomPotz(string identificador)
        {
            numeroCupom = identificador;
        }
        public void quantidadePotz()
        {
            if (numeroCupom.Length == 10)
                qtdePotz = Int32.Parse(numeroCupom.Substring(0, 3));
            else
                if (numeroCupom.Length == 9)
                qtdePotz = Int32.Parse(numeroCupom.Substring(0, 2));
                else
                    qtdePotz = Int32.Parse(numeroCupom.Substring(0, 1));


        }

        public int getPotz()
        {
            return qtdePotz;
        }

        public bool isValido()
        {
            int total = 0;
            int i = 1;
            
            this.numeroCupom = numeroCupom.Replace("-", "");
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