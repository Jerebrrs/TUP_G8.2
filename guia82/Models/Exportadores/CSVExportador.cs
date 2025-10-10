1

namespace guia82.Models.Exportadores
{
    public class CSVExportador : IExportador
    {
        string IExportador.Exportar(Multa m)
        {
            throw new NotImplementedException();
        }

        bool IExportador.Importar(string data, Multa m)
        {
            throw new NotImplementedException();
        }
    }
}
