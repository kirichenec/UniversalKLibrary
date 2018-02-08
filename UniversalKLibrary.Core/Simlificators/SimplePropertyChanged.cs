using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace UniversalKLibrary.Core.Simlificators
{
    public class SimplePropertyChanged : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged realization
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
