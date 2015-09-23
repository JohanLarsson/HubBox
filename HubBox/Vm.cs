using System.Collections.ObjectModel;

namespace HubBox
{
    public class Vm
    {
        private readonly ObservableCollection<Folder> _folders = new ObservableCollection<Folder>();

        public Vm()
        {
            var folder1 = new Folder("1");
            folder1.Forms.Add(new Form("1_1"));
            folder1.Forms.Add(new Form("1_2"));
            _folders.Add(folder1);

            var folder2 = new Folder("2");
            folder2.Forms.Add(new Form("2_1"));
            folder2.Forms.Add(new Form("2_2"));
            _folders.Add(folder2);
        }

        public ObservableCollection<Folder> Folders => _folders;

    }
}