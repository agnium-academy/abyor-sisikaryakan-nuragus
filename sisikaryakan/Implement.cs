using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisikaryakan
{
    class Implement
    {
        public static void Main()
        {
            Manager tegar = new Manager("Manager Drilling");
            Manager haidar = new Manager("Manager Drilling");
            Manager sani = new Manager("Manager Refinery");
            Manager adi = new Manager("Manager General Affairs");

            Supervisor iqbal = new Supervisor("Supervisor Drilling Riau");
            Supervisor ucu = new Supervisor("Supervisor Drilling Luwuk");
            Supervisor deni = new Supervisor("Supervisor Refinery Balikpapan");

            Staff dwi = new Staff("Staff Drilling Riau 1");
            Staff trio = new Staff("Straff Drilling Riau 2");
            Staff nuragus = new Staff("Staff Drilling Luwuk");
            Staff sofi = new Staff("Staff Refinery Balikpapan");
            Staff seta = new Staff("Staff General Affairs");

            bool tegar_entry = tegar.Enter();
            bool haidar_entry = haidar.Enter();
            bool sani_entry = sani.Enter();
            bool adi_entry = adi.Enter();

            tegar.basicSalary = 10000000;
            haidar.basicSalary = 10000000;

            bool iqbal_entry = tegar.Enter();
            //etc...etc....

        }


    }
}
