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


//------programma eventi------
Console.Write("Inserisci il titolo del tuo programma di eventi: ");
string nomeProgramma = Console.ReadLine();

ProgrammaEventi ilMioProgramma = new ProgrammaEventi (nomeProgramma);

Console.Write("Quanti eventi vuoi inserire? ");
int numeroEventi = int.Parse(Console.ReadLine());
Console.WriteLine();


for (int i = 0; i < numeroEventi; i++) ;
{
    try
    {
        int i = 0;
        Console.WriteLine("inserisci il nome del " + ( i + 1) + " evento: ");
        string eventoDaInserire = Console.ReadLine();

        Console.Write("Inserisci la data dell'evento: ");
        DateTime dataEvento = DateTime.Parse(Console.ReadLine());


        Console.Write("Inserisci il numero di posti complessivi: ");
        int numeroPosti = int.Parse(Console.ReadLine());

        Console.WriteLine();


        Evento evento = new Evento();
        ilMioProgramma.AddEventi(evento);

    }catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

Console.WriteLine();
Console.WriteLine("Il numero di eventi nel programma e': " + ilMioProgramma.LunghezzaLista());
Console.WriteLine("Ecco il tuo programma eventi: ");
Console.WriteLine(ilMioProgramma.RestituisciStringaEventi());

Console.Write("Inserisci una data per sapee che eventi ci saranno: ");
DateTime dataDaControllo = DateTime.Parse(Console.ReadLine());

List<Evento> listaEventiInData = ilMioProgramma.EventiInData(dataDaControllo);
string rapprensentazioneInStringaEventi = ProgrammaEventi.StampaEventiInLista(listaEventiInData);

Console.WriteLine(rapprensentazioneInStringaEventi);
ilMioProgramma.ListaSvuotata();

