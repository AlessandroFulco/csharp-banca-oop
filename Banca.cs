
/*
 * Consegna:
    Sviluppare un’applicazione orientata agli oggetti per gestire i prestiti che una banca concede ai propri clienti.

    
    METODI
        Per la banca deve essere possibile:
        aggiungere, modificare e ricercare un cliente.
        aggiungere un prestito.
        effettuare delle ricerche sui prestiti concessi ad un cliente dato il codice fiscale
        sapere, dato il codice fiscale di un cliente, l’ammontare totale dei prestiti concessi.
        sapere, dato il codice fiscale di un cliente, quante rate rimangono da pagare alla data odierna.

        Per i clienti e per i prestiti si vuole stampare un prospetto riassuntivo con tutti i dati che li caratterizzano in un formato di tipo stringa a piacere.

        Bonus:
        visualizzare per ogni cliente, la situazione dei suoi prestiti in formato tabellare.

    PROPRIETA'
        un nome
        un insieme di clienti (una lista)
        un insieme di prestiti concessi ai clienti (una lista)
*/


public class Banca
{
    public string Nome { get; set; }
    public List<Cliente> Clienti { get; set; }
    List<Prestito> Prestiti { get; set; }

    public Banca(string nome)
    {
        Nome = nome;
        Clienti = new List<Cliente>();
        Prestiti = new List<Prestito>();

        Cliente c1 = new Cliente("Alessandro", "Fulco", "gfagfdsg78656", 2000);
        Clienti.Add(c1);
    }

    public bool AggiungiCliente(string nome, string cognome, string codiceFiscale, int stipendio)
    {
        //controllo parametri funzione
        if(
            nome == null || nome == "" ||
            cognome == null || cognome == "" ||
            codiceFiscale == null || cognome == "" ||
            stipendio < 0
            )
        {
            return false;
        }

        //ricerca dell'utente tramite codice fiscale
        Cliente esistente = RicercaCliente(codiceFiscale);

        //se il cliente esiste sarà diversa da null
        if (esistente != null)
            return false;

        Cliente cliente = new Cliente(nome, cognome, codiceFiscale, stipendio);
        Clienti.Add(cliente);

        return true;

    }

    public bool ModificaCliente(string inputUtente, string nome, string cognome, string codiceFiscale, int stipendio)
    {
        Cliente modificaCliente = RicercaCliente(inputUtente);

        if (
            nome == "" &&
            cognome == "" &&
            codiceFiscale == "" &&
            stipendio == null
            )
        {
            return false;
        }

        if (modificaCliente == null)
        {
            return false;
        }
        if (nome != "")
            modificaCliente.Nome = nome;
        if (cognome != "")
            modificaCliente.Cognome = cognome;
        if (codiceFiscale != "")
            modificaCliente.CodiceFiscale= codiceFiscale;
        if (stipendio != null || stipendio <= 0)
            modificaCliente.Stipendio = stipendio;

        return true;
    }

    public Cliente RicercaCliente(string codiceFiscale)
    {
        foreach(Cliente cliente in Clienti)
        {
            if(cliente.CodiceFiscale == codiceFiscale)
            {
                return cliente;
            }
        }

        return null;

    }

    public List<Prestito> RicercaPrestito(string codiceFiscale)
    {
        List<Prestito> prestiti = new List<Prestito>();

        //algoritmo

        return prestiti;
    }

    public int AmmontareTotalePrestitiCliente(string codiceFiscale)
    {
        int ammontare = 0; //metterò il conteggio

        //conteggio...

        return ammontare;
    }

    public int RateMancantiCliente(string codiceFiscale)
    {
        int rateMancanti = 0; //metterò il conteggio

        //conteggio...

        return rateMancanti;
    }

    public void StampaProspettoClienti()
    {
        //stampare per tutti i clienti
    }

    public void StampaProspettoPrestiti()
    {
        //stampa per tutti i prestiti
    }

    public void AggiungiPrestito(Prestito nuovoPrestito)
    {

    }
}
