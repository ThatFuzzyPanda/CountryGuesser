using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlagToCountryMatchGame.Model
{

	public class Countries
	{
		public Flags flags { get; set; }
		public Name name { get; set; }
		public string[] capital { get; set; }
	}

	public class Flags
	{
		public string png { get; set; }
		public string svg { get; set; }
		public string alt { get; set; }
	}

	public class Name
	{
		public string common { get; set; }
		public string official { get; set; }
		public Nativename nativeName { get; set; }
	}

	public class Nativename
	{
		public Ell ell { get; set; }
		public Tur tur { get; set; }
	}

	public class Ell
	{
		public string official { get; set; }
		public string common { get; set; }
	}

	public class Tur
	{
		public string official { get; set; }
		public string common { get; set; }
	}

}
