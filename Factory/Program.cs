using Factory.Factories;
using Factory.Models;

namespace Factory
{
    class Program
    {
        public static void Main()
        {
            // En factory
            ICheckingDetailFactory checkingDetailFactoryEn = new CheckingDetailFactoryEn();
            ICheckingDetail smallWeldingBoltsEn = checkingDetailFactoryEn.CreateSmallWeldingBolts();
            smallWeldingBoltsEn.GetMessage();
            ICheckingDetail bigWeldingBoltsEn = checkingDetailFactoryEn.CreateBigWeldingBolts();
            bigWeldingBoltsEn.GetMessage();

            // Aisc factory
            ICheckingDetailFactory checkingDetailFactoryAisc = new CheckingDetailFactoryAisc();
            ICheckingDetail smallWeldingBoltsAisc = checkingDetailFactoryAisc.CreateSmallWeldingBolts();
            smallWeldingBoltsAisc.GetMessage();
            ICheckingDetail bigWeldingBoltsAisc = checkingDetailFactoryAisc.CreateBigWeldingBolts();
            bigWeldingBoltsAisc.GetMessage();

            Console.ReadKey();
        }
    }
}