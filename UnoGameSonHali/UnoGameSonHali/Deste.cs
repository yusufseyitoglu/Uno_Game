using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnoGame
{
    class Deste
    {


        public Kart[] kartlar = new Kart[18];
        int cekilenKS = 0;

        public string[] tumKartlar = { "k1", "k2", "k3", "k4", "k5", "m1", "m2", "m3", "m4", "m5", "s1", "s2", "s3", "s4", "s5", "rd", "rd", "rd" };

        public string[] oyuncu1kartlari = new string[6];
        public string[] oyuncu2Kartlari = new string[6];
        public string[] oyuncu3Kartlari = new string[6];
        public void Olustur()
        {
            Random r = new Random();



            int a = 0, b = 0, c = 0; /*turDurumu = 1; */ 
            while (true)
            {
                if (a < 6)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        int uretilen = r.Next(0, 18);
                        if (tumKartlar[uretilen] != "bos")
                        {
                            oyuncu1kartlari[a] = tumKartlar[uretilen];
                            tumKartlar[uretilen] = "bos";
                            a++;
                        }
                        else
                        {
                            i = i - 1;
                        }
                    }
                }
                else if (b < 6)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        int uretilen = r.Next(0, 18);
                        if (tumKartlar[uretilen] != "bos")
                        {
                            oyuncu2Kartlari[b] = tumKartlar[uretilen];
                            tumKartlar[uretilen] = "bos";
                            b++;
                        }
                        else
                        {
                            i = i - 1;
                        }
                    }
                }
                else if (c < 6)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        int uretilen = r.Next(0, 18);
                        if (tumKartlar[uretilen] != "bos")
                        {
                            oyuncu3Kartlari[c] = tumKartlar[uretilen];
                            tumKartlar[uretilen] = "bos";
                            c++;
                        }
                        else
                        {
                            i = i - 1;
                        }
                    }
                }
                else
                {
                    break;
                }
            }

        }

        public void karistir()
        {
            Random sayiGen = new Random();
            for (int k = 0; k < 18; k++)
            {
                int rIndis = sayiGen.Next(0, 18);
                Kart gecici = kartlar[k];
                kartlar[k] = kartlar[rIndis];
                kartlar[rIndis] = gecici; /* yeni bir kart destesi olusturup rasgele diziyor*/
            }
        }
        public Kart kartCek()
        {

            return kartlar[cekilenKS++];

        }





    }
}
