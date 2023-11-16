using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Integrais assinado - podem ser negativos
            #region Integrais
            int varUM = -10;
            sbyte varDois = -5;
            short varTres = 10;
            long varQuatro = 40l;

            //Integrais em sinal  - não podem ser negativos

            ushort varCinco = 20;
            byte varSeis = 10;
            uint varSete = 30;
            ulong varOito = 40l;
            #endregion

            // tipos reais
            #region Reais
            float realUm = 10.2f;
            double realDois = 500.56f;


            #endregion
            // tipos Caracteres Char
            #region Caractetere Char

            Char letraUm = 'a';
            //letra a minuscula
            Char letraDois = '\u0041';

            #endregion

            //string
            #region string
            String texto = "Oi tudo bem?Hello Word";
            #endregion
            // var
            #region var

            var valorUm = 100;
            var valorDois = "Amor";
            var valorTres = false;

            #endregion
            //tipo objeto
            #region objeto
            object obj = 100;
            #endregion
            #region prints
            Console.WriteLine(varUM);
            Console.WriteLine(varDois);
            Console.WriteLine(varTres);
            Console.WriteLine(varQuatro);
            Console.WriteLine(varCinco);
            Console.WriteLine(varSeis);
            Console.WriteLine(varSete);
            Console.WriteLine(varOito);
            Console.WriteLine(realUm);
            Console.WriteLine(realDois);
            Console.WriteLine(letraUm);
            Console.WriteLine(letraDois);
            Console.WriteLine(texto);
            Console.WriteLine(valorUm);
            Console.WriteLine(valorDois);
            Console.WriteLine(valorTres);
            Console.WriteLine(obj);
            Console.ReadLine();

            #endregion

        }
    }
}
