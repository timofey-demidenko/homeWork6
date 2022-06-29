using System;
using System.Text;
using static System.Console;

namespace homeWork6
{
    //#1
    /*public class Money
    {
        private double euro = 31.17;
        private double doll = 29.53;

        public double grn { get; set; }

        public Money(double grn) { this.grn = grn; }

        virtual public void printEURO(Money money)
        {
            WriteLine($"in EURO - {money.grn / money.euro}");
        }
        virtual public void printDOLL(Money money)
        {
            WriteLine($"in DOLL - {money.grn / money.doll}");
        }


    }

    class Prod : Money
    {
        private double x = 0;
        public Prod(double grn, double x) : base(grn)
        {
            this.x = x;
        }
        public static double operator -(Prod obj)
        {
            return obj.x - obj.grn;
        }
    }*/

    //#2
    /*public class Device
    {
        
    }

    class Kettle : Device
    {
        private string name = "";
        private double weight = 0;
        private double hight = 0;
        private string desciptions = "";

        Kettle(string name, double weight, double hight, string desciptions)
        {
            this.name = name;
            this.weight = weight;
            this.hight = hight;
            this.desciptions = desciptions;
        }
        public void Sound()
        {
            WriteLine("...");
        }

        public void Show()
        {
            WriteLine(name);
        }
        public void Desc()
        {
            WriteLine(desciptions);
        }
    }

    class MicroWave : Device
    {
        private string name = "";
        private double weight = 0;
        private double hight = 0;
        private string desciptions = "";

        MicroWave(string name, double weight, double hight, string desciptions)
        {
            this.name = name;
            this.weight = weight;
            this.hight = hight;
            this.desciptions = desciptions;
        }
        public void Sound()
        {
            WriteLine("...");
        }
        public void Show()
        {
            WriteLine(name);
        }
        public void Desc()
        {
            WriteLine(desciptions);
        }
    }

    class Car : Device
    {
        private string name = "";
        private double weight = 0;
        private double hight = 0;
        private string desciptions = "";

        Car (string name, double weight, double hight, string desciptions)
        {
            this.name = name;
            this.weight = weight;
            this.hight = hight;
            this.desciptions = desciptions;
        }
        public void Sound()
        {
            WriteLine("...");
        }
        public void Show()
        {
            WriteLine(name);
        }
        public void Desc()
        {
            WriteLine(desciptions);
        }
    }

    class Steamer : Device
    {
        private string name = "";
        private double weight = 0;
        private double hight = 0;
        private string desciptions = "";

        Steamer (string name, double weight, double hight, string desciptions)
        {
            this.name = name;
            this.weight = weight;
            this.hight = hight;
            this.desciptions = desciptions;
        }
        public void Sound()
        {
            WriteLine("...");
        }
        public void Show()
        {
            WriteLine(name);
        }
        public void Desc()
        {
            WriteLine(desciptions);
        }
    }*/
    //#3
    public class MusicInstruments
    {
        protected string name = "";
        protected string description = "";
        protected string title = "";

        public MusicInstruments(string name, string description, string title)
        {
            this.name = name;
            this.description = description;
            this.title = title;
        }
        
    }
    class Strings : MusicInstruments
    {
        Strings(string name, string description, string title): base(name, description, title) { }
        public void Sound()
        {
            WriteLine("...");
        }
        public void Show()
        {
            WriteLine(name);
        }
        public void Hist()
        {
            WriteLine(description);
        }
    }

    class Tromb : MusicInstruments
    {
        Tromb(string name, string description, string title): base(name, description, title) { }
        public void Sound()
        {
            WriteLine("...");
        }
        public void Show()
        {
            WriteLine(name);
        }
        public void Hist()
        {
            WriteLine(description);
        }
    }

    class Ukulele : MusicInstruments
    {
        Ukulele(string name, string description, string title): base(name, description, title) { }
        public void Sound()
        {
            WriteLine("...");
        }
        public void Show()
        {
            WriteLine(name);
        }
        public void Hist()
        {
            WriteLine(description);
        }
    }



}