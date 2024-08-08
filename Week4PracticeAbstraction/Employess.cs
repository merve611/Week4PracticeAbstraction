using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4PracticeAbstraction
{
    public abstract class Employess         //Çalışanlar sınıfı
    {
       

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }

        public abstract void Duty();            //Görev metodu 
    }
}
