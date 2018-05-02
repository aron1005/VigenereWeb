

using System.Text;

namespace VigenereWeb.Services
{

    public class VigenereSeguridadService : ISeguridadService<string>
    {
        static string ABECEDARIO = ("ABCDEFGHIJKLMNÑOPQRSTUVWXYZ");
        int a=0
        int t=0;

        ///  Aquí deben hacer la parte del código necesario para Desencriptar el mensaje
        public string DesEncriptar(string Mensaje, string clave)
        {
            clave=clave.ToUpper()
             /// sirve para construir una cadena de manera dinamica
            StringBuilder msjEncriptado = new StringBuilder();

            return Mensaje;
            StringBuilder msjDesEnc = new StringBuilder();
             
            foreach (var letra in Mensaje)
            {
                if (char.IsLetter(letra))
                {
                    if(t>=clave.Length){
                        t=0;
                    }
                    for(int i=0;i<ABECEDARIO.Length;i++){
                        if(clave[t]==ABECEDARIO[i]){
                        a=i;
                        }
                    }
                    var posLetra = ABECEDARIO.IndexOf(char.ToUpper(letra));
                    var posLetraDesEnc = (posLetra - a) % ABECEDARIO.Length;
                    /// Esto es lo mismo que un if(posLetraDesEnc < 0){posLetraDesEnc += ABECEDARIO.Length} else {posLetraDesEnc}
                    posLetraDesEnc = posLetraDesEnc < 0 ? posLetraDesEnc = ABECEDARIO.Length + posLetraDesEnc : posLetraDesEnc;
                    var letraDesEnc = ABECEDARIO[posLetraDesEnc];
                    if (char.IsUpper(letra))
                    {
                        msjDesEnc.Append(letraDesEnc);
                    }
                    else
                    {
                        msjDesEnc.Append(char.ToLower(letraDesEnc));
                    }
                    g++;
                }
                else
                {
                    msjDesEnc.Append(letra);
                }
        }return msjDesEnc.ToString();
         }

              //  Aquí deben hacer la parte del código necesario para Encriptar el mensaje
        public string Encriptar(string Mensaje, int clave)
        public string Encriptar(string Mensaje, string clave)
         {
             /// sirve para construir una cadena de manera dinamica
             StringBuilder msjEncriptado = new StringBuilder();
            a=0;
            t=0;
            clave=clave.ToUpper();
            foreach (var letra in Mensaje)
            {
                if (char.IsLetter(letra))
                {
                    if(t>=clave.Length){
                        t=0;
                    }
                    for(int i=0;i<ABECEDARIO.Length;i++){
                        if(clave[t]==ABECEDARIO[i]){
                            a=i;
                        }
                    }
                    var posLetra = ABECEDARIO.IndexOf(char.ToUpper(letra));
                    var posLetraEnc = (posLetra + a) % ABECEDARIO.Length;
                    var letrEnc = ABECEDARIO[posLetraEnc];
                    if (char.IsUpper(letra))
                    {
                        msjEncriptado.Append(letrEnc);
                    }
                    else
                    {
                        msjEncriptado.Append(char.ToLower(letrEnc));
                    }
                    g++;

            return Mensaje;
                }
                else
                {
                    msjEncriptado.Append(letra);
                }
           
        }
         return msjEncriptado.ToString();
    }


}
}