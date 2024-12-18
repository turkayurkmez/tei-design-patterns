using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public interface IEngineTest
    {
        Guid TestId { get; }
        DateTime TestDate { get; }

        void RunTest();

        TestReport GenerateReport();

    }

    public class  TestReport 
    {
        public Guid TestId { get; set; }
        public DateTime TestDate { get; set; }
        public string EngineType { get; set; }
        public bool TestPassed { get; set; }
        public List<string> TestResult { get; set; }
        public string CertificationNumber { get; set; }


    }
}
