using System;

namespace ConsoleApp16
{
    public partial class Program : Phone
    {
        static void Main(string[] args)
        {
            Phone Nvidia = new Phone(79999999999, "RTX2060", 15f, "Дженсен"); //задание №2
            Console.WriteLine("Nvidia " + Nvidia.Model);
            Console.WriteLine(Nvidia.GetNumber(Nvidia.Number));
            Console.WriteLine(Nvidia.Receivecall(Nvidia.Name)); //задание №4
            Console.WriteLine("");
            Nvidia.Receivecall("Дыня" + "136"); //задание №9
            Phone AMD = new Phone(78888888888, "RX590", 13f, "Уолтер"); //задание №2
            ////Console.WriteLine(Intel.Number + Intel.Model + Intel.Weight); 
            Console.WriteLine("AMD " + AMD.Model);
            Console.WriteLine(AMD.GetNumber(AMD.Number));
            Console.WriteLine(AMD.Receivecall(AMD.Name));//задание №4
            Console.WriteLine("");
            AMD.Receivecall("Вишня" + "137"); //задание №9
            Phone Intel = new Phone(77777777777, "I8-60900", 2f, "Гордон"); //задание №2
            ////Receivecall(Name, Number); 
            ////Nvidia.GetNumber(Number); 
            Console.WriteLine("Intel " + Intel.Model);
            ////Console.WriteLine(Intel.Number + Intel.Model + Intel.Weight); 
            Console.WriteLine(Intel.GetNumber(Intel.Number));
            Console.WriteLine(Intel.Receivecall(Intel.Name));  //задание №4
            Console.WriteLine("");
            Intel.Receivecall("Арбуз" + "138"); //задание №9
            sendMessage(79201234125, 79201234126, 79201234127); //задание №10
            static void sendMessage(params long[] parametres)
            {
                foreach (long number in parametres)
                {
                    Console.WriteLine(number);
                }
            } //задание №10
        }
    }
    public class Phone //задание №1
    {
        public long Number; public string Model; public float Weight; public string Name; //задание №1
        public Phone(long number, string model, float weight, string name)
        {
            Number = number;
            Model = model;
            Weight = weight;
            Name = name;

        }
        public Phone(long number, string model, float weight) //задание №5
        {
            Number = number;
            Model = model;
            Weight = weight;

            Phone Nvidia = new Phone(79999999999, "RTX2070"); //задание №8
        }
        public Phone(long number, string model) //задание №6
        {
            Number = number;
            Model = model;
        }
        public Phone() //задание №7
        {
            return;
        }
        public long GetNumber(long number) //задание №4
        {
            return number;
        }
        public string Receivecall(string name)  //задание №4
        {
            string Name = "Звонит" + " " + name;
            return Name;
        }
        public void Receivecall(string name, long number) //задание №9
        {
            Name = name;
            Number = number;
        }
        
    }
}
