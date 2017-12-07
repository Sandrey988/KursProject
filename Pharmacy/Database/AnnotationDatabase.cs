using PharmacyCourseProject.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Pharmacy.Database
{
    class AnnotationDatabase
    {
        PharmacyCourseProjectEntities database;

        public AnnotationDatabase(PharmacyCourseProjectEntities Database)
        {
            database = Database;
        }
        public string Add(Medications med)
        {
            if (!IsExist(med))
            {
                database.Medications.Add(med);

                if (IsDatabaseChanged())
                {
                    return "Аннотация добавлена!";
                }
                return "Ошибка добавления в EF";
            }
            else return "Данная аннотация уже занесена в БД.";
        }
        public string Change(Medications changedMed, Medications newMed)
        {
            if (IsExist(changedMed))
            {
                if (!IsExist(newMed))
                {
                    changedMed = ReturnMed(changedMed).First();
                    changedMed.ActiveSubstance = newMed.ActiveSubstance;
                    changedMed.Composition = newMed.Composition;
                    changedMed.Contraindications = newMed.Contraindications;
                    changedMed.DrugInteractions = newMed.DrugInteractions;
                    changedMed.IndicationsForUse = newMed.IndicationsForUse;
                    changedMed.IssueForm = newMed.IssueForm;
                    changedMed.LeaveConditions = newMed.LeaveConditions;
                    changedMed.ModeOfApplication = newMed.ModeOfApplication;
                    changedMed.Overdose = newMed.Overdose;
                    changedMed.PharmachologicEffect = newMed.PharmachologicEffect;
                    changedMed.PharmacologicalGroup = newMed.PharmacologicalGroup;
                    changedMed.Pregnancy = newMed.Pregnancy;
                    changedMed.SideEffects = newMed.SideEffects;
                    changedMed.StorageConditions = newMed.StorageConditions;
                    

                    if (IsDatabaseChanged())
                    {
                        return "Аннотация изменена!";
                    }
                    return "Ошибка изменения в EF";
                }
                else
                    return "Новая аннотация уже существует в БД.";
            }
            else return "Данная аннотация не существует в БД.";
        }
        private IQueryable<Medications> ReturnMed(Medications newMed)
        {
            return database.Medications.Where( changedMed =>

            changedMed.Name.                Equals(newMed.Name) &&
            changedMed.ActiveSubstance.     Equals(newMed.ActiveSubstance) &&
            changedMed.Composition.         Equals(newMed.Composition) &&
            changedMed.Contraindications.   Equals(newMed.Contraindications) &&
            changedMed.DrugInteractions.    Equals(newMed.DrugInteractions) &&
            changedMed.IndicationsForUse.   Equals(newMed.IndicationsForUse) &&
            changedMed.IssueForm.           Equals(newMed.IssueForm) &&
            changedMed.LeaveConditions.     Equals(newMed.LeaveConditions) &&
            changedMed.ModeOfApplication.   Equals(newMed.ModeOfApplication) &&
            changedMed.Overdose.            Equals(newMed.Overdose) &&
            changedMed.PharmachologicEffect.Equals(newMed.PharmachologicEffect) &&
            changedMed.PharmacologicalGroup.Equals(newMed.PharmacologicalGroup) &&
            changedMed.Pregnancy.           Equals(newMed.Pregnancy) &&
            changedMed.SideEffects.         Equals(newMed.SideEffects) &&
            changedMed.StorageConditions.   Equals(newMed.StorageConditions));
        }
        public string Remove(Medications med)
        {
            if (IsExist(med))
            {
                if (IsRemoved(med))
                {
                    if (IsDatabaseChanged())
                    {
                        return "Аннотация удаленa!";
                    }
                    return "Ошибка удаления в EF";
                }
                return "Ошибка удаления в entity framework.";
            }
            else return "Данная аннотация не существует в БД.";
        }
        public bool IsExist(Medications med)
        {
            return ReturnMed(med).Count() != 0;
        }
        public Medications GetMedicationClassObject(string Name, string ActiveSubstance,string Composition, string Contraindications,
            string DrugInteractions, string IndicationsForUse, string IssueForm, string LeaveConditions, string ModeOfApplication,
            string Overdose, string PharmachologicEffect, string PharmacologicalGroup, string Pregnancy, string SideEffects, string StorageConditions)
        {
            Medications Med = new Medications();
            Med.Name = Name;
            Med.ActiveSubstance = ActiveSubstance;
            Med.Composition = Composition;
            Med.Contraindications = Contraindications;
            Med.DrugInteractions = DrugInteractions;
            Med.IndicationsForUse = IndicationsForUse;
            Med.IssueForm = IssueForm;
            Med.LeaveConditions = LeaveConditions;
            Med.ModeOfApplication = ModeOfApplication;
            Med.Overdose = Overdose;
            Med.PharmachologicEffect = PharmachologicEffect;
            Med.PharmacologicalGroup = PharmacologicalGroup;
            Med.Pregnancy = Pregnancy;
            Med.SideEffects = SideEffects;
            Med.StorageConditions = StorageConditions;
            return Med;
        }

        private bool IsDatabaseChanged()
        {
            return database.SaveChanges() != 0;
        }

        private bool IsRemoved(Medications med)
        {
            switch (MessageBox.Show("При удалении аннотации к препарату данный\n препарат так же будет удален из базы данных!", "Удаление", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation))
            {
                case MessageBoxResult.Cancel:
                    return false;
                case MessageBoxResult.OK:
                    foreach (var d in database.Analogs.Where(a => a.AnalogName.Equals(med.Name)))
                        database.Analogs.Remove(d);
                    return database.Medications.Remove(ReturnMed(med).First()) != null;

                default: return false;
            }
        }        
    }
}
