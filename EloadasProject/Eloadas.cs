using System;

namespace EloadasProject
{
    public class Eloadas
    {
        private bool[,] foglalasok;

        public Eloadas(int sorokszama, int helyekszama)
        {
            this.foglalasok = new bool[sorokszama, helyekszama];
            
        }

        public bool[,] Foglalasok { get => foglalasok; set => foglalasok = value; }
        public bool Teli { get => GetTeli(); }
        public int SzabadHelyek { get => GetSzabadHelyek() ; }
        public bool GetTeli()
        {
            for (int k = 0; k < foglalasok.GetLength(0); k++)
            {

                for (int l = 0; l < foglalasok.GetLength(1); l++)
                {

                    if (!foglalasok[k, l])
                    {
                     
                        return true;
                    }
                }

            }
            return false;
        }
        public bool Lefoglal()
        {
            for (int k = 0; k < foglalasok.GetLength(0); k++)
            {

                for (int l = 0; l < foglalasok.GetLength(1); l++)
                {

                    if (!foglalasok[k, l])
                    {
                        foglalasok[k, l] = true;
                        return true;
                    }
                }

            }
            return false;

        }
        public int GetSzabadHelyek()
        {
            int help = 0;
            for (int k = 0; k < foglalasok.GetLength(0); k++)
            {

                for (int l = 0; l < foglalasok.GetLength(1); l++)
                {

                    if (!foglalasok[k, l])
                    {
                        help++;
                    }
                }
            }
            return help;
        }
        public bool Foglalt(int sorszam,int helyszam)
        {
           if(foglalasok[sorszam, helyszam])
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}