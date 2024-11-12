using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._10._24
{
    internal class Magazine 
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public string ConTel { get; set; }
        public string ConMail { get; set; }
        public Magazine() { }
        public Magazine(string name, int year, string desc, string cont,string conm)
        {
            Name = name;
            Year = year;
            Description = desc;
            ConTel = cont;
            ConMail = conm;
        }
        public override string ToString()
        {
            return $"Name: {Name}\nYear: {Year}\nDescription: {Description}\nContact Number: {ConTel}\nContact Email: {ConMail}";
        }
        public void Show()
        {
            Console.WriteLine($"Name: {Name}\nYear: {Year}\nDescription: {Description}\nContact Number: {ConTel}\nContact Email: {ConMail}");
        }

    }
}
