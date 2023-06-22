using Factory.Models;

namespace Factory.Factories
{
    public class CheckingDetailFactoryEn : ICheckingDetailFactory
    {
        public ICheckingDetail CreateSmallWeldingBolts()
        {
            return new SmallWeldingBoltsEn();
        }
        public ICheckingDetail CreateBigWeldingBolts()
        {
            return new BigWeldingBoltsEn();
        }
    }
}
