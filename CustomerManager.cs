using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Ekleme (Customer customer2)
        {
            Console.WriteLine("Yeni Müşteri Bilgilerini Giriniz: ");
            customer2.Name = Console.ReadLine();
            customer2.Surname = Console.ReadLine();
            customer2.Id = Convert.ToInt32(Console.ReadLine());
            customer2.Job = Convert.ToBoolean(Console.ReadLine());
            customer2.Salary = Convert.ToDouble(Console.ReadLine());
            
        }
        public void Cikarma (Customer customer)
        {
            Console.WriteLine("Çıkarılıcak Müşterinin ID Numarasını Giriniz: ");
            customer.Id = Convert.ToInt32(Console.ReadLine());        
            //Delete İşlemleri gelecek
        }
        public void Güncelleme(Customer customer) //Yüzeysel bir yazımdır zaman içinde geliştirilecek
        {
            string[] alan1 = new string[] { "name", "surname", "Id", "job", "salary" };
            string alan;
            string newstring;
            int newint;
            Console.WriteLine("Güncellenecek Alanı Giriniz: ");
            alan = Console.ReadLine();
            if (alan == alan1[0]) 
            {
                
                Console.WriteLine("Güncellenecek Yeni Veriyi Giriniz: ");
                newstring = Console.ReadLine();
                customer.Name = newstring;
                Console.WriteLine("Güncelleme Başarılı");
            }
           
            else if (alan == alan1[1])
            {

                Console.WriteLine("Güncellenecek Yeni Veriyi Giriniz: ");
                newstring = Console.ReadLine();
                customer.Surname = newstring;
                Console.WriteLine("Güncelleme Başarılı");
            }

            else if (alan == alan1[2])
            {
                
                Console.WriteLine("Güncellenecek Yeni Veriyi Giriniz: ");
                newint = Convert.ToInt32(Console.ReadLine());
                customer.Id = newint;
                Console.WriteLine("Güncelleme Başarılı");
            }

            else if (alan == alan1[3])
            {

                Console.WriteLine("Güncellenecek Yeni Veriyi Giriniz: ");
                Boolean newjob = Convert.ToBoolean(Console.ReadLine());
                customer.Job = newjob;
                Console.WriteLine("Güncelleme Başarılı");
            }

            else if (alan == alan1[4])
            {

                Console.WriteLine("Güncellenecek Yeni Veriyi Giriniz: ");
                newint = Convert.ToInt32(Console.ReadLine());
                customer.Salary = newint;
                Console.WriteLine("Güncelleme Başarılı");
            }
            else
            {
                Console.WriteLine("Hatalı İşlem");
            }
            
        }
    }
}
