using System;
using System.Collections;
using System.Collections.Generic;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.collections namespace

            ArrayList liste = new ArrayList();
            liste.Add("Ayşe");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');

            //içerisindeki verilere erişim
            Console.WriteLine(liste[1]);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Addrange
            Console.WriteLine("**** Add Range ****");
            string[] renkler = {"kırmızı", "sarı", "yesil"};
            List<int> sayılar = new List<int>(){1,8,3,7,9,92,5};
            liste.AddRange(renkler);
            liste.AddRange(sayılar);
            
            foreach (var item in liste)
                Console.WriteLine(item);

            //Sort
            Console.WriteLine("**** Sort ****");
            Console.WriteLine("<<<<< listede farklı veri tipleri varsa SORT komutu hata verebilir <<<<<<");
            liste.Sort(); //<<<<< listede farklı veri tipleri varsa SORT komutu hata verebilir <<<<<<

            foreach (var item in liste)
                Console.WriteLine(item);

            //Binary Search (binary search sıralama işlemi yapıldığında kullanılabilir(sort vs ile))
            Console.WriteLine("**** Binary Search ****");
            Console.WriteLine(liste.BinarySearch(9));

            //Reverse(ters çevirir)
            Console.WriteLine("**** Reverse ****");
            liste.Reverse();
            foreach (var item in liste)
                Console.WriteLine(item);
            
            //Clear
            Console.WriteLine("**** Clear ****");
            liste.Clear();
        }
    }
}
