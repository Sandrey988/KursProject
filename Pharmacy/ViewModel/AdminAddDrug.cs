using Pharmacy;
using Pharmacy.Database;
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
    public class AdminAddDrug : Validate, INotifyPropertyChanged
    {
        public AdminAddDrug(PharmacyCourseProjectEntities database)
        {
            this.database = database;
            drugsDatabase = new DrugsDatabase(database);
            Drugs = database.Drugs.Local;
            Drugs_ = new ObservableCollection<Drugs>(Drugs);
            NotifyAdminIsEmpty();
        }

        #region Properties

        #region Other

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

        private Visibility notification = Visibility.Collapsed;
        public Visibility Notification
        {
            get { return notification; }
            set
            {
                notification = value;
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

        DrugsDatabase drugsDatabase;

        public Drugs selectedItem {
            set
            {
                EditName = value.Medications.Name;
                EditDiscount = value.Discount.Discount1.ToString();
                EditCost = value.Cost.ToString();
                EditCount = value.Count.ToString();
                EditEndDate = value.DisposeDate.ToString();
                EditStartDate = value.ManufactureDate.ToString();
                EditProducer = value.Producers.FirmName;
            }
        }


        PharmacyCourseProjectEntities database;

        private string errors;
        private string errorsEdit;
        private string editButton = "Изменить";
        public string ErrorsAdd
        {
            get { return errors; }
            set
            {
                errors = value;
                OnPropertyChanged();
            }
        }
        public string ErrorsEdit
        {
            get { return errorsEdit; }
            set
            {
                errorsEdit = value;
                OnPropertyChanged();
            }
        }
        public string EditButton
        {
            get { return editButton; }
            set
            {
                editButton = value;
                OnPropertyChanged();
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        #endregion

        #region Add

        private string addId;
        private string addName;
        private string addStartDate;
        private string addEndDate;
        private string addCost;
        private string addProducer;
        private string addCount;
        private string addDiscount;
        
        public string AddId
        {
            get { return addId; }
            set
            {
                addId = value;
                OnPropertyChanged();
            }
        }
        public string AddName
        {
            get { return addName; }
            set
            {
                addName = value;
                OnPropertyChanged();
            }
        }
        public string AddStartDate
        {
            get { return addStartDate; }
            set
            {
                addStartDate = value;
                OnPropertyChanged();
            }
        }
        public string AddEndDate
        {
            get { return addEndDate; }
            set
            {
                addEndDate = value;
                OnPropertyChanged();
            }
        }
        public string AddCost
        {
            get { return addCost; }
            set
            {
                addCost = value;
                OnPropertyChanged();
            }
        }
        public string AddProducer
        {
            get { return addProducer; }
            set
            {
                addProducer = value;
                OnPropertyChanged();
            }
        }
        public string AddCount
        {
            get { return addCount; }
            set
            {
                addCount = value;
                OnPropertyChanged();
            }
        }
        public string AddDiscount
        {
            get { return addDiscount; }
            set
            {
                addDiscount = value;
                OnPropertyChanged();
            }
        }

        #endregion // Add

        #region Edit

        private Drugs changedDrug;
        private Discount changedDiscount;

        private string editId;
        private string editName;
        private string editStartDate;
        private string editEndDate;
        private string editCost;
        private string editProducer;
        private string editCount;
        private string editDiscount;

        public string EditId
        {
            get { return editId; }
            set
            {
                editId = value;
                OnPropertyChanged();
            }
        }
        public string EditName
        {
            get { return editName; }
            set
            {
                editName = value;
                OnPropertyChanged();
            }
        }
        public string EditStartDate
        {
            get { return editStartDate; }
            set
            {
                editStartDate = value;
                OnPropertyChanged();
            }
        }
        public string EditEndDate
        {
            get { return editEndDate; }
            set
            {
                editEndDate = value;
                OnPropertyChanged();
            }
        }
        public string EditCost
        {
            get { return editCost; }
            set
            {
                editCost = value;
                OnPropertyChanged();
            }
        }
        public string EditProducer
        {
            get { return editProducer; }
            set
            {
                editProducer = value;
                OnPropertyChanged();
            }
        }
        public string EditCount
        {
            get { return editCount; }
            set
            {
                editCount = value;
                OnPropertyChanged();
            }
        }
        public string EditDiscount
        {
            get { return editDiscount; }
            set
            {
                editDiscount = value;
                OnPropertyChanged();
            }
        }

        #endregion // Edit

        #region Search

        private string notifyMessage;
        public string NotifyMessage
        {
            get { return notifyMessage; }
            set
            {
                notifyMessage = value;
                OnPropertyChanged();
            }
        }

   
        private ObservableCollection<Drugs> Drugs { get; set; }
        private ObservableCollection<Drugs> drugs_;
        public ObservableCollection<Drugs> Drugs_
        {
            get { return drugs_; }
            set
            {
                drugs_ = value;
                OnPropertyChanged();
            }
        }
        
        private string searchName;
        private string searchStartDate;
        private string searchEndDate;
        private string searchCost;
        private string searchProducer;

 
        public string SearchName
        {
            get { return searchName; }
            set
            {
                searchName = value;
                OnPropertyChanged();
            }
        }
        public string SearchStartDate
        {
            get { return searchStartDate; }
            set
            {
                searchStartDate = value;
                OnPropertyChanged();
            }
        }
        public string SearchEndDate
        {
            get { return searchEndDate; }
            set
            {
                searchEndDate = value;
                OnPropertyChanged();
            }
        }
        public string SearchCost
        {
            get { return searchCost; }
            set
            {
                searchCost = value;
                OnPropertyChanged();
            }
        }
        public string SearchProducer
        {
            get { return searchProducer; }
            set
            {
                searchProducer = value;
                OnPropertyChanged();
            }
        }

        #endregion // Search


        #endregion // Properties

        #region Methods

        private bool ValidateAdd()
        {
            ErrorsAdd = null;
            ErrorsAdd += ReturnErrorsString(addName, "Название препарата", 50);
            ErrorsAdd += ReturnErrorsDate(addStartDate, "Дата производства");
            ErrorsAdd += ReturnErrorsDate(addEndDate, "Дата утилизации");
            ErrorsAdd += ReturnErrorsInt(addCost, "Стоимость", 5);
            ErrorsAdd += ReturnErrorsInt_(addDiscount, "Скидка", 100);
            ErrorsAdd += ReturnErrorsInt_(addCount, "Количество", 10000);
            if (!ErrorsAdd.Equals(""))
            {
                ErrorVisibility = Visibility.Visible;
                return false;
            }
            else
                ErrorVisibility = Visibility.Collapsed;
            return true;
        }
        private bool ValidateEdit()
        {
            ErrorsEdit = null;
            ErrorsEdit += ReturnErrorsString(editName, "Название препарата", 50);
            ErrorsEdit += ReturnErrorsDate(editStartDate, "Дата производства");
            ErrorsEdit += ReturnErrorsDate(editEndDate, "Дата утилизации");
            ErrorsEdit += ReturnErrorsInt(editCost, "Стоимость", 5);
            ErrorsEdit += ReturnErrorsInt_(editDiscount, "Скидка", 100);
            ErrorsEdit += ReturnErrorsInt_(editCount, "Количество", 10000);
            if (!ErrorsEdit.Equals(""))
            {
                ErrorEditVisibility = Visibility.Visible;
                return false;
            }
            else
                ErrorEditVisibility = Visibility.Collapsed;
            return true;
        }
        private void EditClick(object obj)
        {
            if(ValidateEdit())
            { 
                if(EditButton.Equals("Изменить"))
                {
                    if (drugsDatabase.IsExist(drugsDatabase.GetDrugClassObject(editName, DateTime.Parse(editStartDate), DateTime.Parse(editEndDate), int.Parse(editCount), int.Parse(editCost), editProducer)))
                    {
                        changedDrug = drugsDatabase.GetDrugClassObject(editName, DateTime.Parse(editStartDate), DateTime.Parse(editEndDate), int.Parse(editCount), int.Parse(editCost), editProducer);
                        changedDiscount = drugsDatabase.GetDiscountClassObject(changedDrug, int.Parse(editDiscount));
                        EditButton = "Сохранить";
                        CancelButton = Visibility.Visible;
                    }
                    else
                        MessageBox.Show("Данного объекта не существует","Ошибка");
                }
                else
                {
                    if (ValidateEdit())
                    {
                        MessageBox.Show(drugsDatabase.Change(changedDrug,
                            drugsDatabase.GetDrugClassObject(editName, DateTime.Parse(editStartDate), DateTime.Parse(editEndDate), int.Parse(editCount), int.Parse(editCost), editProducer),
                            changedDiscount, drugsDatabase.GetDiscountClassObject(changedDrug, int.Parse(editDiscount)))
                        , "Результат изменения");
                        CancelButton = Visibility.Collapsed;
                        EditButton = "Изменить";
                        FilterDrugs();
                        NotifyAdminIsEmpty();
                    }
                    else
                        MessageBox.Show("Введите корректные данные!");
                }
            }
        }
        private void CancelClick(object obj)
        {
            EditButton = "Изменить";
            CancelButton = Visibility.Collapsed;
        }
        private void AddClick(object obj)
        {
            if(ValidateAdd())
            {
                Drugs drug;
                MessageBox.Show(drugsDatabase.Add(
                   drug =  drugsDatabase.GetDrugClassObject(addName, DateTime.Parse(addStartDate), DateTime.Parse(addEndDate), int.Parse(addCount), int.Parse(addCost), addProducer),
                drugsDatabase.GetDiscountClassObject(drug, int.Parse(addDiscount))
                ),"Результат добавления");
                FilterDrugs();
                NotifyAdminIsEmpty();
            }
        }
        private void SearchClick(object obj)
        {
            FilterDrugs();
        }
        public void NotifyAdminIsEmpty()
        {
            NotifyMessage = null;
            NotifyMessage = "Добавьте пожалуйста препараты:\n";
            foreach (var i in Drugs)
                if (i.Count == 0)
                    NotifyMessage += '-' + i.Medications.Name + '\n';
            if (!NotifyMessage.Equals("Добавьте пожалуйста препараты:\n"))
                Notification = Visibility.Visible; 
            else
                Notification = Visibility.Collapsed;
        }
        public void FilterDrugs()
        {
            Drugs_.Clear();
            if (Drugs != null)
                foreach (var a in Drugs)
                    if(FilterDrugs(a))
                        Drugs_.Add(a);
        }
        private bool FilterDrugs(Drugs a)
        {
            if (!string.IsNullOrWhiteSpace(searchCost) && !a.Cost.ToString().Contains(searchCost))
                return false;
            if (!string.IsNullOrWhiteSpace(searchEndDate) && !a.DisposeDate.ToString().Contains(searchEndDate))
                return false;
            if (!string.IsNullOrWhiteSpace(searchStartDate) && !a.ManufactureDate.ToString().Contains(searchStartDate))
                return false;
            if (!string.IsNullOrWhiteSpace(searchName) && !a.Medications.Name.Contains(searchName))
                return false;
            if (!string.IsNullOrWhiteSpace(searchProducer) && !a.Producers.FirmName.Contains(searchProducer))
                return false;
            return true;
        }
        private void DeleteClick(object obj)
        {
            if(ValidateEdit())
            {
                MessageBox.Show(drugsDatabase.Remove(drugsDatabase.GetDrugClassObject(editName, DateTime.Parse(editStartDate), DateTime.Parse(editEndDate), int.Parse(editCount), int.Parse(editCost), editProducer)), "Результаты удаления");
                FilterDrugs();
                NotifyAdminIsEmpty();
            }
        }

        #endregion // Methods

        #region Commands

        private Command add;
        public Command Add
        {
            get
            {
                if (add == null)
                    add = new Command(AddClick);
                return add;
            }
        }

        private Command search;
        public Command Search
        {
            get
            {
                if (search == null)
                    search = new Command(SearchClick);
                return search;
            }
        }

        private Command edit;
        public Command Edit
        {
            get
            {
                if (edit == null)
                    edit = new Command(EditClick);
                return edit;
            }
        }

        private Command delete;
        public Command Delete
        {
            get
            {
                if (delete == null)
                    delete = new Command(DeleteClick);
                return delete;
            }
        }

        private Command cancel;
        public Command Cancel
        {
            get
            {
                if (cancel == null)
                    cancel = new Command(CancelClick);
                return cancel;
            }
        }

        #endregion // Commands
    }
}
