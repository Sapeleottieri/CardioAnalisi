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
        public static string Allenamento(double BattitiAttuali, double BattitiMax) 
        {
            double AllEffMin = BattitiMax / 100 * 70;
            double AllEffMax = BattitiMax / 100 * 90;
            string risposta = "";
            if (BattitiAttuali < AllEffMax && BattitiAttuali > AllEffMin)
            {
                risposta = "Ti stai allenando bene!";
            }else
            {
                risposta = "Ti stai allenando male!";
            }
            return risposta;
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

        public static double CalorieBruciate(string sesso,double anni, double peso, double tempo,double freq)
        {
            double calorie=0;
            if (sesso == "uomo")
            {
                calorie = ((anni * 0.2017) + (peso * 0.199) + (freq * 0.6309) - 55.0969) * tempo / 4.184;                
            }
            else if(sesso == "donna")
            {
                calorie = ((anni * 0.074) + (peso * 0.126) + (freq * 0.4472) - 20.4022) * tempo / 4.184;
            }
            calorie = Math.Round(calorie, 2);
            return calorie;
        }

    }
}
