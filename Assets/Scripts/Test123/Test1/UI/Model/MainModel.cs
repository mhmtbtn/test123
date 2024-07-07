using System;
using System.Runtime.CompilerServices;
using Unity.Properties;
using UnityEngine.UIElements;

namespace Test123.Test1.UI.Model
{
    public class MainModel : INotifyBindablePropertyChanged, IDataSourceViewHashProvider
    {
        private string _mainValue;
        
        public event EventHandler<BindablePropertyChangedEventArgs> propertyChanged;
        
        [CreateProperty]
        public string MainValue { get => _mainValue; 
            set {
                if (_mainValue != value)
                {
                    _mainValue = value;
                    OnPropertyChanged();
                }
            } 
        }

        private void OnPropertyChanged([CallerMemberName] string property = "")
        {
            propertyChanged?.Invoke(this, new BindablePropertyChangedEventArgs(property));
        }

        public long GetViewHashCode()
        {
            return HashCode.Combine(_mainValue);
        }
    }
}