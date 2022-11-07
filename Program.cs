
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

Console.WriteLine("Benvenuto in {0}", intesa.Nome);

bool on = true;

while (on)
{
    Console.WriteLine("Scelgi l'opzione da eseguire:");
    Console.WriteLine("1. Aggiungi un cliente");
    Console.WriteLine("2. Modifica un cliente");
    Console.WriteLine("3. Ricerca un cliente");
    Console.WriteLine("4. Crea un nuovo prestito");
    Console.WriteLine("5. Ricerca prestiti cliente");
    Console.WriteLine("6. Ammontare totale dei prestiti di un cliente");
    Console.WriteLine("7. Rate rimanenti prestiti di un cliente");
    Console.WriteLine("8. Lista prospetti di tutti i prestiti della banca");
    Console.WriteLine("9. Esci");

    int scelta = Convert.ToInt32(Console.ReadLine());

    switch (scelta)
    {
        // aggiungere un cliente
        case 1:
            Console.WriteLine();
            Console.WriteLine("Sezione Aggiungi un nuovo cliente.");

            Console.Write("Inserisci Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Inserisci Cognome: ");
            string cognome = Console.ReadLine();

            Console.Write("Inserisci Codice Fiscale: ");
            string codiceFiscale = Console.ReadLine();

            Console.Write("Inserisci il tuo stipendio: ");
            int stipendio = Convert.ToInt32(Console.ReadLine());

            bool cliente = intesa.AggiungiCliente(nome, cognome, codiceFiscale, stipendio);
            if (cliente)
                Console.WriteLine("Cliente registrato con successo");
            else
                Console.WriteLine("Ops, qualcosa non va");
            Console.WriteLine();
            break;

        // modificare un cliente
        case 2:
            Console.WriteLine();
            Console.WriteLine("Sezione Modifica Dati cliente");

            Console.WriteLine("Quale cliente vuoi modificare ?");
            string inputUtente = Console.ReadLine();

            Console.Write("Inserisci Nome: ");
            nome = Console.ReadLine();

            Console.Write("Inserisci Cognome: ");
            cognome = Console.ReadLine();

            Console.Write("Inserisci Codice Fiscale: ");
            codiceFiscale = Console.ReadLine();

            Console.Write("Inserisci il tuo stipendio: ");
            stipendio = Convert.ToInt32(Console.ReadLine());

            bool modificaCliente = intesa.ModificaCliente(inputUtente, nome, cognome, codiceFiscale, stipendio);
            if (modificaCliente)
                Console.WriteLine("Modifica Avvenuta con successo");
            else
                Console.WriteLine("Ops, qualcosa non va");
            Console.WriteLine();
            break;

        // ricercare un cliente
        case 3:

            Console.WriteLine();
            Console.WriteLine("Sezione Ricerca cliente");

            Console.Write("Inserisci il codice fiscale del cliente: ");
            codiceFiscale = Console.ReadLine();

            Cliente ricerca = intesa.RicercaCliente(codiceFiscale);
            if (ricerca != null)
                Console.WriteLine(ricerca.ToString());
            else
                Console.WriteLine("Cliente non trovato");
            Console.WriteLine();
            break;

        // aggiungere un prestito
        case 4:
            Console.WriteLine();
            Console.WriteLine("Sezione Aggiungi Prestito");
            Console.WriteLine();
            Console.Write("Inserisci il codice fiscale: ");
            codiceFiscale = Console.ReadLine();

            ricerca = intesa.RicercaCliente(codiceFiscale);

            if (ricerca == null)
            {
                Console.WriteLine("Errore, nessun cliente registrato con questo codice fiscale");
            }
            else
            {
                Console.WriteLine("Inserisci l'ammontare del prestito");
                int ammontare = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Inserisci rata del prestito");
                int valoreRata = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Inserisci la data di inizio prestito");
                DateTime inizio = Convert.ToDateTime(Console.ReadLine());

                bool prestito = intesa.AggiungiPrestito(ammontare, valoreRata, inizio, codiceFiscale);

                if (prestito)
                    Console.WriteLine("Presito creato con successo");
                else
                    Console.WriteLine("Ops, qualcosa non va;");
            }
            Console.WriteLine();
            break;
        
        // ricerca prestiti concessi ad un cliente
        case 5:

            Console.WriteLine();
            Console.WriteLine("Sezione Prestiti reltivi al singolo cliente");
            Console.WriteLine();
            Console.Write("Inserisci il Codice fiscale: ");
            codiceFiscale = Console.ReadLine();

            List<Prestito> prestiti = intesa.RicercaPrestito(codiceFiscale);
            foreach(Prestito prestito in prestiti)
            {
                Console.WriteLine(prestito.ToString());
            }
            Console.WriteLine();
            break;

        // ammontare totale dei prestiti di un cliente
        case 6:

            Console.WriteLine();
            Console.WriteLine("Sezione Ammontare totale prestiti cliente");
            Console.Write("Inserisci il Codice fiscale: ");
            codiceFiscale = Console.ReadLine();

            int totale = intesa.AmmontareTotalePrestitiCliente(codiceFiscale);
            if (totale > 0)
                Console.WriteLine("L'ammontare totale dei prestiti è: {0}", totale);
            else
                Console.WriteLine("Il cliente non ha nessun debito con la banca");
            Console.WriteLine();

            break;

        // prospetto prestiti di un cliente
        case 7:

            Console.WriteLine();
            Console.WriteLine("Sezione Rate rimanenti dei prestiti di un cliente");
            Console.WriteLine("Inserisci il codice fiscale");
            codiceFiscale = Console.ReadLine();
            prestiti = intesa.RicercaPrestito(codiceFiscale);

            foreach (Prestito prestito in prestiti)
            {
                Console.WriteLine("Prestito intestato a: " + prestito.Intestatario.Nome + ". Rate rimanenti: " + prestito.RateRimanenti());
            }
            Console.WriteLine();
            break;

        // prospetti prestiti della banca con i clienti
        case 8:

            Console.WriteLine();
            Console.WriteLine("Sezione Lista prospetti di tutti i prestiti della banca");
            intesa.StampaProspettoPrestiti();
            Console.WriteLine();
            break;

        // esci dall'applicazione
        case 9:
            on = false;
            break;

        default:
            Console.WriteLine("L'opzione scelta non esiste");
            break;
    }
    Console.WriteLine();
}






















