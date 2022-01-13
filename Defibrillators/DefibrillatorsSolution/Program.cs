using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
namespace DefibrillatorsSolution
{
    public class Solution
    {
        static void Main(string[] args)
        {
            string LON = Console.ReadLine() ?? string.Empty;
            string LAT = Console.ReadLine() ?? string.Empty;
            int N = int.Parse(Console.ReadLine() ?? "0");
            var listOfDesfib = new List<string>();
            for (int i = 0; i < N; i++)
            {
                string DEFIB = Console.ReadLine() ?? string.Empty;
                listOfDesfib.Add(DEFIB);
            }

            var resultName = SelectDesfib(LON, LAT, listOfDesfib);
            // Write an answer using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine(resultName);
        }

        public static string SelectDesfib(string lON, string lAT, List<string> listOfInput)
        {
            var listOfDesfib = new List<Desfib>();
            foreach (var input in listOfInput)
            {
                string[] inputSplited = input.Split(';');
                listOfDesfib.Add(new Desfib(inputSplited[0], inputSplited[1], inputSplited[2], inputSplited[3], inputSplited[4].Replace(',', '.'), inputSplited[5].Replace(',', '.')));
            }

            var distances = new Dictionary<double, string>();
            var longitudeClient = Convert.ToDouble(lON.Replace(',', '.'));
            var latitudeClient = Convert.ToDouble(lAT.Replace(',', '.'));

            foreach (var desfib in listOfDesfib)
            {
                var distanceKm = CalculateDistance(longitudeClient, latitudeClient, desfib.Longitude, desfib.Latitude);
                distances.Add(distanceKm, desfib.Name);
            }

            var minDistance = distances.Min(x => x.Key);

            var desfibName = distances.GetValueOrDefault(minDistance) ?? string.Empty;

            return desfibName;
        }

        public static double CalculateDistance(double longitudeClient, double latitudeClient, double longitude, double latitude)
        {
            var xValue = (longitude - longitudeClient) * Math.Cos((latitudeClient + latitude) / 2);
            var yValue = latitude - latitudeClient;
            var dValue = Math.Sqrt(Math.Pow(xValue, 2) + Math.Pow(yValue, 2)) * 6371;
            return Math.Abs(dValue);
        }
    }

    //1;Maison de la Prevention Sante;6 rue Maguelone 340000 Montpellier;;3,87952263361082;43,6071285339217
    public class Desfib
    {
        public Desfib(string id, string name, string address, string contactPhoneNumber, string longitude, string latitude)
        {
            Id = Convert.ToInt32(id);
            Name = name;
            Address = address;
            ContactPhoneNumber = contactPhoneNumber;
            Longitude = Convert.ToDouble(longitude);
            Latitude = Convert.ToDouble(latitude);
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }

        public string ContactPhoneNumber { get; set; }

        public double Longitude { get; set; }

        public double Latitude { get; set; }
    }
}