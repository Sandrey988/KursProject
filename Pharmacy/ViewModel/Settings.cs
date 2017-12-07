using Pharmacy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyCourseProject.ViewModel
{
    public class Settings : INotifyPropertyChanged
    {
        PharmacyDatabase database;

        public Settings(PharmacyDatabase database)
        {
            this.database = database;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
