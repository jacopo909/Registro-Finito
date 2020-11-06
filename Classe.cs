using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Registro
{
    public class Classe
    {
       public int Anno { get; private set; }
       public string Sezione { get; private set; }

      public string Nome { get; private set; }

        public List<Studente> Studenti { get; private set; } = new List<Studente>();
        internal Classe(int anno, string sezione)
        {
            Anno = anno;
            Sezione = sezione;
        }
        public void addStudente(Studente s)
        {
            Studenti.Add(s);
        }
        public Votazione TrovaVotoMassimo()
        {
            Votazione massima = Studenti[0].TrovaVotoMassimo();
            foreach (Studente s in Studenti)
            {
                Votazione v = s.TrovaVotoMassimo();
                if (v.Voto > massima.Voto)
                    massima = v;
            }
            return massima;

        }
        public Votazione TrovaVotoMinimo()
        {
            Votazione minimo = Studenti[0].TrovaVotoMinimo();
            foreach (Studente s in Studenti)
            {
                Votazione v = s.TrovaVotoMinimo();
                if (v.Voto < minimo.Voto)
                    minimo = v;
            }
            return minimo;
        }


    }
}
