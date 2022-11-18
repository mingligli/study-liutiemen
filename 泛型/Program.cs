using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////
            Mydele<int> mydele = new Mydele<int>(Add);
           int res= mydele(100,300);
            Console.WriteLine(res);
            //////////////////////////////////////
            Mydele<double> mydele1= new Mydele<double>(Mul);
            double res1 = mydele1(200, 5);
            Console.WriteLine(res1);
            /////////////////////////////////////////
            Console.ReadLine();
        }
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static double Mul(double x, double y)
        {
            return x * y;
        }
    }
    delegate T Mydele<T>(T a,T b);  //只声明一个委托，可以使用在不同的数据类型上
}
