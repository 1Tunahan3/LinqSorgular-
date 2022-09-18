﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqSorguları
{
    class Program
    {
        static void Main(string[] args)
        {

            // 2 tam ye bölünen sayıları ekrana yazdırma

            //int[] dizi = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var result = from x in dizi where (x % 2) == 0 select x;
            //foreach(var indec in result)
            //{
            //    Console.WriteLine(indec);
            //}
            //Console.ReadLine();



            // max ve 0 arasındaki sayilari ekrana bastirma

            //int[] dizi = new int[10] { -1, 5, 13, -5, -4, 2, 51, -78, 1, 7 };

            //var result = from x in dizi where dizi.Max() > x && x > 0 select x;
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}



            //Karesi 10 dan büyük olan sayıları ekrana bastırma

            //int[] dizi = new int[3] { 3, 1, 7 };
            //var result = from x in dizi
            //             let t = x * x
            //             where (t) > 10
            //             select new { x, t };

            //foreach (var tt in result)
            //{
            //    Console.WriteLine(tt.t);
            //}



            //Listedeki sayilari gruplandırma query syntax ve method syntax

            //List<int> list = new List<int>() { 1, 45, 2, 35, 1, 5, 3, 7, 8, 5, 9, 6, 5, 84, 7, 58, 5, 7, 7, 7, 8, 6 };
            //var grup = from x in list
            //           group x by x into y
            //           select y;

            //var grup2 = list.GroupBy(x => x);


            //foreach(var item in grup2)
            //{
            //    Console.WriteLine("sayi:" + item.Key+ "     "  + item.Count()+"kere kullanıldı");
            //}




            //Kullanıcıdan alınan kelimede harfler kaç kere kullanılıyor

            //string kelime;
            //kelime = Console.ReadLine();

            //var grup = from x in kelime
            //           group x by x into y
            //           select y;

            //var grup2 = kelime.GroupBy(x => x);

            //foreach(var item in grup2)
            //{
            //    Console.WriteLine(item.Key +" "+ "harfi  " +item.Count() + " kere geçiyor" );
            //}




            //Number , Number x Frequency , Frequency

            //List<int> sayilistesi = new List<int> { 1, 2, 3, 4, 6, 5, 2, 4, 5, 8, 6, 9, 2, 4, 5, 6, 9, 3, 5, 6, 7, 8, 34, 5, 6, 7, 5 };
            //var list = sayilistesi.GroupBy(x => x);

            //var list2 = from x in sayilistesi
            //            group x by x into y
            //            select y;


            //foreach(var item in list2)
            //{
            //    Console.WriteLine(item.Key+"   " + item.Key*item.Count()+"   " + item.Count());
            //}



            //Şehirler listesinden ilk ve son harf girerek şehir listeleme

            //List<string> cities = new List<string> { "Istanbul", "London", "Paris", "Madrid", "Barselona", "Amsterdam", "Ankara" };
            //string firstletter, lastletter;
            //firstletter = Console.ReadLine();
            //lastletter = Console.ReadLine();
            //var city = from x in cities
            //           where x.StartsWith(firstletter)
            //           where x.EndsWith(lastletter)
            //           select x;

            //var city2 = cities.Where(x => x.StartsWith(firstletter) && x.EndsWith(lastletter));

            //foreach (var item in city2)
            //{
            //    Console.WriteLine(item);
            //}



            //Find all ile listedeki değerlerden belli bir sayıdan büyük olanları listeleme

            //List<int> list = new List<int> { 12, 13, 466, 86, 5, 4, 67, 43, 7, 2, 6, 99, 8 };
            //var biggerthanten = list.FindAll(x => x > 10 ? true : false);

            //foreach(var item in biggerthanten)
            //{
            //    Console.WriteLine(item);
            //}



            //Order by ve take metodlarının kullanımı


            //List<int> list = new List<int> { 12, 14, 5, 7, 9, 46, 55 };
            //var orderedlist = list.OrderBy(x => x);
            //var orderedList2 = from x in list
            //                   orderby x
            //                   select x;

            //foreach (var item in orderedList2.Take(3))
            //{
            //    Console.WriteLine(item);
            //}



            //Girilen Metindeki büyük harfle yazılmış kelimeleri ekrana bastırma

            // Console.WriteLine("bir cümle girin");
            // string metin;

            // metin = Console.ReadLine();
            //  var metinn= BuyukGetir(metin);

            //foreach(var item in metinn)
            // {
            //     Console.WriteLine(item);
            // }



            //  static IEnumerable<string> BuyukGetir(string metin)
            // {
            //     var buyukolanlar = metin.Split().Where(x => String.Equals(x, x.ToUpper()));

            //     return buyukolanlar;
            // }


            //Öğrencilerden istenilen başarı sırasında olanı getirme

            //List<Ogrenci> ogrenciler = new List<Ogrenci>();
            //ogrenciler.Add(new Ogrenci { Id = 1, Name = "Tuna", Grade = 200 });
            //ogrenciler.Add(new Ogrenci { Id = 2, Name = "Tunaha", Grade = 990 });
            //ogrenciler.Add(new Ogrenci { Id = 3, Name = "Tunahan", Grade = 990 });
            //ogrenciler.Add(new Ogrenci { Id = 4, Name = "TunahanK", Grade = 500 });
            //ogrenciler.Add(new Ogrenci { Id = 5, Name = "TunahanKa", Grade = 600 });
            //ogrenciler.Add(new Ogrenci { Id = 6, Name = "TunahanKAy", Grade = 700 });
            //ogrenciler.Add(new Ogrenci { Id = 7, Name = "TunahanKAAYA", Grade = 800 });
            //ogrenciler.Add(new Ogrenci { Id = 8, Name = "TunahanKaya", Grade = 100 });
            //ogrenciler.Add(new Ogrenci { Id = 9, Name = "Tunahanahan", Grade = 300 });
            //ogrenciler.Add(new Ogrenci { Id = 10, Name = "Tunaanah", Grade = 400 });
            //ogrenciler.Add(new Ogrenci { Id = 11, Name = "Tunaanut", Grade = 200 });

            //Console.WriteLine("kaçıncı sırdaki öğrenci");
            //int a;
            //a = Convert.ToInt32(Console.ReadLine());

            //var sortedlist = (from x in ogrenciler
            //                  group x by x.Grade into y
            //                  orderby y.Key descending
            //                  select new
            //                  {
            //                      Record = y.ToList()
            //                  }).ToList();

            //sortedlist[a - 1].Record.ForEach(i => Console.WriteLine("ID {0} , Name: {1}, Puan: {2}",i.Id,i.Name,i.Grade));

            

           

        }

            private class Ogrenci {

            public int Id { get; set; }

            public string Name { get; set; }

            public int Grade { get; set; } }
                                          


    

    }
}
