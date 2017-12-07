using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Windows;
using Pharmacy;
using PharmacyCourseProject.ViewModel.Commands;
using Pharmacy.Database;

namespace PharmacyCourseProject.ViewModel
{
    public class AdminAddAnnotation : Validate, INotifyPropertyChanged
    {
        public AdminAddAnnotation(PharmacyCourseProjectEntities database)
        {
            this.database = database;
            MedicationDatabase = database.Medications.Local;
            med = new ObservableCollection<Medications>(MedicationDatabase);
            aDb = new AnnotationDatabase(database);
            LeaveConditions = new ObservableCollection<string>(new string[] {"По рецепту","Без рецепта"});
        }

        #region Properties
        
        #region ErrorsResult

        private string errors;
        private string errorsEdit;
        public string ErrorsAdd
        {
            get { return errors;}
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

        #endregion // ErrorsResult

        #region Visibility
        
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

        #endregion // Visibility

        #region Add


        private string addName;
        private string addEffect;
        private string addIndicationsForUse;
        private string addModeOfApplication;
        private string addSideEffects;
        private string addPregnancy;
        private string addContraindications;
        private string addDrugInteractions;
        private string addOverdose;
        private string addComposition;
        private string addPharmacologicalGroup;
        private string addActiveSubstance;
        private string addLeaveConditions;
        private string addStorageConditions;
        private string addIssueForm;

        public string AddName
        {
            get { return addName; }
            set
            {
                addName = value;
                OnPropertyChanged();
            }
        }
        public string AddEffect
        {
            get { return addEffect; }
            set
            {
                addEffect = value;
                OnPropertyChanged();
            }
        }
        public string AddIndicationsForUse
        {
            get { return addIndicationsForUse; }
            set
            {
                addIndicationsForUse = value;
                OnPropertyChanged();
            }
        }
        public string AddModeOfApplication
        {
            get { return addModeOfApplication; }
            set
            {
                addModeOfApplication = value;
                OnPropertyChanged();
            }
        }
        public string AddSideEffects
        {
            get { return addSideEffects; }
            set
            {
                addSideEffects = value;
                OnPropertyChanged();
            }
        }
        public string AddPregnancy
        {
            get { return addPregnancy; }
            set
            {
                addPregnancy = value;
                OnPropertyChanged();
            }
        }
        public string AddContraindications
        {
            get { return addContraindications; }
            set
            {
                addContraindications = value;
                OnPropertyChanged();
            }
        }
        public string AddDrugInteractions
        {
            get { return addDrugInteractions; }
            set
            {
                addDrugInteractions = value;
                OnPropertyChanged();
            }
        }
        public string AddOverdose
        {
            get { return addOverdose; }
            set
            {
                addOverdose = value;
                OnPropertyChanged();
            }
        }
        public string AddComposition
        {
            get { return addComposition; }
            set
            {
                addComposition = value;
                OnPropertyChanged();
            }
        }
        public string AddPharmacologicalGroup
        {
            get { return addPharmacologicalGroup; }
            set
            {
                addPharmacologicalGroup = value;
                OnPropertyChanged();
            }
        }
        public string AddActiveSubstance
        {
            get { return addActiveSubstance; }
            set
            {
                addActiveSubstance = value;
                OnPropertyChanged();
            }
        }
        public string AddLeaveConditions
        {
            get { return addLeaveConditions; }
            set
            {
                addLeaveConditions = value;
                OnPropertyChanged();
            }
        }
        public string AddStorageConditions
        {
            get { return addStorageConditions; }
            set
            {
                addStorageConditions = value;
                OnPropertyChanged();
            }
        }
        public string AddIssueForm
        {
            get { return addIssueForm; }
            set
            {
                addIssueForm = value;
                OnPropertyChanged();
            }
        }

        #endregion // Add

        #region Edit

        public Medications selectedItem
        {
            set
            {
                Medications med = new Medications();
                med = value;
                EditName = med.Name;
                EditEffect = med.PharmachologicEffect;
                EditIndicationsForUse = med.IndicationsForUse;
                EditModeOfApplication = med.ModeOfApplication;
                EditSideEffects = med.SideEffects;
                EditPregnancy = med.Pregnancy;
                EditContraindications = med.Contraindications;
                EditDrugInteractions = med.DrugInteractions;
                EditOverdose = med.Overdose;
                EditComposition = med.Composition;
                EditPharmacologicalGroup = med.PharmacologicalGroup;
                EditActiveSubstance = med.ActiveSubstance;
                EditLeaveConditions = med.LeaveConditions;
                EditStorageConditions = med.StorageConditions;
                EditIssueForm = med.IssueForm;
            }
        }
        private Medications editMedication;

        private string editName;
        private string editEffect;
        private string editIndicationsForUse;
        private string editModeOfApplication;
        private string editSideEffects;
        private string editPregnancy;
        private string editContraindications;
        private string editDrugInteractions;
        private string editOverdose;
        private string editComposition;
        private string editPharmacologicalGroup;
        private string editActiveSubstance;
        private string editLeaveConditions;
        private string editStorageConditions;
        private string editIssueForm;

        public string EditName
        {
            get { return editName; }
            set
            {
                editName = value;
                OnPropertyChanged();
            }
        }
        public string EditEffect
        {
            get { return editEffect; }
            set
            {
                editEffect = value;
                OnPropertyChanged();
            }
        }
        public string EditIndicationsForUse
        {
            get { return editIndicationsForUse; }
            set
            {
                editIndicationsForUse = value;
                OnPropertyChanged();
            }
        }
        public string EditModeOfApplication
        {
            get { return editModeOfApplication; }
            set
            {
                editModeOfApplication = value;
                OnPropertyChanged();
            }
        }
        public string EditSideEffects
        {
            get { return editSideEffects; }
            set
            {
                editSideEffects = value;
                OnPropertyChanged();
            }
        }
        public string EditPregnancy
        {
            get { return editPregnancy; }
            set
            {
                editPregnancy = value;
                OnPropertyChanged();
            }
        }
        public string EditContraindications
        {
            get { return editContraindications; }
            set
            {
                editContraindications = value;
                OnPropertyChanged();
            }
        }
        public string EditDrugInteractions
        {
            get { return editDrugInteractions; }
            set
            {
                editDrugInteractions = value;
                OnPropertyChanged();
            }
        }
        public string EditOverdose
        {
            get { return editOverdose; }
            set
            {
                editOverdose = value;
                OnPropertyChanged();
            }
        }
        public string EditComposition
        {
            get { return editComposition; }
            set
            {
                editComposition = value;
                OnPropertyChanged();
            }
        }
        public string EditPharmacologicalGroup
        {
            get { return editPharmacologicalGroup; }
            set
            {
                editPharmacologicalGroup = value;
                OnPropertyChanged();
            }
        }
        public string EditActiveSubstance
        {
            get { return editActiveSubstance; }
            set
            {
                editActiveSubstance = value;
                OnPropertyChanged();
            }
        }
        public string EditLeaveConditions
        {
            get { return editLeaveConditions; }
            set
            {
                editLeaveConditions = value;
                OnPropertyChanged();
            }
        }
        public string EditStorageConditions
        {
            get { return editStorageConditions; }
            set
            {
                editStorageConditions = value;
                OnPropertyChanged();
            }
        }
        public string EditIssueForm
        {
            get { return editIssueForm; }
            set
            {
                editIssueForm = value;
                OnPropertyChanged();
            }
        }

        #endregion // Edit

        #region Search

        private string searchName;
        private string searchEffect;
        private string searchIndicationsForUse;
        private string searchModeOfApplication;
        private string searchSideEffects;
        private string searchPregnancy;
        private string searchContraindications;
        private string searchDrugInteractions;
        private string searchOverdose;
        private string searchComposition;
        private string searchPharmacologicalGroup;
        private string searchActiveSubstance;
        private string searchLeaveConditions;
        private string searchStorageConditions;
        private string searchIssueForm;

        public string SearchName
        {
            get {return searchName;}
            set
            {
                searchName = value;
                OnPropertyChanged();
            }
        }
        public string SearchEffect
        {
            get { return searchEffect; }
            set
            {
                searchEffect = value;
                OnPropertyChanged();
            }
        }
        public string SearchIndicationsForUse
        {
            get { return searchIndicationsForUse; }
            set
            {
                searchIndicationsForUse = value;
                OnPropertyChanged();
            }
        }
        public string SearchModeOfApplication
        {
            get { return searchModeOfApplication; }
            set
            {
                searchModeOfApplication = value;
                OnPropertyChanged();
            }
        }
        public string SearchSideEffects
        {
            get { return searchSideEffects; }
            set
            {
                searchSideEffects = value;
                OnPropertyChanged();
            }
        }
        public string SearchPregnancy
        {
            get { return searchPregnancy; }
            set
            {
                searchPregnancy = value;
                OnPropertyChanged();
            }
        }
        public string SearchContraindications
        {
            get { return searchContraindications; }
            set
            {
                searchContraindications = value;
                OnPropertyChanged();
            }
        }
        public string SearchDrugInteractions
        {
            get { return searchDrugInteractions; }
            set
            {
                searchDrugInteractions = value;
                OnPropertyChanged();
            }
        }
        public string SearchOverdose
        {
            get { return searchOverdose; }
            set
            {
                searchOverdose = value;
                OnPropertyChanged();
            }
        }
        public string SearchComposition
        {
            get { return searchComposition; }
            set
            {
                searchComposition = value;
                OnPropertyChanged();
            }
        }
        public string SearchPharmacologicalGroup
        {
            get { return searchPharmacologicalGroup; }
            set
            {
                searchPharmacologicalGroup = value;
                OnPropertyChanged();
            }
        }
        public string SearchActiveSubstance
        {
            get { return searchActiveSubstance; }
            set
            {
                searchActiveSubstance = value;
                OnPropertyChanged();
            }
        }
        public string SearchLeaveConditions
        {
            get { return searchLeaveConditions; }
            set
            {
                searchLeaveConditions = value;
                OnPropertyChanged();
            }
        }
        public string SearchStorageConditions
        {
            get { return searchStorageConditions; }
            set
            {
                searchStorageConditions = value;
                OnPropertyChanged();
            }
        }
        public string SearchIssueForm
        {
            get { return searchIssueForm; }
            set
            {
                searchIssueForm = value;
                OnPropertyChanged();
            }
        }

        #endregion // Search

        #region Other

        AnnotationDatabase aDb;

        PharmacyCourseProjectEntities database;
        private string editButton = "Изменить";
        public string EditButton
        {
            get { return editButton; }
            set
            {
                editButton = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<string> LeaveConditions { get; set; }

        private ObservableCollection<Medications> MedicationDatabase { get; set; }
        private ObservableCollection<Medications> med = new ObservableCollection<Medications>();
        public ObservableCollection<Medications> Med
        {
            get { return med; }
            set
            {
                med = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        #endregion // Other

        #endregion // Properties

        #region Methods

        private bool ValidateAdd()
        {
            ErrorsAdd = null;
            ErrorsAdd += ReturnErrorsString(AddName, "Название препарата", 50);
            ErrorsAdd += ReturnErrorsString_(AddEffect, "Фармакологический эффект", 3000);
            ErrorsAdd += ReturnErrorsString_(AddIndicationsForUse, "Показания к применению", 1000);
            ErrorsAdd += ReturnErrorsString_(AddModeOfApplication, "Способ применения", 1000);
            ErrorsAdd += ReturnErrorsString(AddSideEffects, "Побочные эффекты", 1000);
            ErrorsAdd += ReturnErrorsString_(AddPregnancy, "Беременность", 1000);
            ErrorsAdd += ReturnErrorsString_(AddContraindications, "Противопоказания", 1000);
            ErrorsAdd += ReturnErrorsString_(AddDrugInteractions, "Лекарственное взаимодействие", 1000);
            ErrorsAdd += ReturnErrorsString(AddOverdose, "Передозировка", 1000);
            ErrorsAdd += ReturnErrorsString_(AddComposition, "Состав", 1000);
            ErrorsAdd += ReturnErrorsString_(AddPharmacologicalGroup, "Фармакологическая группа", 100);
            ErrorsAdd += ReturnErrorsString_(AddActiveSubstance, "Действующее вещество", 50);
            ErrorsAdd += ReturnErrorsString_(AddLeaveConditions, "Условия отпуска", 20);
            ErrorsAdd += ReturnErrorsString_(AddStorageConditions, "Условия хранения", 500);
            ErrorsAdd += ReturnErrorsString_(AddIssueForm, "Форма выпуска", 50);
            if (ErrorsAdd.Equals(""))
            {
                ErrorVisibility = Visibility.Collapsed;
                return true;
            }
            else
                ErrorVisibility = Visibility.Visible;
            return false;
        }
        private bool ValidateEdit()
        {
            ErrorsEdit = null;
            ErrorsEdit += ReturnErrorsString(EditName, "Название препарата", 50);
            ErrorsEdit += ReturnErrorsString_(EditEffect, "Фармакологический эффект", 3000);
            ErrorsEdit += ReturnErrorsString_(EditIndicationsForUse, "Показания к применению", 1000);
            ErrorsEdit += ReturnErrorsString_(EditModeOfApplication, "Способ применения", 1000);
            ErrorsEdit += ReturnErrorsString(EditSideEffects, "Побочные эффекты", 1000);
            ErrorsEdit += ReturnErrorsString_(EditPregnancy, "Беременность", 1000);
            ErrorsEdit += ReturnErrorsString_(EditContraindications, "Противопоказания", 1000);
            ErrorsEdit += ReturnErrorsString_(EditDrugInteractions, "Лекарственное взаимодействие", 1000);
            ErrorsEdit += ReturnErrorsString(EditOverdose, "Передозировка", 1000);
            ErrorsEdit += ReturnErrorsString_(EditComposition, "Состав", 1000);
            ErrorsEdit += ReturnErrorsString_(EditPharmacologicalGroup, "Фармакологическая группа", 100);
            ErrorsEdit += ReturnErrorsString_(EditActiveSubstance, "Действующее вещество", 50);
            ErrorsEdit += ReturnErrorsString_(EditLeaveConditions, "Условия отпуска", 20);
            ErrorsEdit += ReturnErrorsString_(EditStorageConditions, "Условия хранения", 500);
            ErrorsEdit += ReturnErrorsString_(EditIssueForm, "Форма выпуска", 50);
            if (ErrorsEdit.Equals(""))
            {
                ErrorEditVisibility = Visibility.Collapsed;
                return true;
            }
            else
                ErrorEditVisibility = Visibility.Visible;
            return false;
        }
        
        private void AddClick(object obj)
        {
            if (ValidateAdd())
            {
                MessageBox.Show(aDb.Add(aDb.GetMedicationClassObject(addName,addActiveSubstance,addComposition,
                    addContraindications, addDrugInteractions, addIndicationsForUse, addIssueForm,
                    addLeaveConditions, addModeOfApplication, addOverdose, addEffect, addPharmacologicalGroup,
                    addPregnancy, addSideEffects, addStorageConditions)), "Результат добавления");

                Med = new ObservableCollection<Medications>(MedicationDatabase);
                ErrorsAdd = null;
            }
        }
        private void SearchClick(object obj)
        {
            Med.Clear();
            if (MedicationDatabase != null)
                foreach (var m in MedicationDatabase)
                    if (IsContain(m))
                        Med.Add(m);
        }

        private bool IsContain(Medications m)
        {
            if (!string.IsNullOrWhiteSpace(searchName) && !m.Name.Contains(searchName))
                return false;
            if (!string.IsNullOrWhiteSpace(searchPharmacologicalGroup) && !m.PharmacologicalGroup.Contains(searchPharmacologicalGroup))
                return false;
            return true;
        }

        private void EditClick(object obj)
        {
            if(ValidateEdit())
            { 
                if(EditButton.Equals("Изменить"))
                {
                    EditButton = "Сохранить";
                    editMedication = aDb.GetMedicationClassObject(editName, editActiveSubstance, editComposition,
                        editContraindications, editDrugInteractions, editIndicationsForUse, editIssueForm,
                        editLeaveConditions, editModeOfApplication, editOverdose, editEffect, editPharmacologicalGroup, 
                        editPregnancy, editSideEffects, editStorageConditions);
                    CancelButton = Visibility.Visible;
                }
                else
                {
                    if(ValidateEdit())
                    {
                        CancelButton = Visibility.Collapsed;
                        EditButton = "Изменить";
                        MessageBox.Show(aDb.Change(editMedication,aDb.GetMedicationClassObject(editName, editActiveSubstance, editComposition,
                        editContraindications, editDrugInteractions, editIndicationsForUse, editIssueForm,
                        editLeaveConditions, editModeOfApplication, editOverdose, editEffect, editPharmacologicalGroup,
                        editPregnancy, editSideEffects, editStorageConditions)),"Рузультат изменения");
                        Med = new ObservableCollection<Medications>(MedicationDatabase);

                    }
                }
            
            }
        }
        private void DeleteClick(object obj)
        {
            if(ValidateEdit())
            {
                MessageBox.Show(aDb.Remove(aDb.GetMedicationClassObject(editName, editActiveSubstance, editComposition,
                        editContraindications, editDrugInteractions, editIndicationsForUse, editIssueForm,
                        editLeaveConditions, editModeOfApplication, editOverdose, editEffect, editPharmacologicalGroup,
                        editPregnancy, editSideEffects, editStorageConditions)),"Результат удаления");
                Med = new ObservableCollection<Medications>(MedicationDatabase);
            }
        }
        private void CancelClick(object obj)
        {
            EditButton = "Изменить";
            CancelButton = Visibility.Collapsed;
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
