using UnityEngine.UIElements;

namespace Test123.Test1.UI
{
    public abstract class ViewModel<TData> : IViewModel<TData>
    {
        public TData Data { get; }
        
        protected UIDocument TargetDocument { get; private set; }

        protected ViewModel(TData data, UIDocument targetDocument)
        {
            Data = data;
            TargetDocument = targetDocument;
        }
    }
}