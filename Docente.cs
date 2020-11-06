using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Registro
{
    public class Docente
    {
        private string nome;
        private string cognome;

        private Classe c;

        private Votazione v;
        public Materia Materia { get; private set; }
         public Docente(string nome,string cognome,Materia materia)
         {
            this.nome = nome;
            this.cognome = cognome;
            Materia m = materia;
         }

        public Votazione AssegnaVoto(double voto,Studente s)
        {
            

            
  
            
        }
    }
}
