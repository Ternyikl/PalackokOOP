using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalackokOOP
{
	internal class Palack
	{
		private string ital;
		private int maxUrtartalom;
		private int jelenlegiUrtartalom;

		public Palack(string ital, int maxUrtartalom, int jelenlegiUrtartalom)
		{
			this.ital = ital;
			this.maxUrtartalom = maxUrtartalom;
			this.JelenlegiUrtartalom = jelenlegiUrtartalom;
		}

		public Palack(string ital, int maxUrtartalom)
		{
			this.ital = ital;
			this.maxUrtartalom = maxUrtartalom;
			this.jelenlegiUrtartalom = 1;
		}

		public string Ital { get => ital; set => ital = value; }
		public int MaxUrtartalom { get => maxUrtartalom; set => maxUrtartalom = value; }
		public int JelenlegiUrtartalom { 
			get => jelenlegiUrtartalom;
			set 
			{
				if (value > this.maxUrtartalom) jelenlegiUrtartalom = this.maxUrtartalom;
				else if (value == 0)
				{
					jelenlegiUrtartalom = value;
					this.ital = null;
				}
				else jelenlegiUrtartalom = value;
			} 
		}

		public double suly()
		{
			return (double)this.maxUrtartalom / 35 + this.jelenlegiUrtartalom;
		}

		public override bool Equals(object obj)
		{
			Palack masikPalack = obj as Palack;

			if(this.ital == masikPalack.ital && this.maxUrtartalom == masikPalack.maxUrtartalom &&this.jelenlegiUrtartalom == masikPalack.jelenlegiUrtartalom)
			{
				return true;
			}
			return false;
		}

		public void hozzaOnt(Palack p1)
		{
			if(this.jelenlegiUrtartalom + p1.jelenlegiUrtartalom > this.maxUrtartalom)
			{
				this.JelenlegiUrtartalom = this.maxUrtartalom;
				p1.JelenlegiUrtartalom = this.maxUrtartalom - this.JelenlegiUrtartalom;
			}
			else
			{
				this.JelenlegiUrtartalom = this.JelenlegiUrtartalom + p1.JelenlegiUrtartalom;
				p1.JelenlegiUrtartalom = 0;
			}

			if(this.Ital != p1.Ital)
			{
				this.Ital = $"Keverek";
			}
		}

		public override string ToString()
		{
			return $"Palack, benne levo ital: {this.ital}, jelenleg {this.jelenlegiUrtartalom} ml van benne, maximum {this.maxUrtartalom} ml fer bele.";
		}
	}
}
