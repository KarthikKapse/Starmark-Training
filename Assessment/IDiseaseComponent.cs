using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleFrameworkApp.Assessment;

namespace DataLayer 
{
    interface IDiseaseComponent
    {
        void AddDiseaseDetails(Disease disease);
        void AddSymptomtoDisease(Symptoms symptoms);
        void CheckPatient(string name);
    }
    class PatientDataBase : IDiseaseComponent
    {
        private ArrayList _arrayList = new ArrayList();
        public void AddDiseaseDetails(Disease disease)
        {
            _arrayList.Add(disease);
            Console.WriteLine(disease.DiseaseName +"\n"+ disease.Severity+"\n"+disease.Description +"\n"+disease.Cause );
           // throw new NotImplementedException();
        }

        public void AddSymptomtoDisease(Symptoms symptoms)
        {
            _arrayList.Add(symptoms);
            Console.WriteLine(symptoms.DiseaseName + "\n" + symptoms.SymptomName + "\n" + symptoms.Description);
            // throw new NotImplementedException();
        }

        public void CheckPatient(string name)
        {
            throw new NotImplementedException();
        }
    }
}


