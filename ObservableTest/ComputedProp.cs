using System;
using System.Collections.Generic;

namespace ObservableTest
{
    public class ComputedProp<T> : ObservableObject
    {
        private T _value;
        private Func<T> _computation;

        public T Value
        {
            get { return _value; }
        }

        private void Compute()
        {
            _value = _computation();
            NotifyOfPropertyChange(() => Value);
        }

        public void ComputeOn(IObservable<object> observable)
        {
            observable.Subscribe(value => Compute());
        }

        public List<IObservable<object>> Observables { get; set; }

        public Func<T> Computation { set { _computation = value; } }
    }
}
