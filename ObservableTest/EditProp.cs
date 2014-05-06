using System;

namespace ObservableTest
{
    public class EditProp<T> : ObservableObject, IObservable<T>
    {
        private T _value;
        private IObserver<T> _observer;

        public T Value
        {
            get { return _value; }
            set
            {
                if (value != null || !_value.Equals(value))
                {
                    _value = value;
                    _observer.OnNext(_value);
                }
            }
        }

        public IDisposable Subscribe(IObserver<T> observer)
        {
            _observer = observer;
            return null;
        }
    }
}
