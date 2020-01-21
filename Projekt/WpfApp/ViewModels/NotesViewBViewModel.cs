using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.DataProviders;

namespace WpfApp.ViewModels
{
    public class NotesViewBViewModel : ViewModelBase
    {
        public NotesDataProvider NotesDataProviderClient;
        public NotesViewBViewModel(NotesDataProvider notesDataProvider)
        {
            NotesDataProviderClient = notesDataProvider;
        }
    }
}
