using Repaso09.C_.Servicios;

namespace Repaso09.C_.Controladores
{

    class Program
    {


       public static void Main(string[] args)
        {

            OperativaInterfaz op = new OperativaImplemntacon();

            do
            {
                op.solicitarFrase();
            }

            while (true);

        }
    }


}