using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using tao_lop_thu;

namespace tao_lop_thu
{
    internal class Dog : Animal
    {
        public bool cophaichonghiepvu;

       /*ghi chú:KHÔNG THỂ TẠO HÀM TỰ ĐỘNG BOOL COPHAICHONGHIEPVU, BÁO LỖI NGAY CHỮ DOG*/
                            
       
        public Dog(double weight, double height, string amthanh, string dichuyen, bool cophaichonghiepvu) : base(weight, height, amthanh, dichuyen)
        {
            this.cophaichonghiepvu = cophaichonghiepvu;
            if (cophaichonghiepvu == true)
            {
                Console.Write("it him is cho nghiep vu\n");
            }
            else { Console.Write("it him no cho nghiep vu"); }
        }

      
        public override int GetHashCode()
        {
            Console.Write(GetHashCode());
            return base.GetHashCode();

        }

        public override string GetInfo()
        {
            Console.Write ($"chu cho co trong luong la {Weight}kg, chieu cao la {Height}m, tieng keu {Amthanh}, dang di {Dichuyen}");
            return $"chu cho co trong luong la {Weight}kg, chieu cao la {Height}m, tieng keu {Amthanh}, dang di {Dichuyen}";
        }

        public override void MakeSound()
        {
            Console.Write("\n Tieng keu: {0} ", Amthanh);
        }

        public override void Move()
        {
            Console.Write("\n Di chuyen: {0} ", Dichuyen);
        }

       

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

