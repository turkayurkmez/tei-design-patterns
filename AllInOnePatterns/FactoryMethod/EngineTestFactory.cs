using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{

    /*
     * EngineTestFactory sınıfı,
     *   "commercial" engine test edebilir.
     *   "military" engine test edebilir.
     *   "drone" engine test edebilir.
     *   
     */
    public abstract class EngineTestFactory
    {
        //Testi çalıştırıp rapor döndüren metot
        public TestReport ExecuteEngineTest(string engineType)
        {
             IEngineTest engineTest = CreateEngineTest(engineType);
             engineTest.RunTest();
             return engineTest.GenerateReport();

        }


        protected abstract IEngineTest CreateEngineTest(string engineType);
    }


    public class AircraftEngineTestFactory : EngineTestFactory
    {
        protected override IEngineTest CreateEngineTest(string engineType)
        {
            return engineType.ToLowerInvariant() switch
            {

                "commercial" => new CommercialEngineTest(),
                "military" => new MilitaryEngineTest(),
                "drone" => new DroneEngineTest(),
                "civil" => new CivilEngineTest()
            };
        }
    }

}
