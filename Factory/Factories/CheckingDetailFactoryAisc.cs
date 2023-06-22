using Factory.Models;

namespace Factory.Factories
{
    public class CheckingDetailFactoryAisc : ICheckingDetailFactory
    {
        public ICheckingDetail CreateSmallWeldingBolts()
        {
            return new SmallWeldingBoltsAisc();
        }
        public ICheckingDetail CreateBigWeldingBolts()
        {
            return new BigWeldingBoltsAisc();
        }
    }
}
