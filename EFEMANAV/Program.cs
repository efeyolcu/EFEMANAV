using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANAVEFE
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArrayList manavmeyve = new ArrayList();
            ArrayList manavsebze = new ArrayList();

            manavmeyve.Add("1)ÇİLEK");
            manavmeyve.Add("2)AYVA");
            manavmeyve.Add("3)KAVUN");
            manavsebze.Add("1)KİRAZ");
            manavsebze.Add("2)BİBER");
            manavsebze.Add("3)SOĞAN");

            double stokÇİLEK = 0;
            double stokAYVA = 0;
            double stokKAVUN = 0;
            double stokKİRAZ = 0;
            double stokBİBER = 0;
            double stokSOĞAN = 0;

        DON:
            Console.WriteLine("*************HOŞGELDİNİZ*************");

            Console.WriteLine("Mevcut durum\n\nÇİLEK:" + stokÇİLEK);
            Console.WriteLine("AYVA:" + stokAYVA);
            Console.WriteLine("KAVUN   :" + stokKAVUN);
            Console.WriteLine("KİRAZ:" + stokKİRAZ);
            Console.WriteLine("BİBER:" + stokBİBER);
            Console.WriteLine("SOĞAN:" + stokSOĞAN);

            Console.WriteLine("\nLütfen seçim yapınız..");

            Console.WriteLine("1) ******HAL****** \n2) ******MANAV******* ");
            int secimhalmanav = Convert.ToInt32(Console.ReadLine());

            #region Hal Bölümü
            if (secimhalmanav == 1)
            {
                Console.WriteLine("******HAL******\nSeçim yapınız..");
                Console.WriteLine("1)MEYVE\n2)SEBZE");
                int halsecim = Convert.ToInt32(Console.ReadLine());
                #region hal-meyve bölümü
                if (halsecim == 1)
                {
                    Console.WriteLine("Meyve seçimi yapınız");
                    foreach (var item in manavmeyve)
                    {

                        Console.WriteLine(item);


                    }
                    double meyvesecim = Convert.ToDouble(Console.ReadLine());
                    if (meyvesecim == 1)
                    {
                        Console.WriteLine("Kaç Kilo Alacaksınız?");
                        double tus4 = Convert.ToDouble(Console.ReadLine());
                        stokÇİLEK += tus4;
                        Console.WriteLine("Satın alındı.");
                        Console.Clear();
                        goto DON;
                    }
                    else if (meyvesecim == 2)
                    {
                        Console.WriteLine("Kaç Kilo Alacaksınız?");
                        double tus5 = Convert.ToDouble(Console.ReadLine());
                        stokAYVA += tus5;
                        Console.WriteLine("Satın alındı.");
                        Console.Clear();
                        goto DON;

                    }

                    else if (meyvesecim == 3)
                    {
                        Console.WriteLine("Kaç Kilo Alacaksınız?");
                        double tus6 = Convert.ToDouble(Console.ReadLine());
                        stokKAVUN += tus6;
                        Console.WriteLine("Satın alındı.");
                        Console.Clear();
                        goto DON;

                       else if (meyvesecim == 4)
                        {
                            Console.WriteLine("Kaç Kilo Alacaksınız?");
                            double tus4 = Convert.ToDouble(Console.ReadLine());
                            stokKİRAZ += tus4;
                            Console.WriteLine("Satın alındı.");
                            Console.Clear();
                            goto DON;

                        }
                    else
                    {

                        Console.WriteLine("Hatalı tuşlama yaptınız.");
                        Console.Clear();
                        goto DON;
                    }

                }
                #endregion
                #region hal-sebze bölümü
                else if (halsecim == 2)
                {
                    Console.WriteLine("Sebze seçimi yapınız");
                    foreach (var item in manavsebze)
                    {

                        Console.WriteLine(item);


                    }
                    double sebzesecim = Convert.ToDouble(Console.ReadLine());
                    
                    }
                    else if (sebzesecim == 1)
                    {
                        Console.WriteLine("Kaç Kilo Alacaksınız?");
                        double tus5 = Convert.ToDouble(Console.ReadLine());
                        stokBİBER += tus5;
                        Console.WriteLine("Satın alındı.");
                        Console.Clear();
                        goto DON;

                    }

                    else if (sebzesecim == 3)
                    {
                        Console.WriteLine("Kaç Kilo Alacaksınız?");
                        double tus6 = Convert.ToDouble(Console.ReadLine());
                        stokSOĞAN += tus6;
                        Console.WriteLine("Satın alındı.");
                        Console.Clear();
                        goto DON;

                    }
                    else
                    {

                        Console.WriteLine("Hatalı tuşlama yaptınız.");
                        Console.Clear();
                        goto DON;
                    }

                }
                #endregion
                else
                {
                    Console.WriteLine("Hatalı seçim yaptınız.");
                    Console.Clear();
                    goto DON;
                }
            }
            #endregion
            #region Manav Bölümü
            else if (secimhalmanav == 2)
            {
                Console.WriteLine("Manav Bölümü\nSeçim yapınız..");
                Console.WriteLine("1)Meyve\n2)Sebze");
                int manavsecim = Convert.ToInt32(Console.ReadLine());
                #region Manav-Meyve Bölümü
                if (manavsecim == 1)
                {
                    Console.WriteLine("Meyve seçimi yapınız");
                    foreach (var item in manavmeyve)
                    {

                        Console.WriteLine(item);


                    }
                    double meyvesecim = Convert.ToDouble(Console.ReadLine());
                    if (meyvesecim == 1)
                    {
                        Console.WriteLine("Kaç Kilo Satacaksınız?");
                        double tus4 = Convert.ToDouble(Console.ReadLine());
                        stokÇİLEK -= tus4;
                        Console.WriteLine("Satış yapıldı");
                        Console.Clear();
                        goto DON;
                    }
                    else if (meyvesecim == 2)
                    {
                        Console.WriteLine("Kaç Kilo Satacaksınız?");
                        double tus5 = Convert.ToDouble(Console.ReadLine());
                        stokAYVA -= tus5;
                        Console.WriteLine("Satış yapıldı.");
                        Console.Clear();
                        goto DON;

                    }

                    else if (meyvesecim == 3)
                    {
                        Console.WriteLine("Kaç Kilo Satacaksınız?");
                        double tus6 = Convert.ToDouble(Console.ReadLine());
                        stokKAVUN -= tus6;
                        Console.WriteLine("Satış yapıldı.");
                        Console.Clear();
                        goto DON;

                    }
                    else
                    {

                        Console.WriteLine("Hatalı tuşlama yaptınız.");
                        Console.Clear();
                        goto DON;
                    }
                    else if (sebzesecim == 1)
                    {
                        Console.WriteLine("Kaç Kilo Satacaksınız?");
                        double tus4 = Convert.ToDouble(Console.ReadLine());
                        stokKİRAZ -= tus4;
                        Console.WriteLine("Satış yapıldı.");
                        Console.Clear();
                        goto DON;
                    }

                }
                #endregion
                #region Hal-Sebze Bölümü
                 if (manavsecim == 2)
                {
                    Console.WriteLine("Sebze seçimi yapınız");
                    foreach (var item in manavsebze)
                    {

                        Console.WriteLine(item);


                    }
                    double sebzesecim = Convert.ToDouble(Console.ReadLine());
                    
                    }
                    else if (sebzesecim == 2)
                    {
                        Console.WriteLine("Kaç Kilo Satacaksınız?");
                        double tus5 = Convert.ToDouble(Console.ReadLine());
                        stokBİBER -= tus5;
                        Console.WriteLine("Satış yapıldı.");
                        Console.Clear();
                        goto DON;

                    }

                    else if (sebzesecim == 3)
                    {
                        Console.WriteLine("Kaç Kilo Satacaksınız?");
                        double tus6 = Convert.ToDouble(Console.ReadLine());
                        stokSOĞAN -= tus6;
                        Console.WriteLine("Satış yapıldı.");
                        Console.Clear();
                        goto DON;

                    }
                    else
                    {

                        Console.WriteLine("Hatalı tuşlama yaptınız.");
                        Console.Clear();
                        goto DON;
                    }

                }
                #endregion
                else
                {
                    Console.WriteLine("Hatalı seçim yaptınız.");
                    Console.Clear();
                    goto DON;
                }
            }
            #endregion
            else
            {
                Console.WriteLine("Hatalı tuşlama yaptınız..");
                Console.Clear();
                goto DON;

            }
        }
        }
}
