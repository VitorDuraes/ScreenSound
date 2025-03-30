namespace ScreenSound.Modelos;

public class Musica
{
    public Musica(string nome, int anoLancamento, int? artistaId = null)
    {
        Nome = nome;
        AnoLancamento = anoLancamento;
        ArtistaId = artistaId;
    }

    public string Nome { get; set; }
    public int Id { get; set; }
    public int? AnoLancamento { get; set; }
    public int? ArtistaId { get; set; }
    public virtual Artista? Artista { get; set; }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Ano de Lançamento: {AnoLancamento}");
        Console.WriteLine($"Artista ID: {ArtistaId}");

    }

    public override string ToString()
    {
        return @$"Id: {Id}
        Nome: {Nome}
        Ano de Lançamento: {AnoLancamento}
        Artista ID: {ArtistaId}";
    }
}