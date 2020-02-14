using System;

namespace DataCardio
{
    public class DataCardio
    {
        public static int CalcoloBattiti (int eta)
        {
            int battitimax = 220 - eta;
            return battitimax;
        }
        public static string Allenamento(int BattitiAttuali) 
        {
            int AllEffMin = BattitiAttuali / 100 * 70;
            int AllEffMax = BattitiAttuali / 100 * 90;
            string risposta;
            if (BattitiAttuali<= AllEffMax && BattitiAttuali>= AllEffMin)
            {
                return risposta = "ti stai allenando bene!";
            }else
            {
                return risposta = $"Ti stai allenando male! Per allenarti bene devi stare tra {AllEffMin} e {AllEffMax}.";
            }
        }
        public static string  FrequenzaCardiacaRiposo(int battiti)
        {
            if (battiti<60)
            {
                
                return "bradicardico";
            }
            else if(battiti>60&&battiti<100)
            {
                return "normale";
            }
            else
            {
                return "tachicardico";
            }
        }
    }
}
