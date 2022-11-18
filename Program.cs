using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_up
{
    //学习刘铁猛的委托、Lanbda表示示、Linq
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 无参数的委托
            // MyDelegate myDelegate = new MyDelegate(M1);
            //myDelegate += M1;//可以重复调用一次

            Action action = new Action(M1);//无返回值的用Action,不用事先声明委托
            action();

            //Student student=new Student();//对非静态类也可以委托
            //myDelegate += student.Say;
            //上面的代码可以简写为
            //myDelegate += (new Student()).Say;

            //myDelegate.Invoke();  //委托方法的调用1
           // myDelegate();           //委托方法的调用2，一般按这种调用方法的方式去调用更方便
            #endregion
            #region 有参数和返回值的
            MyDelegate2 myDelegate2 = new MyDelegate2(Add);
            int res = myDelegate2(100, 200);
                Console.WriteLine(res);
            //myDelegate2 += Add;
            #endregion
            Console.ReadKey();
        }
        public static void M1()//写一个无参无返回值的方法，提供给委托去调用
        {
            Console.WriteLine("我是M中的一个方法 \r\n");
            
        }
        public static int Add(int x,int y)//写一个有参有返回值的方法
        {
            return x + y;
        }
      
    }
    public class Student
    {
        public void Say()
        {
            
            Console.WriteLine("My nmae is ZhangSan");
        }
    }
    //delegate void MyDelegate();//1、先去声明一个无参无返回值的，象声明一个类的格式一样
    delegate int MyDelegate2(int x,int y);//2、先去声明一个有返回值的
    //也可以不声音委托，无返回值的用Action，有返回值的用Func去直接使用
}
