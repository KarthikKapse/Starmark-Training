using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using Utility;
namespace SampleFrameworkApp.Assessment
{
    enum Cause { ExternalFactor, internaldisorder }
    class MainUI
    {
       static Disease disease = new Disease();
        static Symptoms symptoms = new Symptoms();
        static IDiseaseComponent idc = new PatientDataBase();
        static string content = "-------------------Wel-Come To The Medical Application-------------------\nFor Add Disease Details Press 1\nFor Add Symptom to Disease Press 2\nFor Check Patient Press 3";
        public static void Run()
        {

            bool processing = true;
            do
            {
                var option = Utilities.GetNumber(content);
                processing = processMenu(option);
            } while (processing);
            Console.WriteLine("Thanks for Using our Application!!!");
        }
        private static bool processMenu(int option)
        {
            
            switch (option)
            {
                case 1:
                    
                    Console.WriteLine("Enter The Disease");
                    disease.DiseaseName= Console.ReadLine();
                    Console.WriteLine("Enter The Severity");
                    disease.Severity= Console.ReadLine();
                    
                    Console.WriteLine("Enter The Description");
                    disease.Description= Console.ReadLine();
                    idc.AddDiseaseDetails(disease);                   
                    break;
                case 2:
                    Console.WriteLine("Enter The Symptom");
                    symptoms.SymptomName= Console.ReadLine();
                    string diseaseName = disease.DiseaseName;
                    symptoms.DiseaseName = diseaseName;
                    Console.WriteLine(diseaseName);
                    Console.WriteLine("Enter The Description");
                    symptoms.Description = Console.ReadLine();
                    idc.AddSymptomtoDisease(symptoms);

                    break;
                case 3:
                    Console.WriteLine("Enter The Patient Name");
                    break;
                default:
                    return false;
            }
            return true;
        }



        static void Main(string[] args)
        {

            Run();
            
        }
    }
}
