using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4PracticeAbstraction
{
    public class ProjectManager : Employess        //Proje yöneticisi
    {
       
        public override void Duty()
        {
            Console.WriteLine("Proje Yöneticisi olarak çalışıyorum");
        }
    }
}
