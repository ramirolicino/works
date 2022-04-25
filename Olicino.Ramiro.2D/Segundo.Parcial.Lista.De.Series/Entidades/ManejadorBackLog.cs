

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void DelegadoBackLog(Serie serie);

    public class ManejadorBackLog
    {
        public event DelegadoBackLog NuevaSerieParaVer;


        public void IniciarManejador(List<Serie> series)
        {
            Task.Run(() => MoverSeries(series));
        }

        /****** HACER ******/
        private void MoverSeries(List<Serie> series)
        {
            foreach (Serie serie in series)
            {
                //a


                //b


                //c
                Thread.Sleep(1500);

                //d

            }


        }
    }
}
