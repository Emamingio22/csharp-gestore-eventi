using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class ProgrammaEventi
    {
        // ATTRIBUTI
        private string titolo;
        private List<Evento> eventi;

        // COSTRUTTORE
        public ProgrammaEventi(string titolo, List<Evento> eventi)
        {
            this.titolo = titolo;
            eventi = new List<Evento>();

        }

        public ProgrammaEventi(string? nomeProgramma)
        {
        }

        // GETTERS
        public string GetTitoloProgramma()
        {
            return titolo;
        }

        // METODI
        public void AddEventi(Evento evento)
        {
            eventi.Add(evento);
        }

        public List<Evento> EventiInData(DateTime verificaData)
        {
            List<Evento> listaEventi = new List<Evento>();
            foreach (Evento evento in this.eventi)
            {
                if (evento.GetDataEvento() == verificaData)
                {
                    listaEventi.Add(evento);
                }
            }
            return listaEventi;
        }

        public static string StampaEventiInLista(List<Evento> eventiInLista)
        {
            string rappresenta = "";
            foreach (Evento evento in eventiInLista)
            {
                rappresenta += evento.ToString() + "\n";
            }
            return rappresenta;
        }

        public string RestituisciStringaEventi()
        {
            string outputStringa = this.titolo + "\n";
            foreach (Evento evento in eventi)
            {
                outputStringa += "\t" + evento.ToString() + "\n";
            }
            return outputStringa;
        }

        public int LunghezzaLista()
        {
            return eventi.Count;
        }

        public void ListaSvuotata()
        {
            this.eventi.Clear();
        }
    }
}
