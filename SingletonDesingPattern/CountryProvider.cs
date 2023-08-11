using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesingPattern
{
	public class CountryProvider
	{
		private static CountryProvider instance;
		public static CountryProvider Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new CountryProvider();	
				}
				return instance;
			}
			set=> instance = value;
		
		}

		private new List<Country> Countries { get; set; }

		public async Task<List<Country>> GetCountriesAsync()
		{
			if(Countries is null)
			{
				Countries = new List<Country>()
				{
					new Country() {CountryName="Türkiye"},
					new Country() {CountryName="Almanya"}
				};
			}

			return Countries;
		}
			
	}
}
