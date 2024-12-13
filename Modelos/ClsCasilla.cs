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

        private bool seguro;
        private bool revelado = false;
        private string foto;

        #endregion

        #region Propiedades

        public bool Seguro
        {
            get { return seguro; }
            set
            {
                seguro = true;
            }
        }

        public bool Revelado
        {
            get {return revelado; }
            set
            {
                revelado = true;
                //TODO cambiar foto
            }
        }

        public string Foto
        {
            get { return foto; }
        }

        #endregion

        #region Constructores

        //No hace falta

        #endregion

        #region NotifyPropertyChanged

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        #endregion
    }
}
