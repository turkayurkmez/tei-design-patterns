using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    //Senaryo: Bir müşterinin, bir sadakat kartı olacak.
    //Bu kart; standart (%5), silver(%10) ve gold (%15) olabilir.
    //Müşteri sadakat kartı ile alışveriş yaparken, kartına göre indirim uygulanacak.

    //public enum LoyaltyCard
    //{
    //    Standard,
    //    Silver,
    //    Gold,
    //    Premium
    //}

    public abstract class LoyaltyCard
    {
        public abstract decimal GetDiscount(decimal total);
       
    }
    //Gelişim:
    public class StandardCard : LoyaltyCard
    {
        public override decimal GetDiscount(decimal total)
        {
            return total * 0.95m;
        }
    }

    public class SilverCard : LoyaltyCard
    {
        public override decimal GetDiscount(decimal total)
        {
            return total * 0.90m;
        }
    }

    public class GoldCard : LoyaltyCard
    {
        public override decimal GetDiscount(decimal total)
        {
            return total * 0.85m;
        }
    }

    public class PremiumCard : LoyaltyCard
    {
        public override decimal GetDiscount(decimal total)
        {
            return total * 0.80m;
        }
    }


    public class Customer
    {
        public string Name { get; set; }
      
        public LoyaltyCard LoyaltyCard { get; set; }
    }
   
    public class OrderManagement
    {
        public Customer Customer { get; set; }

        public decimal ApplyDiscount(decimal totalAmount)
        {
            //switch (Customer.LoyaltyCard)
            //{
            //    case LoyaltyCard.Standard:
            //        return totalAmount * 0.95m;
            //    case LoyaltyCard.Silver:
            //        return totalAmount * 0.90m;
            //    case LoyaltyCard.Gold:
            //        return totalAmount * 0.85m;
            //    case LoyaltyCard.Premium:
            //        return totalAmount * 0.80m;
            //    default:
            //        return totalAmount;
            //}

            //değiştirme:
          return Customer.LoyaltyCard.GetDiscount(totalAmount);


        }
    }
}
