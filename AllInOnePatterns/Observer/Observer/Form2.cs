using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer
{
    public partial class Form2 : Form, IObserver
    {
        public Form2(ObservableColorSubscription subscription)
        {

            InitializeComponent();
            this.subscription = subscription;
        }

        ObservableColorSubscription subscription;
        public void ChangeColor(Color color)
        {
            BackColor = color;
        }

        private void buttonSubscribe_Click(object sender, EventArgs e)
        {
            subscription.Subscribe(this);
        }

        private void buttonUnsubscribe_Click(object sender, EventArgs e)
        {
            subscription.Unsubscribe(this);
        }

        private void buttonCollection_Click(object sender, EventArgs e)
        {
            ObservableCollection<string> requirements = new ObservableCollection<string>();

            requirements.CollectionChanged += Requirements_CollectionChanged;
        }

        private void Requirements_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    break;
                case NotifyCollectionChangedAction.Remove:
                    break;
                case NotifyCollectionChangedAction.Replace:
                    break;
                case NotifyCollectionChangedAction.Move:
                    break;
                case NotifyCollectionChangedAction.Reset:
                    break;
                default:
                    break;
            }
        }
    }
}
