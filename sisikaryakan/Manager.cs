using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisikaryakan
{
    class Manager : Karyawan
    {
        public int tunjanganPenginapan;
        public int tunjanganInternet;
        public int tunjanganHariRaya;
        public int tunjanganKesehatan;

        public Manager()
        {
        }

        public Manager(string theJabatan)
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

        public bool StudiBanding(string Lokasi, string Tujuan)
        {
            throw new NotImplementedException();
        }
    }
}
