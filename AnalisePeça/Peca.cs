using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisePeça
{
    public class Peca
    {

        public static double chapa_vazia1 = 1.052;
        public static double chapa_vazia2 = 1.072;

        private string Numero {get; set;}
        private string Data_envio { get; set; }
        private string Tipo { get; set; }
        private double larg_cru { get; set; }
        private double gram_cru {get; set;}
        private double larg_acabado { get; set; }
        private double gram_acabado { get; set; }
        private string cor { get; set; }
        public double qntd_oleo { get; set; }
        public double peso_amostra1 { get; set; }
        public double peso_amostra2 { get; set; }


        public string  calcOleo(double oleo_cp1, double oleo_cp2, double amostra, double amostra2)
        {
            double peso_chapa1 = chapa_vazia1;
            double peso_chapa2 = chapa_vazia2;
            double oleoChapa1 = oleo_cp1;
            double oleoChapa2 = oleo_cp2;
            double pesoAmostra1 = amostra;
            double pesoAmostra2 = amostra2;

            //calculo
            double md_oleo1 = (oleoChapa1 - peso_chapa1);
            double md_oleo2 = (oleoChapa2 - peso_chapa2) * (100 / pesoAmostra2);

            double md_oleoTotal = (md_oleo1 + md_oleo2) / 2;

            string media = " Media de Óleo da Amostra 1: " + md_oleo1;

            return media;
        }


      



    }
}
