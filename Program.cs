using System;
using System.Collections.Generic;

namespace collections_practice
{
    class Program
    {
        static void Main(string[] args){

            Random rand = new Random();

            int[] newArr = {1,2,3,4,5,6,7,8,9};
            string[] nameArr = {"Tim","Martin","Nikki","Sarah"};
            bool[] boolArr = {true, false, true, false, true, false, true, false, true, false};

            List<string> flavors = new List<string>();
                
                flavors.Add("Mr.chocolate");
                flavors.Add("mint chocolatey-chipity");
                flavors.Add("oreo splash");
                flavors.Add("peanut butter bomb");
                flavors.Add("oranges & toothpaste");

            Console.WriteLine(flavors.Count);

            Console.WriteLine(flavors[2]);
                flavors.RemoveAt(2);

            Console.WriteLine(flavors.Count);

            Dictionary<string,string> iceCreams = new Dictionary<string, string>();
            
            foreach(string name in nameArr){
                iceCreams.Add($"{name}", $"{flavors[rand.Next(flavors.Count)]}");
            }
            foreach(var entry in iceCreams){
                Console.WriteLine(entry.Key+" - "+entry.Value);
            }
        }
    }
}
