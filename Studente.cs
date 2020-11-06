using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Registro
{
    
    public class Studente
    {

        private DateTime dataDinascita;

       
        public string Nome { get; private set; }
        public string Cognome { get; private set; }
        public List<Votazione> Voti { get; set; } = new List<Votazione>();
        
        public Studente (string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
        }

        public string NomeCompleto()
        {
            return $"{Nome} {Cognome}";
        }
        public void AddVoto(Votazione v)
        {
            Voti.Add(v);
        }
        public Votazione TrovaVotoMassimo()
        {
            Votazione massima = Voti[0];
            for (int i = 0; i < Voti.Count; i++)
            {
               if(Voti[i].Voto > massima.Voto)
               {
                    massima = Voti[i];
               }
                
            }
            return massima;
        }
        public Votazione TrovaVotoMinimo()
        {
            Votazione minimo = Voti[0];
            for (int i = 0; i < Voti.Count; i++)
            {
                if (Voti[i].Voto < minimo.Voto)
                {
                    minimo = Voti[i];
                }
            }
            return minimo;
        }
        public Votazione TrovaVotoPiùrecente()
        {
            Votazione recente = Voti[0];
            for (int i = 0; i < Voti.Count; i++)
            {
                if(Voti[i].Data > recente.Data)
                {
                    recente = Voti[i];
                }
            }
            return recente;
        }


    }
}
