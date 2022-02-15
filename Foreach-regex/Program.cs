using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace @foreach
{
    public class Program
    {
        static void Main(string[] args)
        {
            //String externer verweiss 
            string bar1 = "12345";
            string bar2 = "12a45678";
            string bar3 = "123456";

            //string einlesen
            string[] barcode = new string[7];
            barcode[0] = bar1;
            barcode[1] = bar2;
            barcode[2] = bar3;
            barcode[3] = "";
            barcode[4] = "122256";
            barcode[5] = "12345678";
            barcode[6] = "a12345";

            //Regex anlegen
            Regex regex = new Regex(@"^(123)\d(5)[0-9]{3}$");

            //foreach schleife - erst String[](Barcode) in schleife zu String (s) konvertiren
            foreach (string s in barcode)
            {
                //foreach schleife von String (s) richtung Regex 
                foreach (Match match in regex.Matches(s))
                { Console.WriteLine(s); }
            }
            Console.ReadLine();
            // kein "if" oder "goto" notwendig !
        }
    }
}
