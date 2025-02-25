using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ClsTablero: INotifyPropertyChanged
    {
        #region Atributos

        // Lista de casillas que componen el tablero
        private List<ClsCasilla> listadoCasillas;

        // Casilla seleccionada por el jugador
        private ClsCasilla casillaSeleccionada;

        // Nivel de dificultad del tablero
        private int dificultad;

        // Tamaño del lado del tablero
        private int lado;

        // Número de bombas en el tablero
        private int numBombas;

        // Número de vidas del jugador
        private int vidas;

        // Número de casillas seguras descubiertas
        private int aciertos;

        // Número de casillas seguras que deben revelarse para ganar
        private int casillasARevelar;

        #endregion

        #region Propiedades

        // Retorna el tamaño del lado del tablero
        public int Lado
        {
            get { return lado; }
        }

        // Retorna el nivel de dificultad
        public int Dificultad
        {
            get { return dificultad; }
        }

        // Retorna el número de aciertos
        public int Aciertos
        {
            get { return aciertos; }
        }

        // Retorna el número de bombas
        public int NumBombas
        {
            get { return numBombas; }
        }

        // Retorna el número de vidas
        public int Vidas
        {
            get { return vidas; }
        }

        // Retorna el número de casillas a revelar para ganar
        public int CasillasARevelar
        {
            get { return casillasARevelar; }
        }

        // Retorna la lista de casillas del tablero
        public List<ClsCasilla> ListadoCasillas
        {
            get { return listadoCasillas; }
        }

        // Establece la casilla seleccionada y actualiza su estado
        public ClsCasilla CasillaSeleccionada
        {
            set
            {
                casillaSeleccionada = value;
                casillaSeleccionada.Revelado = true;

                // Si la casilla es segura, incrementa los aciertos
                if (casillaSeleccionada.Seguro)
                {
                    aciertos++;
                    NotifyPropertyChanged("Aciertos");
                }
                // Si la casilla tiene una bomba, decrementa las vidas
                else
                {
                    vidas--;
                    NotifyPropertyChanged("Vidas");
                }
            }
        }

        #endregion

        #region Constructores

        // Constructor que inicializa un nuevo tablero según la dificultad
        public ClsTablero(int dif)
        {
            listadoCasillas = [];
            dificultad = dif;
            nuevoTablero();
        }

        #endregion

        #region Funciones

        // Genera un nuevo tablero según el nivel de dificultad
        private void nuevoTablero()
        {
            numBombas = ManejadoraBL.GetNumeroBombas(dificultad);
            casillasARevelar = ManejadoraBL.GetCasillasARevelar(dificultad);
            lado = ManejadoraBL.GetLadoTablero(dificultad);
            vidas = ManejadoraBL.GetNumeroVidas(dificultad);
            aciertos = 0;
            rellenarListado();
            anyadirBombas();
        }

        // Rellena la lista de casillas con objetos ClsCasilla
        private void rellenarListado()
        {
            for (int i = 0; i < lado * lado; i++)
            {
                listadoCasillas.Add(new ClsCasilla());
            }
        }

        // Añade bombas aleatoriamente a la lista de casillas
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

        #region NotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {

            PropertyChanged?.Invoke(this, new
                PropertyChangedEventArgs(propertyName));

        }
        #endregion
    }
}
