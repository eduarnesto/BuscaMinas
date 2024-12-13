using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ClsTablero
    {
        #region Atributos

        private List<ClsCasilla> listadoCasillas;
        private ClsCasilla casillaSeleccionada;
        private int lado;
        private int numBombas;
        private int vidas = 5;
        private int aciertos;
        private int casillasReveladas;

        #endregion

        #region Propiedades

        public List<ClsCasilla> ListadoCasillas
        {
            get { return listadoCasillas; }
        }

        public ClsCasilla CasillaSeleccionada
        {
            set
            {
                casillaSeleccionada.Revelado = true;
                if (casillaSeleccionada.Seguro)
                {
                    aciertos++;
                }
                else
                {
                    vidas--;
                }

                casillasReveladas++;
            }
        }

        #endregion

        #region Constructores

        public ClsTablero(int lado, int numBombas)
        {
            this.lado = lado;
            this.numBombas = numBombas;
            rellenarListado(lado * lado);
            anyadirBombas();
        }

        #endregion

        #region Funciones

        private void rellenarListado(int numCasillas)
        {
            for (int i = 0; i < numCasillas; i++)
            {
                listadoCasillas.Add(new ClsCasilla());
            }
        }

        private void anyadirBombas()
        {
            Random random = new Random();
            int pos;
            for (int i = 0; i < numBombas; i++)
            {
                do
                {
                    pos = random.Next(listadoCasillas.Count);
                } while (!listadoCasillas[pos].Seguro);

                listadoCasillas[pos].Seguro = false;
            }
        }

        #endregion
    }
}
