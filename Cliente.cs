
/*
 * Consegna:
    Sviluppare un’applicazione orientata agli oggetti per gestire i prestiti che una banca concede ai propri clienti.

    PROPRIETA'
        nome,
        cognome,
        codice fiscale
        stipendio
*/




public class Cliente
{
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public string CodiceFiscale { get; set; }
    public int Stipendio { get; set; }

    public Cliente(string nome, string cognome, string codiceFiscale, int stipendio)
    {
        Nome = nome;
        Cognome = cognome;
        CodiceFiscale = codiceFiscale;
        Stipendio = stipendio;
    }

    public override string ToString()
    {
        return "Nome: " + Nome + " Cognome: " + Cognome + " Codice Fiscale: " + CodiceFiscale + " Stipendio: " + Stipendio;
    }
}