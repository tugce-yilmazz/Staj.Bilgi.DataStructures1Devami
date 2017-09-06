using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SetGetMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            dortgen d1 = new dortgen();
            //ve artık private olan değişkenlerimize değer atamaları yapabiliriz..
            //ve onlara istediğimiz gibi set ve get metodu ile ulaşabiliriz.
            d1.En = 52;
            d1.boy = 152;
            //ekrana yazdıralım
            Console.WriteLine("En : " + d1.En);
            Console.WriteLine("Boy : " + d1.boy);
            Console.ReadLine();
        }
    }
}
    class dortgen
    {
        //private: oluşturulan değişkenlere sadece o class içinde ulaşılabilir.
        private int mBoy;
        private int mEn;
        //meodumuzu oluşturalımki ve private nesnelerimize değer atayabilelim
        public int En {
            get {  return mEn; }
            //önce set metodu çalışacak. sonra get metodu ile değişken geri döndürülecek.
            set {  mEn = value; }
        }
        public int boy {
            get {  return mBoy; }
            set  {  mBoy = value; }
        }
    }
