using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tao_lop_thu;

namespace tao_lop_thu
{
    public abstract class Animal
    {
        private double weight;
        private double height;
        private string amthanh;
        private string dichuyen;

        protected Animal(double weight, double height, string amthanh, string dichuyen)
        {
            this.weight = weight;
            this.height = height;
            this.amthanh = amthanh;
            this.dichuyen = dichuyen;
        }

        public double Weight { get => weight; set => weight = value; }
        public double Height { get => height; set => height = value; }
        public string Amthanh { get => amthanh; set => amthanh = value; }
        public string Dichuyen { get => dichuyen; set => dichuyen = value; }
        public abstract string GetInfo();
        public virtual void MakeSound()
        {
            Console.WriteLine("test");
        }

        public virtual void Move()
        {
            Console.WriteLine("test");
        }
        public virtual void nhap()
        {

        }


    }
}
   

      
   
   