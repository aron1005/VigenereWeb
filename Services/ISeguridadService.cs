
namespace VigenereWeb.Services
{


    public interface ISeguridadService<T>
    {
        
        string Encriptar(string Mensaje, T clave);
        string DesEncriptar(string Mensaje, T clave);
    }

}