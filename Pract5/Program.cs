using Pract5;
using System;
using System.ComponentModel.DataAnnotations;

namespace Pract5
{
    abstract class Figura
    {
        protected const double Pi = 3.14;
        protected int A;
        protected int B;
        protected int C;
        public Figura(int A, int B, int C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }
        public abstract double Plosh();
        public abstract int Perim();
        public abstract double Dlin();
    }
    class Krug : Figura
    {
        int Rad;
        public Krug(int Rad):base(0,0,0)
        {
            this.Rad = Rad;
        }
        public override double Plosh()
        {
            return Pi * Math.Pow(this.Rad, 2);
        }
        public override double Dlin()
        {
            return (2 * Pi) * this.Rad;
        }
        public override int Perim()
        {
            return 0;
        }
    }
    class Trek : Figura
    {
        double Vis;
        public Trek(double Vis,int A,int B,int C):base(A,B,C)
        {
            this.Vis = Vis;
            
        }
        public override double Plosh()
        {
            return 0.5 * (this.A * this.Vis);
        }
        public override int Perim()
        {
            return this.A + this.B + this.C;
        }
        public override double Dlin()
        {
            return 0;
        }
    }
    class Pryamo : Figura
    {
        public Pryamo(int A, int B):base(A,B,0)
        {
            this.A = A;
            this.B = B;
        }
        public override double Plosh()
        {
            return this.A * this.B;
        }
        public override int Perim()
        {
            return 2 * (this.A + this.B);
        }
        public override double Dlin()
        {
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Krug krug = new Krug(12);
            Trek trek = new Trek(6,7,8,12);
            Pryamo pryamo = new Pryamo(12, 16);
            Console.WriteLine("Площа круга-" + krug.Plosh() + '/' + "Довжина окружностi-" + krug.Dlin() + '/');
            Console.WriteLine("Площа трикутника -" + trek.Plosh() + '/' + "Периметр трикутника-" + trek.Perim());
            Console.WriteLine("Площа прямокутника-" + pryamo.Plosh() + '/' + "Периметр прямокутника-" + pryamo.Perim());
        }
    }
}
 