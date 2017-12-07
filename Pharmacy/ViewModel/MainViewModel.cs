using Pharmacy;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PharmacyCourseProject.ViewModel
{
    public class MainViewModel : DependencyObject, INotifyPropertyChanged
    {

        private ObservableCollection<Medications> medications;
        private ObservableCollection<Drugs> drugs;
        private ObservableCollection<Producers> producers;
        private ObservableCollection<PharmacologicalGroup> pharmacologicalGroup;
        private ObservableCollection<Analogs> analogs;
        private ObservableCollection<Discount> discount;

        public ObservableCollection<Medications> Medications
        {
            get { return medications; }
            set
            {
                medications = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Drugs> Drugs
        {
            get { return drugs; }
            set
            {
                drugs = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Producers> Producers
        {
            get { return producers; }
            set
            {
                producers = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<PharmacologicalGroup> PharmacologicalGroup
        {
            get { return pharmacologicalGroup; }
            set
            {
                pharmacologicalGroup = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Analogs> Analogs
        {
            get { return analogs; }
            set
            {
                analogs = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Discount> Discount
        {
            get { return discount; }
            set
            {
                discount = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            PharmacyCourseProjectEntities database = new PharmacyCourseProjectEntities();

            database.Medications.Load();
            database.Drugs.Load();
            database.PharmacologicalGroup.Load();
            database.Producers.Load();
            database.Discount.Load();
            database.Analogs.Load();

            AdminAddAnnotations = new AdminAddAnnotation(database);
            AnalogsViewModel = new AnalogsViewModel(database);
            Search = new Search(database);
            
            Discount = database.Discount.Local;
            Analogs = database.Analogs.Local;
            Producers = database.Producers.Local;
            Medications = database.Medications.Local;
            Drugs = database.Drugs.Local;
            PharmacologicalGroup = database.PharmacologicalGroup.Local;
        }

        #region Properties

        AdminAddAnnotation adminAddAnnotations;
        Search search;
        AnalogsViewModel analogsViewModel;

        public AdminAddAnnotation AdminAddAnnotations
        {
            get { return adminAddAnnotations; }
            set
            {
                adminAddAnnotations = value;
                OnPropertyChanged();
            }
        }
        public Search Search
        {
            get { return search; }
            set
            {
                search = value;
                OnPropertyChanged();
            }
        }
        public AnalogsViewModel AnalogsViewModel
        {
            get { return analogsViewModel; }
            set
            {
                analogsViewModel = value;
                OnPropertyChanged();
            }
        }

        private Visibility visibility = Visibility.Collapsed;
        public Visibility myVisibility
        {
            get { return visibility; }
            set
            {
                visibility = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Methods
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public void Collaps()
        {
            myVisibility = Visibility.Collapsed;
        }
        public void Visible()
        {
            myVisibility = Visibility.Visible;
        }
        #endregion
    }
}
