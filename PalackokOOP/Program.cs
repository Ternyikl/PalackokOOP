using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalackokOOP
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Palack p1 = new Palack("Coca Cola", 500, 350);

			Palack p2 = new Palack("Sprite", 500);

			Palack p3 = new Palack("Fanta", 500, 0);

			Palack p4 = new Palack("Almalé", 500, 600);

			VisszavalthatoPalack p5 = new VisszavalthatoPalack("Pepsi", 500, 450, 50);

			VisszavalthatoPalack p6 = new VisszavalthatoPalack("Canada Dry", 500, 300);

			Rekesz r1 = new Rekesz(5000);

			r1.uj_Palack(p1);
			r1.uj_Palack(p2);
			r1.uj_Palack(p3);
			r1.uj_Palack(p4);
			r1.uj_Palack(p5);
			r1.uj_Palack(p6);

			Console.WriteLine(r1);

		}
	}
}
