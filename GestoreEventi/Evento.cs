using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
        public void SetTitolo(string titolo)
        {
            if (titolo == null)
            {
                throw new ArgumentNullException("Non hai inserito il titolo!");
            }
            else
            {
                this.titolo = titolo;
            }
        }

        public void SetDataEvento(DateTime dataEvento)
        {
            if (dataEvento <= DateTime.Now)
            {
                throw new InvalidDataException("La data che hai inserito non è corretta!");
            }
            else
            {
                this.dataEvento = dataEvento;
            }
        }

        // METODI
        public int PostiDisponibili() //posti disponibili
        {
            return this.capienzaEvento - this.postiPrenotati;
        }

        public void PrenotaPosti(int sedute) // aggiungi sedute
        {
            if (postiPrenotati + sedute > capienzaEvento)
            {
                throw new Exception("Troppi posti prenotati!");
            }

            if (this.dataEvento < DateTime.Now)
            {
                throw new Exception("La data che hai scelto è prima dell'evento!");
            }

            postiPrenotati += sedute;
        
        }

        public void DisdiciPosti(int sedute) // togli sedute
        {
            if (postiPrenotati - sedute <= 0)
            {
                throw new Exception("Troppi posti da disdire!");
            }

            if (dataEvento < DateTime.Now)
            {
                throw new Exception("La data che hai scelto è prima dell'evento!");
            }

            postiPrenotati -= sedute;
        
        }

        // OVERRIDE





    }
}
