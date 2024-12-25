using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    /*
     * 1. Adım: Gözlemci interface'i tanımlanır.
     */

    public interface IObserver
    {

        //Gözlemci, durum tetiklendiğinde aşağıdaki metodu çağıracak:
        void ChangeColor(Color color);
    }

    //2: Abone olunacak (Gözlemlenecek) arayüz:
    public interface ISubscription
    {
        void Subscribe(IObserver observer);
        void Unsubscribe(IObserver observer);
        void Notify();
    }

    public class ObservableColorSubscription : ISubscription
    {
        private Color color;
        private List<IObserver> observers = new();

        public Color Color
        {
            get { return color; }
            set
            {
                color = value;
                Notify();
            }
        }
        public void Notify()
        {
            observers.ForEach(observer => observer.ChangeColor(color));
        }

        public void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
