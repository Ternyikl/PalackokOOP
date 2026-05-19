using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalackokOOP
{
	internal class VisszavalthatoPalack : Palack
	{
		private int palackDij;


		public VisszavalthatoPalack(string ital, int maxUrtartalom, int jelenlegiUrtartalom = 1, int palackDij = 25) : base(ital, maxUrtartalom, jelenlegiUrtartalom)
		{
			this.palackDij = palackDij;
		}

		public int PalackDij { get => palackDij; set => palackDij = value; }

		public override string ToString()
		{
			return $"VisszavalthatoPalack, benne levo ital: {this.ital}, jelenleg {this.maxUrtartalom} ml van benne, maximum {this.jelenlegiUrtartalom} ml fer bele.";
		}
	}
}
