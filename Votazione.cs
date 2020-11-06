using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Registro
{
    public class Votazione
    {
        private List<Materia> m = new List<Materia>();

        public string Nota { get; private set; }
        public double Voto { get;private set; }
        public DateTime Data { get; private set; }
        public Materia Materie { get; private set; }

        private Studente studente;
        public Votazione(double voto,Studente  s, Studente s1, Materia  m)
        {
            Voto = voto;
            studente = s;
            Materie = m;
            Data = DateTime.Now;
        }
        
        public string Descrizione(string nota)
        {
            Nota = nota;
            return Nota;
        }
        public bool isInsufficente()
        {
            if(Voto >= 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
