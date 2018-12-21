using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int kassa = 5000;
            void EmirleriGoster()
            {
                Console.WriteLine("1.ci kassadaki pul miqdarini goster");
                Console.WriteLine("2. ci isiq pulunu ode");
                Console.WriteLine("3 cu qaz pulunu ode");
                Console.WriteLine("4 cu suz pulunu ode");
                Console.WriteLine("5 cix");
                Console.WriteLine("------Emelliyat secin");
            }
            string EmelyatSecin()
            {
                Console.WriteLine("Emelyat nomresini daxil edin : ");
                string emelyatNomresi = Console.ReadLine();
                return emelyatNomresi;

            }
            void KassadakiPuluGoster()
            {
                Console.WriteLine("Kassadaki pul miqdari :{0}", kassa);
            }

            void IsiqPulunuOde()
            {
                Console.WriteLine("Ne qeder odeme edeceksiniz?");
                string odeme = Console.ReadLine();
                kassa = kassa - Convert.ToInt32(odeme);
                KassadakiPuluGoster();
                EmirleriGoster();
                switch (EmelyatSecin())
                {
                    case "1":
                        KassadakiPuluGoster();
                        break;
                    case "2":
                        IsiqPulunuOde();
                        break;
                    case "3":
                        QazPulunuOde();
                        break;
                    case "4":
                        SuPulunuOde();
                        break;
                    case "5":
                        cix();
                        break;
                    default:
                        Console.WriteLine("Duzgun emelyat secmisiniz");
                        break;
                }
            }
            void QazPulunuOde()
            {
                Console.WriteLine("Ne qeder odeme edeceksiniz?");
                string odeme = Console.ReadLine();
                kassa = kassa - Convert.ToInt32(odeme);
                KassadakiPuluGoster();
                EmirleriGoster();
                switch (EmelyatSecin())
                {
                    case "1":
                        KassadakiPuluGoster();
                        break;
                    case "2":
                        IsiqPulunuOde();
                        break;
                    case "3":
                        QazPulunuOde();
                        break;
                    case "4":
                        SuPulunuOde();
                        break;
                    case "5":
                        cix();
                        break;
                    default:
                        Console.WriteLine("Duzgun emelyat secmisiniz");
                        break;
                }


            }
            void SuPulunuOde()
            {
                Console.WriteLine("Ne qeder odeme edeceksiniz");
                string odeme = Console.ReadLine();
                kassa = kassa - Convert.ToInt32(odeme);
                KassadakiPuluGoster();
                EmirleriGoster();
                switch (EmelyatSecin())
                {
                    case "1":
                        KassadakiPuluGoster();
                        break;
                    case "2":
                        IsiqPulunuOde();
                        break;
                    case "3":
                        QazPulunuOde();
                        break;
                    case "4":
                        SuPulunuOde();
                        break;
                    case "5":
                        cix();
                        break;
                    default:
                        Console.WriteLine("Duzgun emelyat secmisiniz");
                        break;
                }


            }
            void cix()
            {
                Environment.Exit(1);

            }

            EmirleriGoster();

            switch (EmelyatSecin())
            {
                case "1":
                    KassadakiPuluGoster();
                    break;
                case "2":
                    IsiqPulunuOde();
                    break;
                case "3":
                    QazPulunuOde();
                    break;
                case "4":
                    SuPulunuOde();
                    break;
                case "5":
                    cix();
                    break;
                default:
                    Console.WriteLine("Duzgun emelyat secmisiniz");
                    break;
            }
        }
    }
}
