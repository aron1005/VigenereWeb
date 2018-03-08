

using System.Text;

namespace VigenereWeb.Services
{

    public class VigenereSeguridadService : ISeguridadService<string>
    {
        static string ABECEDARIO = ("ABCDEFGHIJKLMNÑOPQRSTUVWXYZ");

        ///  Aquí deben hacer la parte del código necesario para Desencriptar el mensaje
        public string DesEncriptar(string Mensaje, string clave)
        {
            /// sirve para construir una cadena de manera dinamica
            StringBuilder msjDesEnc = new StringBuilder();
            for (int i = 0; i < Mensaje.Length; i++)
            {
                var letra = Mensaje[i];
                var indiceClave = i % clave.Length;
                var claveLetra = clave[indiceClave];

                if (char.IsLetter(letra) && char.IsLetter(claveLetra) )
                {
                    var posLetra = ABECEDARIO.IndexOf(char.ToUpper(letra));
                    var posClave = ABECEDARIO.IndexOf(char.ToUpper(claveLetra));
                    var posLetraDesEnc = (posLetra - posClave) % ABECEDARIO.Length;
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
                }
                else
                {
                    msjDesEnc.Append(letra);
                }

            }

            return msjDesEnc.ToString();
        }



        //  Aquí deben hacer la parte del código necesario para Encriptar el mensaje
        public string Encriptar(string Mensaje, string clave)
        {
            /// sirve para construir una cadena de manera dinamica
            StringBuilder msjEncriptado = new StringBuilder();

            for (int i = 0; i < Mensaje.Length; i++)
            {
                var letra = Mensaje[i];
                var indiceClave = i % clave.Length;
                var claveLetra = clave[indiceClave];

                if (char.IsLetter(letra) && char.IsLetter(claveLetra))
                {

                    var posLetra = ABECEDARIO.IndexOf(char.ToUpper(letra));
                    var posClave = ABECEDARIO.IndexOf(char.ToUpper(claveLetra));
                    var posLetraEnc = (posLetra + posClave) % ABECEDARIO.Length;
                    var letrEnc = ABECEDARIO[posLetraEnc];
                    if (char.IsUpper(letra))
                    {
                        msjEncriptado.Append(letrEnc);
                    }
                    else
                    {
                        msjEncriptado.Append(char.ToLower(letrEnc));
                    }


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