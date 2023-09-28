using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayableInterfaceTest
{
    public class PayableExcelSerializer : IPayableSerializer
    {
        public FileStream Fs { get; set; }
        public StreamWriter Sw { get; set; }    

        public PayableExcelSerializer()
        {
            Fs = new FileStream("test.xls", FileMode.Create);
            Sw = new StreamWriter(Fs);
        }
        public void Dispose()
        {
            if (Sw != null)
            {
                Sw.Close();
                Sw = null;
            }
            if (Fs != null)
            {
                Fs.Dispose();
                Fs = null;
            }
        }

        public void WritePayableObjects(List<IPayable> payableObjects)
        {
            foreach (var payable in payableObjects)
            {
                // output payable and its appropiate payment amount
                Sw.WriteLine($"{payable}");
                Sw.WriteLine(
                    $"payment due: {payable.GetPaymentAmount():C}\n");
            };
        }
    }
}
