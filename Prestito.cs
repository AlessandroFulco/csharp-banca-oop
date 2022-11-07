
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
    public static int UltimoId { get; set; } = 0;
    public int Id { get; set; }
    public int Ammontare { get; set; }
    public int ValoreRata { get; set; }
    public DateTime Inizio { get; set; }
    public DateTime Fine { get; set; }
    public Cliente Intestatario { get; set; }

    //prestito in partenza dalla data specificata
    public Prestito(int ammontare, int valoreRata, DateTime inizio, Cliente intestatario)
    {
        UltimoId++;
        Id = UltimoId;
        Ammontare = ammontare;
        ValoreRata = valoreRata;
        Inizio = inizio;
        Fine = FinePrestito(ammontare, valoreRata);
        Intestatario = intestatario;
    }
    public DateTime FinePrestito(int ammontare, int valoreRata)
    {
        int mesi = ammontare / valoreRata;

        Fine = Inizio.AddMonths(mesi);

        return Fine;
    }
}
