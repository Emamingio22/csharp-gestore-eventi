using GestoreEventi;

//------evento------
Console.Write("Inserisci l'evento: ");
string nomeEvento = Console.ReadLine();

Console.Write("Inserisci la data: ");
DateTime oraEvento = DateTime.Parse(Console.ReadLine());

Console.Write("Inserisci la capienza massima: ");
int maxCapienza = int.Parse(Console.ReadLine());

Console.Write("Quanti posti vuoi prenotare? ");
int postiDaPrenotare = int.Parse(Console.ReadLine());

Evento concerto = new Evento (nomeEvento, oraEvento, maxCapienza, postiDaPrenotare);



