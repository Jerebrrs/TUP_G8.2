

using guia82.Models.Exportadores;

namespace guia82.Models
{
    public interface IExportable
    {
        bool Importar(string data,IExportador exp);
        string Exportar(IExportador exp);
    }
}
