using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StackOyun
{
    class oyun
    {
        public void doldur(int engeller,ref int[,] dizi)
        {
            for(int i=0;i<25;i++)
            {
                for(int j=0;j<50;j++)
                {
                    dizi[i, j] = 1;
                }
            }
            dizi[0,0] = 5;
            dizi[24, 49] = 6;
            int randomx,randomy;
            Random rnd = new Random();
            
            for (int i=0;i<engeller;i++)
            {
                bir:
                randomx = rnd.Next(1, 24);
                randomy= rnd.Next(1, 49);
                if(dizi[randomx,randomy]==9|| dizi[randomx, randomy] == 5 || dizi[randomx, randomy] == 6)
                {
                    goto bir;
                }
                else
                {
                    dizi[randomx, randomy] = 9;
                }
                //9 Engeller 5 Kendi Yeri 6 Bitiş Noktası 
            }
            
        }
        Random rndd = new Random();
        public void zarat(out int zar)
        {
            
            zar = rndd.Next(1, 4);
        }
    }
}
