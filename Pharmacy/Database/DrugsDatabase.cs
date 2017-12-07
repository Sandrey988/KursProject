using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Database
{
    class DrugsDatabase
    {
        public DrugsDatabase(PharmacyCourseProjectEntities Database)
        {
            database = Database;
        }

        private PharmacyCourseProjectEntities database;

        public string Add(Drugs drug, Discount discount)
        {
            if (!IsExist(drug))
            {
                if (IsExistNotation(drug))
                {
                    database.Drugs.Add(drug);

                    if (IsDatabaseChanged())
                    {
                        discount.DrugId = ReturnDrugs(drug).First().DrugID;
                        database.Discount.Add(discount);
                        IsDatabaseChanged();
                        return "Препарат добавлен!";
                    }
                    return "Ошибка добавления в EF";
                }
                else
                    return "Отсутствует аннотация данного препарата!";
            }
            else
            {
                ReturnDrugs(drug).First().Count += drug.Count;
                database.SaveChanges();
                return "Данный товар был пополнен в количестве " + drug.Count + " шт.";
            }
        }

        public string Change(Drugs changedDrug, Drugs newDrug, Discount changedDiscount, Discount newDiscount)
        {
            if (IsExist(changedDrug))
            {
                    changedDrug = ReturnDrugs(changedDrug).First();
                    changedDrug.Cost = newDrug.Cost;
                    changedDrug.ManufactureDate = newDrug.ManufactureDate;
                    changedDrug.DisposeDate = newDrug.DisposeDate;
                    changedDrug.ProducerId = newDrug.ProducerId;
                    changedDrug.Count = newDrug.Count;
                    changedDiscount = ReturnDisocunt(changedDiscount).First();
                    changedDiscount.Discount1 = newDiscount.Discount1;

                    if (IsDatabaseChanged())
                    {
                        return "Препарат изменен!";
                    }
                    return "Внесите изменения!";
            }
            else return "Данный препарат не существует в БД.";
        }

        public string Remove(Drugs drug)
        {
            if (IsExist(drug))
            {
                if (IsRemoved(drug))
                {
                    if (IsDatabaseChanged())
                    {
                        return "Препарат удален!";
                    }
                    return "Ошибка удаления в EF";
                }
                return "Ошибка удаления в entity framework.";
            }
            else return "Данный препарат не существует в БД.";
        }

        public bool IsExist(Drugs drug)
        {
            return ReturnDrugs(drug).Count() != 0;
        }

        public bool IsExist(Discount discount)
        {
            return ReturnDisocunt(discount).Count() != 0;
        }

        public bool IsExistNotation(Drugs drug)
        {
            return database.Medications.Where(m => m.Name.Equals(drug.Name)).Count() != 0;
        }

        private bool IsDatabaseChanged()
        {
            return database.SaveChanges() != 0;
        }

        public Drugs GetDrugClassObject(string DrugName, DateTime start, DateTime end, int count, int cost, string producerName)
        {
            Drugs drug = new Drugs();
            drug.DrugID = database.Drugs.Where( d => d.Name.Equals(DrugName)).Count() != 0 ? database.Drugs.Where(d => d.Name.Equals(DrugName)).First().DrugID : 0;
            drug.Name = DrugName;
            drug.ManufactureDate = start;
            drug.ProducerId = database.Producers.Where(m => m.FirmName.Equals(producerName)).First().ProducerID;
            drug.Cost = cost;
            drug.DisposeDate = end;
            drug.Count = count;
            return drug;
        }

        public Discount GetDiscountClassObject(Drugs drug,int discount)
        {
            Discount dis = new Discount();
            dis.DrugId  = drug.DrugID;
            dis.Discount1 = discount;
            return dis;
        }

        private IQueryable<Drugs> ReturnDrugs(Drugs a)
        {
            return database.Drugs.Where(an => an.Name.Equals(a.Name) &&
                                                an.Cost == a.Cost &&
                                                an.ProducerId == a.ProducerId);
        }

        private IQueryable<Discount> ReturnDisocunt(Discount d)
        {
            return database.Discount.Where(s => s.DrugId.Equals(d.DrugId));
        }

        private bool IsRemoved(Drugs drug)
        {
            return database.Drugs.Remove(ReturnDrugs(drug).First()) != null;
        }
    }
}
