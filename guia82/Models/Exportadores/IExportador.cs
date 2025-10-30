namespace guia82.Models.Exportadores
{
    public interface IExportador 
    {
        bool Importar(string data, Multa m);
        string Exportar(Multa m);
    }
}
