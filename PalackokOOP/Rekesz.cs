using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalackokOOP
{
	internal class Rekesz
	{
		private int max_teherbiras;
		private List<Palack> palackok;

		public Rekesz(int max_teherbiras)
		{
			this.max_teherbiras = max_teherbiras;
			this.palackok = new List<Palack> { };
		}

		public int Max_teherbiras { get => max_teherbiras; set => max_teherbiras = value; }
		public List<Palack> Palackok { get => palackok; set => palackok = value; }

		public double suly()
		{
			double osszSuly = 0;
			if(this.palackok.Count > 0)
			{
				osszSuly = palackok.Sum(x => x.suly());
			}

			return osszSuly;
		}

		public void uj_Palack(Palack palack)
		{
			double jelenlegiSuly = suly();

			if(!(jelenlegiSuly + palack.suly()  > max_teherbiras))
			{
				palackok.Add(palack);
			}
		}

		public int osszes_Penz()
		{
			int osszPenz = 0;

			foreach (var item in palackok)
			{
				if (item.GetType() == typeof(VisszavalthatoPalack)) osszPenz += ((VisszavalthatoPalack)item).PalackDij;
			}

			return osszPenz;
		}

		public override string ToString()
		{
			string ki = "";

			foreach (var item in this.palackok)
			{
				ki += item.ToString() + "\n";
			}

			ki += $"A rekesz súlya: {Math.Round(this.suly(), 2)} gramm";

			return ki;
		}
	}
}
