using GestoreEventi;

//------evento------
Console.Write("Inserisci il nome dell'evento: ");
string nomeEvento = Console.ReadLine();

Console.Write("Inserisci data evento (dd/MM/yyyy): ");
DateTime dataOra = DateTime.Parse(Console.ReadLine());

Console.Write("Inserisci la capienza massima: ");
int capienzaMassima = int.Parse(Console.ReadLine());

Console.Write("Quanti posti desideri prenotare? ");
int numeroPostiDaPrenotare = int.Parse(Console.ReadLine());

Evento concerto = new Evento(nomeEvento, dataOra, capienzaMassima, numeroPostiDaPrenotare);

concerto.PrenotaPosti(numeroPostiDaPrenotare);

Console.WriteLine();
Console.WriteLine("Numero di posti prenotati = " + concerto.GetPostiPrenotati());


bool flag = false;
string risposta;

while (!flag)
{
    Console.WriteLine();
    Console.Write("Vuoi disdire i posti(si/no)? ");
    risposta = Console.ReadLine();
    switch (risposta)
    {
        case "si":
            Console.WriteLine("Indica quanti posti vuoi disdire: ");
            int postiDaDisdire = int.Parse(Console.ReadLine());
            try
            {
                concerto.DisdiciPosti(postiDaDisdire);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;

        case "no":
            flag = true;
            Console.WriteLine("Buona Visione!");
            break;
    }

    Console.WriteLine();
    Console.WriteLine("Numero di posti prenotati: " + concerto.GetPostiPrenotati());
    Console.WriteLine("Numero di posti disponibili: " + concerto.PostiDisponibili());
}




