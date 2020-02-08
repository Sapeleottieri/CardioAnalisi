using System;

namespace DataCardio
{
    public class DataCardio
    {
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