//1 ////aggiunta di un cliente
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
    ////fine aggiunta cliente


//2 ////modifica dati cliente
    //Console.WriteLine("Modifica Dati cliente");

    //Console.WriteLine("Quale cliente vuoi modificare ?");
    //string inputUtente = Console.ReadLine();

    //Console.Write("Inserisci Nome: ");
    //string nome = Console.ReadLine();

    //Console.Write("Inserisci Cognome: ");
    //string cognome = Console.ReadLine();

    //Console.Write("Inserisci Codice Fiscale: ");
    //string codiceFiscale = Console.ReadLine();

    //Console.Write("Inserisci il tuo stipendio: ");
    //int stipendio = Convert.ToInt32(Console.ReadLine());

    //bool modificaCliente = intesa.ModificaCliente(inputUtente, nome, cognome, codiceFiscale, stipendio);
    //if (modificaCliente)
    //    Console.WriteLine("Modifica Avvenuta con successo");
    //else
    //    Console.WriteLine("Ops, qualcosa non va");
    ////fine modifica cliente
///
////Creazione prestito
//Console.WriteLine("Sezione Aggiungi Prestito");
//Console.WriteLine();
//Console.Write("Inserisci il codice fiscale: ");
//string codiceFiscale = Console.ReadLine();

//Cliente cliente = intesa.RicercaCliente(codiceFiscale);

//if(cliente == null)
//{
//    Console.WriteLine("Errore, nessun cliente registrato con questo codice fiscale");
//}
//else
//{
//    Console.WriteLine("Inserisci l'ammontare del prestito");
//    int ammontare = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("Inserisci rata del prestito");
//    int valoreRata = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("Inserisci la data di inizio prestito");
//    DateTime inizio = Convert.ToDateTime(Console.ReadLine());

//    bool prestito = intesa.AggiungiPrestito(ammontare, valoreRata, inizio, codiceFiscale);

//    if (prestito)
//        Console.WriteLine("Presito creato con successo");
//    else
//        Console.WriteLine("Ops, qualcosa non va;");
//}
////fine aggiunta prestito
///

////ricerca sui prestiti concessi ad un cliente dato il codice fiscale
//Console.WriteLine("Sezione prestiti reltivi al singolo cliente");
//Console.WriteLine();
//Console.Write("Inserisci il Codice fiscale: ");
//string codiceFiscale = Console.ReadLine();

//List<Prestito> prestitiCliente = intesa.RicercaPrestito(codiceFiscale);
////fine ricerca prestiti dato un codice fiscale

////prospetto clienti rate mancanti
//List<Prestito> prestiti = intesa.RicercaPrestito("gfagfdsg78656");

//foreach (Prestito prestito in prestiti)
//{
//    Console.WriteLine("Prestito intestato a: " + prestito.Intestatario.Nome + ". Rate rimanenti: " + prestito.RateRimanenti());
//}
//// fine prospetto clienti rate mancanti