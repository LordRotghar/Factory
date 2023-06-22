using Factory.Models;

namespace Factory.Factories
{
    public interface ICheckingDetailFactory
    {
        //Abstract SmallWeldingBolts
        ICheckingDetail CreateSmallWeldingBolts();
        //Abstract BigWeldingBolts
        ICheckingDetail CreateBigWeldingBolts();
    }
}
