using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models.General
{
	public class LocationModel
	{
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public string Image { get; set; } = string.Empty;

		public int XCoordinate { get; set; }
		public int YCoordinate { get; set; }
	}
}
