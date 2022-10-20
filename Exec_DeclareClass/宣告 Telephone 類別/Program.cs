using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 宣告_Telephone_類別
{//宣告 Telephone類別 具備 CountryCode, AreaCode, Number, Ext 等屬性
	internal class Program
	{
		static void Main(string[] args)
		{
		}
	}

	class Telephone
	{
		public string CountryCode { get; set; }
		public string AreaCode { get; set; }
		public string Number { get; set; }
		public string Ext { get; set; }
	}
}
