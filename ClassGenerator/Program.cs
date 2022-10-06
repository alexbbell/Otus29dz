using System;
using ClassGenerator.Models;

namespace ClassGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            House house = new House("dom 1", 100);
            House house2 = house.Copy();


            Console.WriteLine($"house 2: {house2.Name}, square: {house2.Square}");
            Console.WriteLine($"house 1: {house.Name}, square: {house.Square}");

            Cottage cottage = new Cottage("50", 150, true);
            Console.WriteLine($"cottage: {cottage.Name}, {cottage.Square}, {cottage.IsParking}");
            var cottage2 = cottage.Copy();
            cottage2.Square = 250;
            Console.WriteLine($"cottage: {cottage2.Name}, {cottage2.Square}, {cottage2.IsParking}");

            Neboscreb neboscreb = new Neboscreb(house.Name, house.Square, true, 13);
            Console.WriteLine($"neboscreb 1: {neboscreb.Name}, square: {neboscreb.Square}, is parking: {neboscreb.IsParking}");
            
            Neboscreb neboscreb2 = (Neboscreb)neboscreb.Copy();
            neboscreb2.IsParking = false;
            Console.WriteLine($"neboscreb 2: {neboscreb2.Name}, square: {neboscreb2.Square}, is parking: {neboscreb2.IsParking}");
            

        }
    }
}
