using System;

namespace AbstractFactoryDesign
{

    class Program
    {
        static void Main(string[] args)
        {
            S8Fabrikası s8Fabrika = new S8Fabrikası();
            Telefon s8 = s8Fabrika.GetTelefon("S8", "2600mah", 4, 7);

            Note8Fabrikası note8Fabrika = new Note8Fabrikası();
            Telefon note8 = note8Fabrika.GetTelefon("Note8", "3600mah", 5, 7);

            Console.WriteLine("S8 için telefon özellikleri");
            Console.WriteLine(s8);
            Console.WriteLine("________________________________________________");

            Console.WriteLine("Note8 için telefon özellikleri");
            Console.WriteLine(note8);


            Console.ReadKey();
        }
    }
    interface ITelefonFabrikası
    {
        Telefon GetTelefon(string model, string batarya, int en, int boy);
    }

    interface Telefon
    {
        string GetModel();
        string GetBatarya();
        int getEn();
        int getBoy();
    }
    class S8Fabrikası : ITelefonFabrikası, Telefon
    {
        private string model { get; set; }
        private string batarya { get; set; }
        private int en;
        private int boy;
        public S8Fabrikası()
        {

        }
        public S8Fabrikası(string model, string batarya, int en, int boy)
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

        public Telefon GetTelefon(string model, string batarya, int en, int boy)
        {
            return new S8Fabrikası(model, batarya, en, boy);
        }
    }
    class Note8Fabrikası : ITelefonFabrikası, Telefon
    {
        private string model { get; set; }
        private string batarya { get; set; }
        private int en;
        private int boy;
        public Note8Fabrikası()
        {

        }
        public Note8Fabrikası(string model, string batarya, int en, int boy)
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

        public Telefon GetTelefon(string model, string batarya, int en, int boy)
        {
            return new Note8Fabrikası(model, batarya, en, boy);
        }
    }
}