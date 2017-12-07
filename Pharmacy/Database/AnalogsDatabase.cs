using Pharmacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyCourseProject.Database
{
    public class AnalogsDatabase
    {
       
        PharmacyCourseProjectEntities database;

        public AnalogsDatabase(PharmacyCourseProjectEntities Database)
        {
            database = Database;
        }

        public string Add(Analogs analog)
        {
            if (!IsExist(analog))
            {
                if (database.Medications.Where(a => a.Name.Equals( analog.DrugName   )).First().PharmacologicalGroup.Equals
                   (database.Medications.Where(a => a.Name.Equals( analog.AnalogName )).First().PharmacologicalGroup))
                {
                    database.Analogs.Add(analog);
                    if (IsDatabaseChanged())
                    {
                        return "Аналог добавлен!";
                    }
                    return "Ошибка добавления в EF";
                }
                else
                    return "Фармакологические группы препаратов должны совпадать";
            }
            else return "Данный аналог уже занесен в БД.";
        }
       
        public string Remove(Analogs analog)
        {
            if (IsExist(analog))
            {
                if (IsRemoved(analog))
                {
                    if (IsDatabaseChanged())
                    {
                        return "Аналог удален!";
                    }
                    return "Ошибка удаления в EF";
                }
                return "Ошибка удаления в entity framework.";
            }
            else return "Данный аналог не существует в БД.";
        }
        public bool IsExist(Analogs analog)
        {
            return ReturnAnalogs(analog).Count() != 0;
        }

        private bool IsDatabaseChanged()
        {
            return database.SaveChanges() != 0;
        }

        public Analogs GetAnalogClassObject(string DrugName, string AnalogName)
        {
            Analogs analog = new Analogs();
            analog.DrugName = DrugName;
            analog.AnalogName = AnalogName;
            return analog;
        }

        private IQueryable<Analogs> ReturnAnalogs(Analogs a)
        {
            return database.Analogs.Where(an => an.AnalogName.Equals(a.AnalogName) &&
                                                an.DrugName.Equals(a.DrugName));
        }

        private bool IsRemoved(Analogs analog)
        {
            return database.Analogs.Remove(ReturnAnalogs(analog).First()) != null;
        }
    }
}
