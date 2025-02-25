using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ClsCasilla: INotifyPropertyChanged
    {
        #region Atributos

        // Indica si la casilla es segura (no contiene una bomba)
        private bool seguro;

        // Indica si la casilla ha sido revelada
        private bool revelado = false;

        // Ruta de la imagen asociada a la casilla
        private string foto = "reverso.png";

        #endregion

        #region Propiedades

        // Propiedad para acceder y modificar si la casilla es segura
        public bool Seguro
        {
            get { return seguro; }
            set
            {
                seguro = value;
            }
        }

        // Propiedad para acceder y modificar si la casilla ha sido revelada
        // Cambia la imagen asociada según el estado de la casilla
        public bool Revelado
        {
            get { return revelado; }
            set
            {
                revelado = true;

                if (seguro)
                {
                    foto = "segura.png";
                }
                else
                {
                    foto = "bomba.png";
                }

                NotifyPropertyChanged("Foto");
            }
        }

        // Propiedad para acceder a la imagen asociada a la casilla
        public string Foto
        {
            get { return foto; }
        }

        #endregion

        #region Constructores

        // Constructor que inicializa una nueva casilla como segura
        public ClsCasilla()
        {
            seguro = true;
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
