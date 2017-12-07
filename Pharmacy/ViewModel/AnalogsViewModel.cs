using Pharmacy;
using PharmacyCourseProject.Database;
using PharmacyCourseProject.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PharmacyCourseProject.ViewModel
{
    public class AnalogsViewModel : INotifyPropertyChanged
    {
        public AnalogsViewModel(PharmacyCourseProjectEntities database)
        {
            this.database = database;
            analogDatabase = new AnalogsDatabase(database);
            Analogs = database.Analogs.Local;
            Analogs_ = new ObservableCollection<Pharmacy.Analogs>(Analogs);
        }


        #region Properties

        #region Others

        PharmacyCourseProjectEntities database;
        
        AnalogsDatabase analogDatabase;

        private ObservableCollection<Analogs> Analogs { get; set; }

        private ObservableCollection<Analogs> analogs_;
        public ObservableCollection<Analogs> Analogs_
        {
            get { return analogs_; }
            set
            {
                analogs_ = value;
                OnPropertyChanged();
            }
        }

        private Visibility errorVisibility = Visibility.Collapsed;
        public Visibility ErrorVisibility
        {
            get { return errorVisibility; }
            set
            {
                errorVisibility = value;
                OnPropertyChanged();
            }
        }
        private Visibility errorEditVisibility = Visibility.Collapsed;
        public Visibility ErrorEditVisibility
        {
            get { return errorEditVisibility; }
            set
            {
                errorEditVisibility = value;
                OnPropertyChanged();
            }
        }
        private Visibility cancelButton = Visibility.Collapsed;
        public Visibility CancelButton
        {
            get { return cancelButton; }
            set
            {
                cancelButton = value;
                OnPropertyChanged();
            }
        }        

        private string errors;
        public string ErrorsAdd
        {
            get { return errors; }
            set
            {
                errors = value;
                OnPropertyChanged();
            }
        }

        private string errorsEdit;
        public string ErrorsEdit
        {
            get { return errorsEdit; }
            set
            {
                errorsEdit = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        #endregion // Others

        #region Add

        private string addDrugName;
        private string addDrugAnalogName;

        public string AddDrugName
        {
            get { return addDrugName; }
            set
            {
                addDrugName = value;
                OnPropertyChanged();
            }
        }
        public string AddDrugAnalogName
        {
            get { return addDrugAnalogName; }
            set
            {
                addDrugAnalogName = value;
                OnPropertyChanged();
            }
        }

        #endregion // Add

        #region Change

        private string changeDrugName = "";
        private string changeDrugAnalogName = "";

        private Analogs selectedAnalog;
        public Analogs SelectedAnalog
        {
            get { return selectedAnalog; }
            set
            {
                selectedAnalog = value;
                ChangeDrugName = selectedAnalog.DrugName;
                ChangeDrugAnalogName = selectedAnalog.AnalogName;
                OnPropertyChanged();
            }
        }

        public string ChangeDrugName
        {
            get { return changeDrugName; }
            set
            {
                changeDrugName = value;
                OnPropertyChanged();
            }
        }
        public string ChangeDrugAnalogName
        {
            get { return changeDrugAnalogName; }
            set
            {
                changeDrugAnalogName = value;
                OnPropertyChanged();
            }
        }

        #endregion // Change

        #region Search

        private string searchDrugName;
        private string searchDrugAnalogName;

        public string SearchDrugName
        {
            get { return searchDrugName; }
            set
            {
                searchDrugName = value;
                OnPropertyChanged();
            }
        }
        public string SearchDrugAnalogName
        {
            get { return searchDrugAnalogName; }
            set
            {
                searchDrugAnalogName = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #endregion // Properties

        #region Commands

        private Command add;
        public Command Add
        {
            get
            {
                if (add == null)
                {
                    add = new Command(Add_Method);
                }
                return add;
            }
        }
       

        private Command remove;
        public Command Remove
        {
            get
            {
                if (remove == null)
                {
                    remove = new Command(Remove_Method);
                }
                return remove;
            }
        }

        

        private Command search;
        public Command Search
        {
            get
            {
                if (search == null)
                {
                    search = new Command(Search_Method);
                }
                return search;
            }
        }

        #endregion // Commands

        #region Methods

        private void Add_Method(object obj)
        {
            if (ValidateAdd())
            {
                MessageBox.Show(analogDatabase.Add(analogDatabase.GetAnalogClassObject(addDrugName, addDrugAnalogName)),"Результат");
                FilterSearchResult();
            }
        }

        private void Remove_Method(object obj)
        {
            if (ValidateEdit())
            {
                MessageBox.Show(analogDatabase.Remove(analogDatabase.GetAnalogClassObject(changeDrugName, changeDrugAnalogName)), "Результат");
                FilterSearchResult();
            }

        }       

        private void Search_Method(object obj)
        {
            FilterSearchResult();
        }

        private void FilterSearchResult()
        {
            Analogs_.Clear();
            if (Analogs != null)
                foreach (var a in Analogs)
                    if (Filter(a))
                        Analogs_.Add(a);
        }

        private bool Filter(Analogs a)
        {
            if (!string.IsNullOrWhiteSpace(searchDrugName) && !a.DrugName.Contains(searchDrugName))
                return false;
            if (!string.IsNullOrWhiteSpace(searchDrugAnalogName) && a.AnalogName.Contains(searchDrugAnalogName))
                return false;
            return true;
        }

        private bool ValidateAdd()
        {
            ErrorsAdd = null;
            if (string.IsNullOrWhiteSpace(addDrugName))
                ErrorsAdd += "Название препарата:\nне должно быть пустым!\n";
            if (string.IsNullOrWhiteSpace(addDrugAnalogName))
                ErrorsAdd += "Название аналога:\nне должно быть пустым!\n";
            if (addDrugName.Equals(addDrugAnalogName))
                ErrorsAdd += "Ошибка:\nУ препарата и его аналога должны быть разные названия\n";
            if (ErrorsAdd != null)
            {
                ErrorVisibility = Visibility.Visible;
                return false;
            }
            else
            {
                ErrorVisibility = Visibility.Collapsed;
                return true;
            }
        }

        private bool ValidateEdit()
        {
            ErrorsEdit = null;
            if (string.IsNullOrWhiteSpace(changeDrugName))
                ErrorsEdit += "Название препарата:\nне должно быть пустым!\n";
            if (string.IsNullOrWhiteSpace(changeDrugAnalogName))
                ErrorsEdit += "Название аналога:\nне должно быть пустым!\n";
            if(changeDrugName.Equals(changeDrugAnalogName))
                ErrorsEdit += "Ошибка:\nУ препарата и его аналога должны быть разные названия\n";
            if (ErrorsEdit != null)
            { 
                ErrorEditVisibility = Visibility.Visible;
                return false;
            }
            else
            { 
                ErrorEditVisibility = Visibility.Collapsed;
                return true;
            }
        }
        
        #endregion // Methods
    }
}
