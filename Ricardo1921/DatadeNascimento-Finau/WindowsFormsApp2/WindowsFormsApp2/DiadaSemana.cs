using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    
    class DiadaSemana
    {
        private DateTime tempodevida;

        public string recebe
        {
            set
            {
                tempodevida = Convert.ToDateTime(value);
            }
        }

        public string envia
        {
            get
            {
                DateTime hoje = DateTime.Now;
                int anos = hoje.Year - tempodevida.Year;
                int meses = hoje.Month - tempodevida.Month;
                int dias = hoje.Day - tempodevida.Day;
                if (dias<0)
                {
                    anos--;
                    meses += 12;
                }
                string frase = " A sua Idade é" + anos.ToString() + "anos";
                frase += anos.ToString() + "anos";
                frase += meses.ToString() + "meses";
                frase += dias.ToString() + "dias";
                return frase;
            }
        }
       

    }
}
