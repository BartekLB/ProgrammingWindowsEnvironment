using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrzewoAVL
{
    public class Drzewo<T> where T : IComparable<T>
    {
        private class Wezel
        {
            public T dane;
            public Wezel lewy;
            public Wezel prawy;
            public int wysokosc;

            public Wezel(T dane)
            {
                this.dane = dane;
                wysokosc = 1;
            }
        }

        private Wezel korzen;

        public void Wstaw(T dane)
        {
            korzen = Wstaw(korzen, dane);
        }

        private Wezel Wstaw(Wezel wezel, T dane)
        {
            if (wezel == null)
            {
                return new Wezel(dane);
            }
            else if (dane.CompareTo(wezel.dane) < 0)
            {
                wezel.lewy = Wstaw(wezel.lewy, dane);
            }
            else if (dane.CompareTo(wezel.dane) > 0)
            {
                wezel.prawy = Wstaw(wezel.prawy, dane);
            }
            else
            {
                return wezel;
            }

            wezel.wysokosc = 1 + Math.Max(ZwrocWysokosc(wezel.lewy), ZwrocWysokosc(wezel.prawy));

            int balans = PobierzBalans(wezel);

            if (balans > 1 && dane.CompareTo(wezel.lewy.dane) < 0)
            {
                return RotacjaWPrawo(wezel);
            }
            if (balans < -1 && dane.CompareTo(wezel.prawy.dane) > 0)
            {
                return RotacjaWLewo(wezel);
            }
            if (balans > 1 && dane.CompareTo(wezel.lewy.dane) > 0)
            {
                wezel.lewy = RotacjaWLewo(wezel.lewy);
                return RotacjaWPrawo(wezel);
            }
            if (balans < -1 && dane.CompareTo(wezel.prawy.dane) < 0)
            {
                wezel.prawy = RotacjaWPrawo(wezel.prawy);
                return RotacjaWLewo(wezel);
            }

            return wezel;
        }

        public bool Szukaj(T dane)
        {
            Wezel wezel = korzen;

            while (wezel != null)
            {
                if (dane.CompareTo(wezel.dane) < 0)
                {
                    wezel = wezel.lewy;
                }
                else if (dane.CompareTo(wezel.dane) > 0)
                {
                    wezel = wezel.prawy;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        private int ZwrocWysokosc(Wezel wezel)
        {
            if (wezel == null)
            {
                return 0;
            }

            return wezel.wysokosc;
        }

        private int PobierzBalans(Wezel wezel)
        {
            if (wezel == null)
            {
                return 0;
            }

            return ZwrocWysokosc(wezel.lewy) - ZwrocWysokosc(wezel.prawy);
        }

        private Wezel RotacjaWLewo(Wezel wezel)
        {
            Wezel praweDziecko = wezel.prawy;
            Wezel lewyWnuk = praweDziecko.lewy;

            praweDziecko.lewy = wezel;
            wezel.prawy = lewyWnuk;

            wezel.wysokosc = 1 + Math.Max(ZwrocWysokosc(wezel.lewy), ZwrocWysokosc(wezel.prawy));
            praweDziecko.wysokosc = 1 + Math.Max(ZwrocWysokosc(praweDziecko.lewy), ZwrocWysokosc(praweDziecko.prawy));

            return praweDziecko;
        }
        private Wezel RotacjaWPrawo(Wezel wezel)
        {
            Wezel leweDziecko = wezel.lewy;
            Wezel prawyWnuk = leweDziecko.lewy;

            leweDziecko.prawy = wezel;
            wezel.lewy = prawyWnuk;

            wezel.wysokosc = 1 + Math.Max(ZwrocWysokosc(wezel.lewy), ZwrocWysokosc(wezel.prawy));
            leweDziecko.wysokosc = 1 + Math.Max(ZwrocWysokosc(leweDziecko.lewy), ZwrocWysokosc(leweDziecko.prawy));

            return leweDziecko;
        }
    }
}