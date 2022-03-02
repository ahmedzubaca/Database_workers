using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaRadnika
{
    internal class Radnici
    {
        string Ime { get; set; }
        string Prezime { get; set; }
        DateTime Datum_rođenja { get; set; }
        string Spol { get; set; }
        string Mjesto_boravka { get; set; }   
        string Broj_pasoša { get; set; }  
        DateTime Datum_isteka_vize { get; set; } 
        int Dana_do_isteka_vize { get; set; }
        string Zanimanje { get; set; }
        string Gradilište { get; set; }
        DateTime Na_gradilištu_od { get; set; }
        int Vrijeme_provedeno_na_gradilištu { get; set; }
        float Plata { get; set; }
        string Aktivan { get; set; }
        string Lokacija_slike { get; set; }
        string Lokacija_pasoša { get; set; }
        string Lokacija_vize { get; set; }
        string Lokacija_radne_dozvole { get; set; }
    }
}
