using Microsoft.AspNetCore.Mvc;
using Proje_OPP.Ornekler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje_OPP.Controllers
{
    public class DefaultController : Controller
    {
        //void islemler()
        //{

        //    Class1 c = new Class1();
        //    c.Topla();


        //}

        int topla()
        {
            int s1 = 20;
            int s2 = 30;
            int sonuc = s1 + s2;

            return sonuc;


        }

        int Cevre()
        {
            int kisakenar = 10;
            int uzunkenar = 20;
            int sonuc = 2 * (kisakenar + uzunkenar);

            return sonuc;
        }

        string cumle()
        {

            string c = "MERHABA ÇAĞRI  HOŞGELDİN";

            return c;




        }

        void MesajListesi(string p)
        {
            ViewBag.v = p;

        }

        void Kullanici (string kullaniciadi)
        {
            ViewBag.v = kullaniciadi;

        }

        int Topla(int s1, int s2)
        {
            int sonuc = s1 + s2;

            return sonuc;


        }

        int Faktoriyel(int p)
        {
            int f = 1;
            for(int i=1; i<=p; i++)
            {
                f = f * i;


            }

            return f;
        }


        void mesajlar()
        {
            ViewBag.m1 = "Merhaba bu bir CORE projesi";
            ViewBag.m2 = "Merhaba proje çok iyi duruyor";
            ViewBag.m3 = "Selamlar hi bonjour";

        }

        public IActionResult Index()
        {

            mesajlar();
            MesajListesi("Parametre İsmi");
            Kullanici("Murat123 ");

            ViewBag.tp = Topla(20,50);

            return View();


        }

        public IActionResult Urunler()
        {
            mesajlar();

            ViewBag.t = topla();
            ViewBag.c = Cevre();
            Kullanici("Murat000 ");
            ViewBag.faktor = Faktoriyel(6);

            return View();

        }

        public IActionResult Musteriler()
        {
            ViewBag.d = cumle();
            Kullanici("Admin123456 ");
            return View();
        }


        public IActionResult Deneme()
        {
            Sehirler sehirler = new Sehirler();


            sehirler.SehirAd = "Kiev";
            sehirler.SehirID = 1;
            sehirler.SehirNufus = 2000000;
            sehirler.Ulke = "UKRAYNA";
            sehirler.Renk1 = "Mavi";
            sehirler.Renk2 = "Sarı";

            ViewBag.v1 = sehirler.SehirID;
            ViewBag.v2 = sehirler.Ulke;
            ViewBag.v3 = sehirler.SehirAd;
            ViewBag.v4 = sehirler.SehirNufus;
            ViewBag.v5 = sehirler.Renk1;
            ViewBag.v6 = sehirler.Renk2;
            ViewBag.v7 = sehirler.Renk3;

            sehirler.SehirID = 2;
            sehirler.SehirAd = "Üsküp";
            sehirler.Ulke = "Makedonya";
            sehirler.SehirNufus = 1000000;
            sehirler.Renk1 = "Kırmızı";
            sehirler.Renk2 = "Sarı";

            ViewBag.z1 = sehirler.SehirID;
            ViewBag.z2 = sehirler.Ulke;
            ViewBag.z3 = sehirler.SehirAd;
            ViewBag.z4 = sehirler.SehirNufus;
            ViewBag.z5 = sehirler.Renk1;
            ViewBag.z6 = sehirler.Renk2;

            return View();

        }
    }
}
