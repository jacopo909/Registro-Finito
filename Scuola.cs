using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Registro
{
    public class Scuola
    {

       
        public string Nome { get;private set; }
        public List<Classe> Classi { get; private set; }
        public List<Materia> Materie { get; private set; }

        private List<Materia> m = new List<Materia>();

        public Scuola(string nome)
        {
            Nome = nome;
            Classi = new List<Classe>();
            Materie = new List<Materia>();
        }
        public Classe CreateClasse(int anno,string sezione)
        {
            Classe c = new Classe(anno,sezione);
            return c;
        }
        public Materia CreateMateria(string nome)
        {
            Materia m = new Materia(nome);
            return m;
        }
    }
}
