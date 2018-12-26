using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
	class CalcLogic
	{
		public CalcLogic() { }

		public ulong Sum(ulong a, ulong b)
		{
			ulong c = a + b;
			return c;
		}

		public ulong Raznitsa(ulong a, ulong b)
		{
			ulong c = a - b;
			return c;
		}
	}
}
