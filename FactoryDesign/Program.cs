using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{//FactoryDesignPattern

    class Program
    {
        static void Main(string[] args)
        {
            Telefon s8 = TelefonFabrikası.GetTelefon("S8", "2600mah", 4, 7);

            Telefon note8 = TelefonFabrikası.GetTelefon("Note8", "3600mah", 5, 7);

            Console.WriteLine("S8 için telefon özellikleri");
            Console.WriteLine(s8);
            Console.WriteLine("________________________________________________");

            Console.WriteLine("Note8 için telefon özellikleri");
            Console.WriteLine(note8);


            Console.ReadKey();
        }
    }
    class TelefonFabrikası
    {
        public static Telefon GetTelefon(string model, string batarya, int en, int boy)
        {
            Telefon telefon;

            if (model.ToLower() == "S8".ToLower())
            {
                telefon = new S8(model, batarya, en, boy);
            }
            else if (model.ToLower() == "Note8".ToLower())
            {
                telefon = new Note8(model, batarya, en, boy);
            }
            else
            {
                throw new Exception("Geçerli bir model değildir.");
            }
            return telefon;
        }
    }
    interface Telefon
    {
        string GetModel();
        string GetBatarya();
        int getEn();
        int getBoy();
    }
    class S8 : Telefon
    {
        private string model { get; set; }
        private string batarya { get; set; }
        private int en;
        private int boy;

        public S8(string model, string batarya, int en, int boy)
        {
            this.model = model;
            this.batarya = batarya;
            this.en = en;
            this.boy = boy;
        }
        public string GetModel()
        {
            return model;
        }

        public string GetBatarya()
        {
            return batarya;
        }

        public int getEn()
        {
            return en;
        }

        public int getBoy()
        {
            return boy;
        }
        public override string ToString()
        {
            return "S8 (" + "model='" + model + '\'' + ",batarya='" + batarya + '\'' + ", en=" + en + ", boy=" + boy + ')';
        }
    }
    class Note8 : Telefon
    {
        private string model { get; set; }
        private string batarya { get; set; }
        private int en;
        private int boy;

        public Note8(string model, string batarya, int en, int boy)
        {
            this.model = model;
            this.batarya = batarya;
            this.en = en;
            this.boy = boy;
        }
        public string GetModel()
        {
            return model;
        }

        public string GetBatarya()
        {
            return batarya;
        }

        public int getEn()
        {
            return en;
        }

        public int getBoy()
        {
            return boy;
        }
        public override string ToString()
        {
            return "Note8 (" + "model='" + model + '\'' + ",batarya='" + batarya + '\'' + ", en=" + en + ", boy=" + boy + ')';
        }
    }
}