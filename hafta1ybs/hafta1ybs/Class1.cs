using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta1ybs
{
    internal class Personel
    {
        string ad;
        public string Ad
        { get => ad ;
          set => ad = value; }

        string adres;

        public string Adres
        {  get => adres ; 
           set => adres = value; }

        int yas;

        public int Yas
        { get => yas ;  
          set => yas = value; }

        int mesai;
        public int Mesai { get => mesai ;
        set => mesai = value;}

        public int ucretHesapla()
        {
            return this.mesai * 100;
        }

        public void ucretHesapla(int ekUcret)
        { MessageBox.Show((this.mesai * 100 + ekUcret).ToString()); }
    }
}
