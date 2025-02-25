using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BL;
using Modelos;

namespace BuscaMinasMaui.ViewModels
{
    // Clase que representa el ViewModel de la página principal en el juego de BuscaMinas
    public class MainPageVM : INotifyPropertyChanged
    {
        #region Atributos
        // Atributo que almacena el tablero del juego
        private ClsTablero tablero;
        #endregion

        #region Propiedades
        // Propiedad para acceder al tablero del juego
        public ClsTablero Tablero
        {
            get { return tablero; }
        }

        // Propiedad para establecer la casilla seleccionada y manejar los cambios en el estado del juego
        public ClsCasilla CasillaSeleccionada
        {
            set
            {
                // Asigna la casilla seleccionada al tablero
                tablero.CasillaSeleccionada = value;

                // Reinicia el tablero si se quedan sin vidas
                if (tablero.Vidas <= 0)
                {
                    tablero = new ClsTablero(1);
                    NotifyPropertyChanged("Tablero");
                }
                // Pasa al siguiente nivel si se alcanzan los aciertos necesarios
                else if (tablero.Aciertos >= ManejadoraBL.GetCasillasARevelar(tablero.Dificultad))
                {
                    tablero = new ClsTablero(tablero.Dificultad + 1);
                    NotifyPropertyChanged("Tablero");
                }
            }
        }

        #endregion

        #region Constructores

        // Constructor que inicializa el tablero en el nivel 1
        public MainPageVM()
        {
            tablero = new ClsTablero(1);
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
