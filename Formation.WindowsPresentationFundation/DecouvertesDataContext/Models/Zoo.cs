using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecouvertesDataContext.Models
{
	public class Zoo
	{
		public Ouistiti Ouistiti { get; set; }
		public Elephant Elephant { get; set; }
		public List<Girafe> Girafes { get; set; }
	}
}
