using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectForIVT131
{
    public class Class1
    {

        /// <summary>
        /// Инициализирует Class1
        /// </summary>
        public Class1()
        {
			int t=6;
        }
		public void d()
		{
			Console.Write("sfsa");
		}
		public void Recursia()
		{
			d();
		}
		public static void main()
		{
			Recursia();
		}
    }
}
