namespace laboratory_work_5_OOP
{
    abstract class Parent
    {
        protected double pole1;//Швидкість
        protected double pole2;//Собівартість
        protected double pole3;//Вартість
        public Parent(double pole1,double pole2)
        {
            this.pole1 = pole1;
            this.pole2 = pole2;
        }
        public abstract string Info();
        public abstract void Method();
    }
    class Child1 : Parent
    {
        public Child1(double pole1, double pole2) : base(pole1, pole2)
        {

        }
        public override string Info()
        {
            return $"Морський транспорт:\n Швидкість: {pole1:F2};\n Собівартість: {pole2:F2};\n Вартість: {pole3:F2}\n";
        }

        public override void Method()
        {
            pole3 = pole2 / pole1;
        }
    }
    class Child2 : Parent
    {
        double pole4;//Дорожній збір
        public Child2(double pole1, double pole2, double pole4) : base(pole1, pole2)
        {
            this.pole4 = pole4;
        }
        public override string Info()
        {
            return $"Наземний транспорт:\n Швидкість: {pole1:F2};\n Собівартість: {pole2:F2};\n Вартість: {pole3:F2};\n Дорожній збір: {pole4:F2}\n";
        }

        public override void Method()
        {
            pole3 = (pole2 / pole1) + pole4;
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
                if(ChoiseChild == 1)
                {
                    double pole1 = rand.Next(3000) + rand.NextDouble();
                    double pole2 = rand.Next(3000) + rand.NextDouble();
                    Child1 child1 = new Child1(pole1, pole2);
                    child1.Method();
                    Console.WriteLine(child1.Info()); 
                }
                else
                {
                    double pole1 = rand.Next(3000) + rand.NextDouble();
                    double pole2 = rand.Next(3000) + rand.NextDouble();
                    double pole4 = rand.Next(3000) + rand.NextDouble();
                    Child2 child2 = new Child2(pole1, pole2, pole4);
                    child2.Method();
                    Console.WriteLine(child2.Info());
                }
            }
        }
    }
}