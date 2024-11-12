using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._10._24
{
    internal class Website
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Description { get; set; }
        public string Ip { get; set; }
        public Website() { }
        public Website(string name, string path, string desc, string ip)
        {
            Name = name;
            Path = path;
            Description = desc;
            Ip = ip;
        }
        public override string ToString()
        {
            return $"Name: {Name}\nPath: {Path}\nDescription: {Description}\nIp: {Ip}";
        }
        public void Show()
        {
            Console.WriteLine($"Name: {Name}\nPath: {Path}\nDescription: {Description}\nIp: {Ip}");
        }

    }
}
