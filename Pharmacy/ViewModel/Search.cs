using Pharmacy;
using Pharmacy.Views;
using PharmacyCourseProject.ViewModel.Commands;
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
    public class Search : INotifyPropertyChanged
    {
        public Search(PharmacyCourseProjectEntities database)
        {
            this.database = database;
            AdminAddDrug = new AdminAddDrug(database);
        }

        #region Properties

        #region Other


        private AdminAddDrug adminAddDrug;
        public AdminAddDrug AdminAddDrug
        {
            get { return adminAddDrug; }
            set
            {
                adminAddDrug = value;
                OnPropertyChanged();
            }
        }


        PharmacyCourseProjectEntities database;

        private ObservableCollection<Drugs> searchListResult = new ObservableCollection<Drugs>();
        public ObservableCollection<Drugs> SearchListResult
        {
            get { return searchListResult; }
            set
            {
                searchListResult = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<string> searchComboBoxItems =  new ObservableCollection<string>(new List<string>()
                {
                    "Название",
                    "Фирма-производитель",
                    "Активное действующее вещество",
                    "Аналоги",
                    "Цена"
                });
        public ObservableCollection<string> SearchComboBoxItems
        {
            get { return searchComboBoxItems; }
            set
            {
                searchComboBoxItems = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Query

        private string selectedString;
        public string SelectedString
        {
            get { return selectedString; }
            set
            {
                selectedString = value;
                OnPropertyChanged();
                RangeTextboxVisibility = (selectedString.Equals("Цена") || selectedString.Equals("Срок годности")) ? Visibility.Visible : Visibility.Collapsed;
            }
        }

        private Drugs selectedListResultItem;
        public Drugs SelectedListResultItem
        {
            get { return selectedListResultItem; }
            set
            {
                selectedListResultItem = value;
                OnPropertyChanged();
            }
        }

        public string From { get; set; }
        public string To { get; set; }

        public string StringQuery { get; set; }

        #endregion

        #region Visibility

        private Visibility searchQueryVisibility;
        public Visibility SearchQueryVisibility
        {
            get { return searchQueryVisibility; }
            set
            {
                searchQueryVisibility = value;
                OnPropertyChanged();
            }
        }

        private Visibility rangeTextboxVisibility = Visibility.Collapsed;
        public Visibility RangeTextboxVisibility
        {
            get { return rangeTextboxVisibility; }
            set
            {
                rangeTextboxVisibility = value;
                OnPropertyChanged();
                SearchQueryVisibility = rangeTextboxVisibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
            }
        }

        private Visibility backVisibility = Visibility.Collapsed;
        public Visibility BackVisibility
        {
            get { return backVisibility; }
            set
            {
                backVisibility = value;
                OnPropertyChanged();
            }
        }

        private Visibility searchPanel;
        public Visibility SearchPanel
        {
            get { return searchPanel; }
            set
            {
                searchPanel = value;
                OnPropertyChanged();
            }
        }

        private Visibility searchResultList = Visibility.Collapsed;
        public Visibility SearchResultList
        {
            get { return searchResultList; }
            set
            {
                searchResultList = value;
                OnPropertyChanged();
            }
        }

        private Visibility searchErrorVisibility = Visibility.Collapsed;
        public Visibility SearchErrorVisibility
        {
            get { return searchErrorVisibility; }
            set
            {
                searchErrorVisibility = value;
                OnPropertyChanged();
            }
        }

        private Visibility drugInfo = Visibility.Collapsed;
        public Visibility DrugInfo
        {
            get { return drugInfo; }
            set
            {
                drugInfo = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        #endregion // Visibility

        #endregion // Properties

        #region Commands

        private Command search_;
        public Command Search_
        {
            get
            {
                if (search_ == null)
                    search_ = new Command(OnSearchButtonClick);
                return search_;
            }
        }

        private Command back;
        public Command Back
        {
            get
            {
                if (back == null)
                    back = new Command(OnBackIconClick);
                return back;
            }
        }

        private Command onListItemClick;
        public Command OnListItemClick
        {
            get
            {
                if (onListItemClick == null)
                    onListItemClick = new Command(getAnnotation);
                return onListItemClick;
            }
        }

        private Command getDrugs;
        public Command GetDrugs
        {
            get
            {
                if (getDrugs == null)
                    getDrugs = new Command(getAllDrugs);
                return getDrugs;
            }
        }

        #endregion

        #region Methods

        private void getAllDrugs(object obj)
        {
            if (selectedListResultItem != null)
            {
                if(selectedListResultItem.Count != 0)
                { 
                    selectedListResultItem.Count = 0;
                    if (database.SaveChanges() != 0)
                    {
                        MessageBox.Show("Вы забрали весь данный препарат");
                        SearchListResult = new ObservableCollection<Drugs>(searchListResult);
                        AdminAddDrug.NotifyAdminIsEmpty();
                        AdminAddDrug.FilterDrugs();
                    }
                    else
                        MessageBox.Show("Произошла ошибка");
                }
                else
                    MessageBox.Show("Данного препарата нет в наличии :(");
            }
            else
                MessageBox.Show("Выберите препарат!");
        }
        

        private void getAnnotation(object obj)
        {
            if (selectedListResultItem != null)
            {
                SearchResultList = Visibility.Collapsed;
                DrugInfo = Visibility.Visible;
            }
            else
                MessageBox.Show("Выберите препарат!");
        }

        private void OnSearchButtonClick(object obj)
            {
                searchListResult.Clear();
                
            switch (SelectedString)
            {
                case "Название":

                    SearchListResult = new ObservableCollection<Drugs>((from drug in database.Drugs
                                                                        where drug.Medications.Name.Contains(StringQuery)
                                                                        select drug));          

                        break;

                    case "Фирма-производитель":

                        SearchListResult = new ObservableCollection<Drugs>(from drug in database.Drugs
                                                                           where drug.Producers.FirmName.Contains(StringQuery)
                                                                           select drug);
                        break;


                    case "Активное действующее вещество":

                        SearchListResult = new ObservableCollection<Drugs>(from drug in database.Drugs
                                                                           where drug.Medications.ActiveSubstance.Contains(StringQuery)
                                                                           select drug);
                        break;


                    case "Аналоги":

                    if (database.Analogs.Where(a => a.DrugName.Equals(StringQuery)).Count() != 0)
                    {
                        foreach (var i in (from analog in database.Analogs where analog.DrugName.Equals(StringQuery) select analog))
                            foreach (var j in database.Drugs)
                                if (j.Name.Equals(i.AnalogName))
                                    SearchListResult.Add(j);
                        foreach (var i in (from analog in database.Analogs where analog.AnalogName.Equals(StringQuery) select analog))
                            foreach (var j in database.Drugs)
                                if (j.Name.Equals(i.DrugName))
                                    SearchListResult.Add(j);

                        


                    }
                        break;

                    case "Цена":

                    try
                    {
                        foreach (var i in database.Drugs)
                            if (i.Cost >= double.Parse(From) && i.Cost <= double.Parse(To))
                                searchListResult.Add(i);
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка! Неверный формат.\n Допустимый формат : xx,xx или xx где x - число");
                    }
                        break;

                }

                if (searchListResult.Count() == 0)
                {
                    SearchPanel = Visibility.Collapsed;
                    SearchResultList = Visibility.Collapsed;
                    DrugInfo = Visibility.Collapsed;
                    SearchErrorVisibility = Visibility.Visible;
                }
                else
                {
                    SearchPanel = Visibility.Collapsed;
                    SearchResultList = Visibility.Visible;
                    DrugInfo = Visibility.Collapsed;
                    SearchErrorVisibility = Visibility.Collapsed;
                }
                BackVisibility = Visibility.Visible;
            }

        private void OnBackIconClick(object obj)
        {
            if (SearchResultList == Visibility.Visible)
            {
                BackVisibility = Visibility.Collapsed;
                SearchResultList = Visibility.Collapsed;
                SearchPanel = Visibility.Visible;
            }
            else if (DrugInfo == Visibility.Visible)
            {
                DrugInfo = Visibility.Collapsed;
                SearchResultList = Visibility.Visible;
            }
            else if(SearchErrorVisibility == Visibility.Visible)
            {
                SearchErrorVisibility = Visibility.Collapsed;
                SearchPanel = Visibility.Visible;
                BackVisibility = Visibility.Collapsed;
            }
        }

        #endregion
    }
}
