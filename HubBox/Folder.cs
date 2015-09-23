using System.Collections.ObjectModel;

namespace HubBox
{
    public class Folder
    {
        private readonly ObservableCollection<Form> _forms = new ObservableCollection<Form>();
        public Folder(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public ObservableCollection<Form> Forms => _forms;
    }
}
