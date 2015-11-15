using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutationTalk
{
    public class GiftAidCalculator
    {
        private int TaxRate { get; set; }

        //DonationAmount * (TaxRate / 100 - TaxRate)
        public decimal CalculateGiftAid(int donationAmount)
        {
            decimal result;
            if (donationAmount > 1000)
            {
                TaxRate = 50;
                result = (decimal)(donationAmount * (TaxRate / (100D - TaxRate)));
            }
            else
            {
                TaxRate = 20;
                result = (decimal)(donationAmount * (TaxRate / (100D - TaxRate)));
            }
            return result;
        }
    }
}
