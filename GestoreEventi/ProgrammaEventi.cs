using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class ProgrammaEventi
    {
        // ATTRIBUTI
        private string titolo;
        private List<Evento> eventi;

        // COSTRUTTORE
        public EventiProgramma(string titolo, List<Evento> eventi)
        {
            this.titolo = titolo;
            eventi = new List<Evento>();

        } 

    }
}
