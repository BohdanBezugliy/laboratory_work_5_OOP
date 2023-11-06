using System.ComponentModel;

namespace Second_task
{
    interface IParent
    {
        string Info();
        int Method(int x);
    }
    class Child1 : IParent
    {
        int b,c;
        public Child1(int b ,int c)
        {
            this.c = c;
            this.b = b;
        }
        public string Info()
        {
            return $"Лінійна функція: y = {b} * x + {c}";
        }

        public int Method(int x)
        {
            return b * x + c ;
        }
    }
    class Child2 : IParent
    {
        int a, b, c;
        public Child2(int a,int b,int c)
        {
            this.c = c;
            this.b = b;
            this.a = a;
        }
        public string Info()
        {
            return $"Квадратична функція: y = {a} * x * x + {b} * x + {c}";
        }

        public int Method(int x)
        {
            return a * x * x + b * x + c;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                int ChoiseChild = rand.Next(2);
                if (ChoiseChild == 1)
                {
                    int x = rand.Next(300);
                    int b = rand.Next(300);
                    int c = rand.Next(300);
                    Child1 child1 = new Child1(b,c);
                    Console.WriteLine(child1.Info());
                    Console.WriteLine($"При x = {x} y = " + child1.Method(x));
                }
                else
                {
                    int x = rand.Next(300);
                    int a = rand.Next(300);
                    int b = rand.Next(300);
                    int c = rand.Next(300);
                    Child2 child2 = new Child2(a, b, c);
                    Console.WriteLine(child2.Info());
                    Console.WriteLine($"При x = {x} y = " + child2.Method(x));
                }
            }
        }
    }
}