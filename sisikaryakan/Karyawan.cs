using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisikaryakan
{
    abstract class Karyawan
    {
        public string jabatan;

        public int basicSalary;
        public int tunjanganTransportasi;

        abstract public bool Enter();
        abstract public bool Training(string Lokasi, string Materi);
        abstract public bool Assign(string Lokasi, string JobDesc);
        abstract public bool Layoff(int Pesangon);
    }
}
