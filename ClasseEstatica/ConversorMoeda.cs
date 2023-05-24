using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseEstatica
{
    public static class ConversorMoeda
    {
        public static float real = 0.1986f;
        private static float dollar = 5;
        public static float conversao;


        public static float RealToDollar(float realUser){

            conversao = realUser * real;

            return conversao;

        }

        public static float DollarToReal(float dollarUser){

            conversao = dollarUser * dollar;

            return conversao;

        }


    }
}