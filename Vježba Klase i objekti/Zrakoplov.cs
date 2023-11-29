using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vježba_Klase_i_objekti
{
    internal class Zrakoplov
    {
        string naziv;
        int dosegLeta;
        double snagaMotoraU_kW;


        public void SetNaziv(string naziv)
        {
            this.naziv = naziv;
        }
        public void SetDosegLeta(int dosegLetaUKm)
        {
            this.dosegLeta = dosegLetaUKm;
        }
        public void SetSnagaMotoraU_kW(double snagaMotoraU_kW)
        {
            this.snagaMotoraU_kW = snagaMotoraU_kW;
        }


        public string GetNaziv()
        {
            return this.naziv;
        }
        public int GetDosegLeta()
        {
            return this.dosegLeta;
        }
        public double GetSnagaMotoraU_kW()
        {
            return this.snagaMotoraU_kW;
        }


        public string Ispis()
        {
            string ispis = ("Naziv: " + this.GetNaziv()
                    + "\r\nDosegLeta: " + this.GetDosegLeta() + "Km"
                    + "\r\nSnagaMotora: " + this.GetSnagaMotoraU_kW() + "kW"
                    );
            return ispis;
        }


        public Zrakoplov()
        {

        }

        public Zrakoplov(string naziv, int dosegLeta, double snagaMotoraU_kW)
        {
            this.naziv = naziv;
            this.dosegLeta = dosegLeta;
            this.snagaMotoraU_kW = snagaMotoraU_kW;

        }

    }
}

