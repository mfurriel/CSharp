using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaIdade
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe o dia em que você nasceu (dd//mm/aaaa) : ");
            DateTime dtNasc = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(dtNasc.ToString());
            Console.WriteLine("Sua idade é {0:d} anos ", (DateTime.Now.Subtract(dtNasc).Days / (365)));
            Console.ReadLine();
            //int diaHoje = DateTime.Now.Day;
            //int mesHoje = DateTime.Now.Month;
            //int anoHoje = DateTime.Now.Year;

            //int diaNasc = 0, mesNasc = 0, anoNasc = 0, idade = 0;

            //Console.WriteLine("Informe o dia do seu aniversario (dd/mm/aaaa) : ");
            //string dtNascimento = Console.ReadLine();
            //string[] dtNasc = dtNascimento.Split('/');

            //for (int i = 0; i < dtNasc.Length; i++)
            //{
            //    if(i == 0)
            //    {
            //        diaNasc = Convert.ToInt32(dtNasc[i]);
            //    }
            //    else if (i == 1)
            //    {
            //        mesNasc = Convert.ToInt32(dtNasc[i]);
            //    }
            //    else if (i == 2)
            //    {
            //        anoNasc = Convert.ToInt32(dtNasc[i]);
            //    }
            //}

            //idade = anoHoje - anoNasc;

            //if((mesHoje < mesNasc) || ((mesHoje == mesNasc) && (diaHoje >= diaNasc)))
            //{
            //    idade--;
            //}

            //Console.WriteLine("Sua idade é {0} anos", idade);
            //// Console.WriteLine("Sua idade é " + idade + " anos"); ambos funcionam. 
            //Console.ReadLine();

        }
    }
}
