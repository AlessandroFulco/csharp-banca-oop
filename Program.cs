
/*
 * Consegna:
    Sviluppare un’applicazione orientata agli oggetti per gestire i prestiti che una banca concede ai propri clienti.

    La banca è caratterizzata da
    un nome
    un insieme di clienti (una lista)
    un insieme di prestiti concessi ai clienti (una lista)

    I clienti sono caratterizzati da
    nome,
    cognome,
    codice fiscale
    stipendio

    I prestiti sono caratterizzati da
    ID
    intestatario del prestito (il cliente),
    un ammontare,
    una rata,
    una data inizio,
    una data fine.

    Per la banca deve essere possibile:
    aggiungere, modificare e ricercare un cliente.
    aggiungere un prestito.
    effettuare delle ricerche sui prestiti concessi ad un cliente dato il codice fiscale
    sapere, dato il codice fiscale di un cliente, l’ammontare totale dei prestiti concessi.
    sapere, dato il codice fiscale di un cliente, quante rate rimangono da pagare alla data odierna.

    Per i clienti e per i prestiti si vuole stampare un prospetto riassuntivo con tutti i dati che li caratterizzano in un formato di tipo stringa a piacere.

    Bonus:
    visualizzare per ogni cliente, la situazione dei suoi prestiti in formato tabellare.
*/
Banca intesa = new Banca("Intesa San Paolo");

//inizio programma
Console.WriteLine("Benvenuto nel programma");

////ricerca di un cliente
//Console.WriteLine("Aggiunta cliente");
//Console.Write("Inserisci Nome: ");
//string nome = Console.ReadLine();

//Console.Write("Inserisci Cognome: ");
//string cognome = Console.ReadLine();

//Console.Write("Inserisci Codice Fiscale: ");
//string codiceFiscale = Console.ReadLine();

//Console.Write("Inserisci il tuo stipendio: ");
//int stipendio = Convert.ToInt32(Console.ReadLine());

//bool cliente = intesa.AggiungiCliente(nome, cognome, codiceFiscale, stipendio);
//if (cliente)
//    Console.WriteLine("Cliente registrato con successo");
//else
//    Console.WriteLine("Ops, qualcosa non va");
//fine aggiunta cliente

//modifica dati cliente
Console.WriteLine("Modifica Dati cliente");

Console.WriteLine("Quale cliente vuoi modificare ?");
string inputUtente = Console.ReadLine();

Console.Write("Inserisci Nome: ");
string nome = Console.ReadLine();

Console.Write("Inserisci Cognome: ");
string cognome = Console.ReadLine();

Console.Write("Inserisci Codice Fiscale: ");
string codiceFiscale = Console.ReadLine();

Console.Write("Inserisci il tuo stipendio: ");
int stipendio = Convert.ToInt32(Console.ReadLine());

bool modificaCliente = intesa.ModificaCliente(inputUtente, nome, cognome, codiceFiscale, stipendio);
if (modificaCliente)
    Console.WriteLine("Modifica Avvenuta con successo");
else
    Console.WriteLine("Ops, qualcosa non va");
//fine modifica cliente