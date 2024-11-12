using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._10._24
{
    internal class Shop
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Description { get; set; }
        public string ConTel { get; set; }
        public string ConMail { get; set; }
        public Shop() { }
        public Shop(string name, string adress, string desc, string cont, string conm)
        {
            Name = name;
            Adress = adress;
            Description = desc;
            ConTel = cont;
            ConMail = conm;
        }
        public override string ToString()
        {
            return $"Name: {Name}\nAdress: {Adress}\nDescription: {Description}\nContact Number: {ConTel}\nContact Email: {ConMail}";
        }
        public void Show()
        {
            Console.WriteLine($"Name: {Name}\nAdress: {Adress}\nDescription: {Description}\nContact Number: {ConTel}\nContact Email: {ConMail}");
        }

    }
}
