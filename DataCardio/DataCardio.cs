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
            calorie = Math.Round(calorie,2);
            return calorie;
        }

        public static double CalorieCorsaCamminata(double km , double kg ,string ris)
        {
            if (ris == "Corsa")
            {
                double calorieCorsa = 0.9 * km * kg;
                return calorieCorsa;
            }
            else if ( ris == "Camminata")
            { 
                double calorieCamminata = 0.5 * km * kg;
                return calorieCamminata;
            }
            else
            {
                return double.NaN;
            }
        }

        public static double MediaBattiti(int battitimensili, int giorni)
        {
            double media = battitimensili / giorni;
            return media;
        }

        public static double BattitiaRiposo(int secondi, int battiti)
        {
            return 60 * battiti / secondi;
        }

        public static int VariabilitaBattito(int[] giorno)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < giorno.Length; i++)
            {
                if (giorno[i] > max)
                    max = giorno[i];
                if (giorno[i] < min)
                    min = giorno[i];
            }
            int diff = max - min;
            return diff;
        }

        public static string Febbre(int battiti, double temperaturamedia)
        {
            string febbre ="";
            if (battiti >= 60 && battiti <= 90)
                febbre = "Non hai la febbre!";
            else if (battiti > 90)
            {
                febbre = "Hai la febbre! Riposati!";
                double diff = battiti - 90;
                temperaturamedia += (diff / 10);
                febbre += $" La tua temperatura corporea è di {temperaturamedia}°";
            }
            return febbre;
        }

    }
}
