
namespace Ejercicio1.Models;

public interface IProcesable
{
    string Procesar(string patente, out string formateada);
}
