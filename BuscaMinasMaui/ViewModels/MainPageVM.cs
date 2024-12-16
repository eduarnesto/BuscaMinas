using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace BuscaMinasMaui.ViewModels
{
    public class MainPageVM
    {
        #region Atributos

        private List<ClsTablero> listadoTableros;
        private ClsTablero tableroActual;
        private ClsCasilla casillaSeleccionada;
        private int dificultad;
        
        #endregion

        #region Propiedades

        public int Dificultad
        {
            get { return dificultad; }
        }

        public ClsTablero Tablero
        {
            get { return tableroActual; }
        }

        public ClsCasilla CasillaSeleccionada
        {
            set
            {
                tableroActual.CasillaSeleccionada = value;
                //Compruebo si hay que pasar al siguiente nivel
            }
        }

        #endregion

        #region Constructores
        public MainPageVM()
        {

        }
        #endregion
    }
}
