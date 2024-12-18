using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class CommercialEngineTest : IEngineTest
    {
        public Guid TestId { get; private set; }

        public DateTime TestDate { get; private set; }


        private readonly List<string> _testResult;

        public CommercialEngineTest()
        {
            TestId = Guid.NewGuid();
            TestDate = DateTime.Now;
            _testResult = new List<string>();
        }
        public void RunTest()
        {
            Console.WriteLine("Ticari uçak motoru testleri başladı!");
            _testResult.Add($"Motor testi, {DateTime.UtcNow} anında tamamlandı");
        }

        public TestReport GenerateReport()
        {
            return new TestReport
            {
                TestId = TestId,
                TestDate = TestDate,
                EngineType = "Commercial",
                TestPassed = true,
                TestResult = _testResult,
                CertificationNumber = "123456"
            };
        }
    }


    public class MilitaryEngineTest : IEngineTest
    {
        public Guid TestId { get; private set; }

        public DateTime TestDate { get; private set; }

        private readonly List<string> _testResult;

        public TestReport GenerateReport()
        {
            
            return new TestReport {
                TestId = TestId,
                TestDate = TestDate,
                EngineType = "Military",
                TestPassed = true,
                TestResult = _testResult,
                CertificationNumber = "665656564"
            };
        }

        public MilitaryEngineTest()
        {
            TestId = Guid.NewGuid();
            TestDate = DateTime.Now;

            _testResult = new List<string>();

        }

        public void RunTest()
        {
            Console.WriteLine("Askeri uçak motoru testleri başladı!");
            _testResult.Add($"Motor testi, {DateTime.UtcNow} anında tamamlandı");
        }


    }

    public class DroneEngineTest : IEngineTest
    {
        public Guid TestId { get; private set; }

        public DateTime TestDate { get; private set; }

        private readonly List<string> _testResult;

        public DroneEngineTest()
        {
            TestId = Guid.NewGuid();
            TestDate = DateTime.Now;
            _testResult = new List<string>();
        }

        public TestReport GenerateReport()
        {
           return new TestReport
           {
               TestId = TestId,
               TestDate = TestDate,
               EngineType = "Drone",
               TestPassed = true,
               TestResult = _testResult,
               CertificationNumber = "123456"
           };
        }

        public void RunTest()
        {
            Console.WriteLine("Drone test çalıştırılıyor");
            _testResult.Add($"Dron motor testi, {DateTime.UtcNow} anında tamamlandı");
        }
    }

    public class CivilEngineTest : IEngineTest
    {
        public Guid TestId { get; private set; }

        public DateTime TestDate { get; private set; }
        private readonly List<string> _testResult;

        public CivilEngineTest()
        {
            
            TestId = Guid.NewGuid();
            TestDate = DateTime.Now;
            _testResult = new List<string>();

        }
        public TestReport GenerateReport()
        {
            return new TestReport
            {
                TestId = TestId,
                TestDate = TestDate,
                EngineType = "Civil",
                TestPassed = true,
                TestResult = _testResult,
                CertificationNumber = "123456"
            };
        }

        public void RunTest()
        {
            Console.WriteLine("Civil engine test çalışıyor....");
            _testResult.Add($"Civil motor testi, {DateTime.UtcNow} anında tamamlandı");
        }
    }
}
