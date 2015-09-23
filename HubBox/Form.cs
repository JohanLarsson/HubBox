using System.Collections.ObjectModel;

namespace HubBox
{
    public class Form
    {
        private readonly ObservableCollection<int> _items=new ObservableCollection<int>();

        public Form(string name)
        {
            Name = name;
        }

        public string Name { get; }
        public ObservableCollection<int> Items => _items;
    }
}