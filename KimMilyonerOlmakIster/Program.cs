
using System;

namespace KimMilyonerOlmakIster
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kim Milyoner Olmak İster Yarışmamıza Hoşgeldiniz!");
            Console.WriteLine("3 sorudan 2'sini doğru cevaplarsanız 1 Milyon TL'lik büyük ödülü kazanacaksınız. Hazırsanız başlayalım!");

            int Puan = 0; //Doğru cevap sayısına göre ileride işlem yapacağımız için int değeri atıyorum. İleride buna göre kontrol sağlayacağım.

            //İlk Soru

            Console.WriteLine("Boşanma davaları hangi mahkemede açılır?");
            Console.WriteLine("A) Aile Mahkemeleri       B)Sulh Hukuk Mahkemeleri");
            string cevap1 = Console.ReadLine().ToUpper();

            if (cevap1 == "A")
            {
                Puan = Puan + 1;                //Burada doğru cevap vermesi halinde puanı bir arttırmasını söyledim. Başlangıçta puan 0'ken doğru cevap vermesi halinde puanı 1'e yükselecek. İleride şartları sağlarken puanını kontrol edeceğimden her soruda puan kontrolünü yapmalıyız.
                Console.WriteLine("Doğru!");
            }
            else
            {
                Console.WriteLine("Yanlış:(");
            }

            //İkinci Soru

            Console.WriteLine("Hukuk davalarında cevap dilekçesi verme süresi ne kadardır?");
            Console.WriteLine("A) 2 Hafta       B)1 Hafta");
            string cevap2 = Console.ReadLine().ToUpper();

            if (cevap2 == "A")
            {
                Puan = Puan + 1;                    //Puan değerine gene 1 ekliyorum çünkü ilk soruyu hatalı bilmiş olma durumu da var. Puan +1' e 1 ekleseydim ilk soruyu doğru bilmese dahi bu soruyu bildiğinde +2 olacaktı. Bonus puanlı bir soru olsaydı burada +2 diyebilirdik.
                Console.WriteLine("Doğru!");
            }
            else
            {
                Console.WriteLine("Yanlış:(");
            }




            //Şimdi bu kontrollerin yapılmasının ardından farklı bir durumu inceleyeceğim, yani puan durumunu. Bu nedenle ıf kontrolünü int puan değeri üzerinden inceleyeceğim.

    

            if (Puan < 2)                                       //Bu aşamada 2 den düşük puan aldığı için bir soru daha soruyorum. 
            {
                Console.WriteLine("Aşağıdaki suçlardan hangisi şikayete bağlı bir suçtur?");
                Console.WriteLine("A) Hakaret        B) Adam Öldürme");
                string cevap3 = Console.ReadLine().ToUpper();
                if (cevap3 == "A")
                {
                    Puan = Puan + 1;
                    Console.WriteLine("Doğru!");
                }
                else
                {
                    Console.WriteLine("Yanlış:(");
                }
            }

            if (Puan >= 2)
            {
                Console.WriteLine("Tebrikler, büyük ödülü kazandınız");         //Bu aşamada 2 puanı zaten kazandığı için direkt bitiriyoruz. İlk yapışımda = işaretini koyymayı unuttuğumdan bir süre neden yarışmayı kaybettiğimi anlayamadım :)
            }
            else
            {
                Console.WriteLine("Üzgünüz, yarışmayı kaybettiniz");
            }

        }
    }
}
