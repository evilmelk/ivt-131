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


        /// <summary>
        /// Конвертирует s в d в строке
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        internal string ConvertStoD(string s)
        {
            string result = s.Replace('s', 'd');
            result = s.Replace('S', 'D');

            return result;
        }

		public static void Recursia()
		{
			d();
		}

		public static void main()
		{
			Recursia();
		}

    }
}
