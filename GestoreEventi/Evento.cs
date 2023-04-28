using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class Evento
    {
        // ATTRIBUTI
        private string titolo;
        private DateTime dataEvento;
        private int capienzaEvento;
        private int postiPrenotati;

        // COSTRUTTORE
        public Evento(string titolo, DateTime dataEvento, int capienzaEvento, int postiPrenotati)
        {
            SetTitolo(titolo);
            SetDataEvento(dataEvento);
            this.postiPrenotati = 0;
            if (capienzaEvento < 1)
            {
                throw new Exception("La capienza deve essere positiva e maggiore di zero");
            }
            this.capienzaEvento = capienzaEvento;
        
        }

        // GETTERS
        public string GetTitolo()
        {
            return titolo;
        }

        public DateTime GetDataEvento()
        {
            return dataEvento;
        }

        public int GetCapienzaEvento()
        {
            return capienzaEvento;
        }
        
        public int GetPostiPrenotati()
        {
            return postiPrenotati;
        }


        // SETTERS



    }
}
