
/*
 * Consegna:
    Sviluppare un’applicazione orientata agli oggetti per gestire i prestiti che una banca concede ai propri clienti.

    PROPRIETA'
        ID
        intestatario del prestito (il cliente),
        un ammontare,
        una rata,
        una data inizio,
        una data fine.
*/

public class Prestito
{
    public int Id { get; set; }
    public int Ammontare { get; set; }
    public int ValoreRata { get; set; }
    public DateOnly Inizio { get; set; }
    public DateOnly Fine { get; set; }
    public Cliente Intestatario { get; set; }

    //prestito in partenza dalla data specificata
    public Prestito(int iD, int ammontare, int valoreRata, DateOnly inizio, DateOnly fine, Cliente intestatario)
    {
        Id = iD;
        Ammontare = ammontare;
        ValoreRata = valoreRata;
        Inizio = inizio;
        Fine = fine;
        Intestatario = intestatario;
    }

    //un prestito in data di oggi
    public Prestito(int iD, int ammontare, int valoreRata, DateOnly fine, Cliente intestatario)
    {
        Id = iD;
        Ammontare = ammontare;
        ValoreRata = valoreRata;
        //data di oggi
        Inizio = new DateOnly();
        Fine = fine;
        Intestatario = intestatario;
    }
}
