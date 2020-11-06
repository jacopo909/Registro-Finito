using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro
{
    public class Materia
    {
        private string nome;

        public string Nome { get; private set; }

        private Docente d;
        internal Materia(string nome)
        {
            Nome = nome;
        }
    }
}
