using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisikaryakan
{
    class Staff : Karyawan
    {
        public Staff()
        {

        }

        public Staff(string theJabatan)
        {
            this.jabatan = theJabatan;
        }

        public override bool Assign(string Lokasi, string JobDesc)
        {
            throw new NotImplementedException();
        }

        public override bool Enter()
        {
            throw new NotImplementedException();
        }

        public override bool Layoff(int Pesangon)
        {
            throw new NotImplementedException();
        }

        public override bool Training(string Lokasi, string Materi)
        {
            throw new NotImplementedException();
        }
    }
}
