using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_In_Wpf
{
    static public class AIService
    {
        static List<string> salam = new List<string> {
            "Salam","Salam necesen?","Aleykum salam"
            };
        static List<string> necesen = new List<string> {
            "Yaxshiyam sen?","Ela , sen necesen?","Bele de"
            };
        static List<string> neVarNeYox = new List<string> {
            "Salamatchiliqdi","Yaxshiliq shukur","Hech, boshluq"
            };
        static List<string> hardasan = new List<string> {
            "Evde sen hardasan?","Dincelirem","Nabrandayam uzurem:)"
            };
        static List<string> randomWords = new List<string> {
            "Darxidim..","Evvela salam","Necesen?"
            };
        static public string GetResponseSalam()
        {
            Random random = new Random();
            int index = random.Next(salam.Count);
            return salam[index];
        }
        static public string GetResponseNecesen()
        {
            Random random = new Random();
            int index = random.Next(necesen.Count);
            return necesen[index];
        }
        static public string GetResponseNeVarNeYox()
        {
            Random random = new Random();
            int index = random.Next(neVarNeYox.Count);
            return neVarNeYox[index];
        }
        static public string GetResponseHardasan()
        {
            Random random = new Random();
            int index = random.Next(hardasan.Count);
            return hardasan[index];
        }
        static public string GetResponse()
        {
            Random random = new Random();
            int index = random.Next(randomWords.Count);
            return randomWords[index];
        }
    }
}

