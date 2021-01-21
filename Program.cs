using System;

namespace ClassMetotDemo
{
    

    class Program
    {//Müşteri Takip Programı
        static void Main(string[] args)
        {

            Customer customer0 = new Customer(); //Sınıfın özelliklerine veri atıyoruz.
            customer0.Id = 3322;
            customer0.Name = "Hasan";
            customer0.Surname = "Güngör";
            customer0.Job = true;
            customer0.Salary = 2220.2;

            Customer customer1 = new Customer();
            customer1.Id = 5566;
            customer1.Name = "Hüseyin";
            customer1.Surname = "Yılmaz";
            customer1.Job = false;
            customer1.Salary = 0.0;



            Console.WriteLine("Kaç Kez İşlem Yapmak İstiyorsunuz: ");
            int girilenislemsayisi = Convert.ToInt32(Console.ReadLine());
            int islemsayisi = 1;
            /////////////////////////////////////////////////

            Customer customer2 = new Customer();
            
            CustomerManager customerManager = new CustomerManager(); //Metotu Çağırıyoruz.
            do
            {
                Console.WriteLine("Hangi İşlemi Yapmak İstiyorsanız O İşlemi Yazınız.");
                Console.WriteLine("Seçenekler: -Ekleme -Silme -Güncelleme -Görüntüleme");
                string islem = Console.ReadLine();
                string ekleme = "ekleme";
                string silme = "silme";
                string güncelleme = "güncelleme";
                string görüntüleme = "görüntüleme";
                if (islem == ekleme)
                {
                    customerManager.Ekleme(customer2); //Metotun içinden bir blok çağırıyoruz.
                    Console.WriteLine("Ekleme Yapıldı");
                }
                else if (islem == silme)
                {
                    customerManager.Cikarma(customer2);
                }
                else if (islem == güncelleme)
                {
                    customerManager.Güncelleme(customer2);
                }
                else if (islem == görüntüleme)
                {
                    Customer[] customers = new Customer[] { customer0, customer1, customer2 }; //Müşterileri Dizi Haline Getirme
                    foreach (var item in customers)
                    {
                        Console.WriteLine(item.Id + " " + item.Name + " " + item.Surname + " " + item.Job + " " + item.Salary);
                        Console.WriteLine("------");
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı İşlem");
                }
                islemsayisi++;
            } while (islemsayisi <= girilenislemsayisi);
           

        }
    }
}
