using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFrameworkApp.Assessment
{
    class Disease
    {
        public string DiseaseName { get; set; }
        public string Severity { get; set; }
        public string Cause { get; set; }
        public string Description { get; set; }
    }
    class Symptoms
    {
        public string DiseaseName { get; set; }
        public string SymptomName { get; set; }
        public string Description { get; set; }
    }
    class Patient
    {
        public string PatientName { get; set; }
        public string SymptomName { get; set; }
    }
}
