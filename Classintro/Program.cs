﻿using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Osman";
            int yas = 30;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.İzlenmeOrani=68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem VArış";
            kurs2.İzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.İzlenmeOrani = 85;

            //Console.WriteLine(kurs1.KursAdi + "//" + kurs1.Egitmen + "//" + kurs1.İzlenmeOrani+"%");
            //Console.WriteLine(kurs2.KursAdi + "//" + kurs2.Egitmen + "//" + kurs2.İzlenmeOrani + "%");
            //Console.WriteLine(kurs3.KursAdi + "//" + kurs3.Egitmen + "//" + kurs3.İzlenmeOrani + "%");

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + "//" + kurs.Egitmen + "//" + kurs.İzlenmeOrani + "%");
            }

            //Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int İzlenmeOrani { get; set; }
    }
}
