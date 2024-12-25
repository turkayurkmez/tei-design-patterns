using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    /*
     * Senaryo:
     *   Tüm avrupada hizmet veren bir seminer organizasyon şirketi ülke talebine göre doğru kaynakları kullanmak ister.
     *   
     *  
     *   
     */

    // 1. Zincirde, paslaşılan nesneyi tasarlayın
    public class ReservationRequest
    {
        public string Owner { get; set; }
        public DateOnly CheckIn { get; set; }
        public DateOnly CheckOut { get; set; }
        public int ParticipantsCount { get; set; }
        public string City { get; set; }
        public bool? HasOwner { get; set; }

    }
    //2. Zincirin her halkasının temel davranışını belirleyin:
    public interface IHandler
    {
        public IHandler Next { get; set; }
        public void Handler(ReservationRequest request);

    }

    //3. Her halka için bir base (abstract) class oluşturun [TAVSİYE]:
    public abstract class HandlerBase : IHandler
    {
        public IHandler Next { get; set; }

        protected HandlerBase()
        {

        }

        protected HandlerBase(IHandler handler)
        {
            Next = handler;
        }
        public abstract void Handler(ReservationRequest request);


    }

    //4. Spesifik halkarını tasarla:
    //  Örnek: Reservasyonun sahibi girilmiş denetlensin.
    public class CheckOwnerHandler : HandlerBase
    {
        public CheckOwnerHandler()
        {
        }

        public CheckOwnerHandler(IHandler handler) : base(handler)
        {
        }

        public override void Handler(ReservationRequest request)
        {
            if (string.IsNullOrEmpty(request.Owner))
            {
                throw new ArgumentException("Reservasyon kimin adına?");
            }
            request.HasOwner = true;
            Next.Handler(request);
        }


    }

    public class CheckInAndOutDate : HandlerBase
    {
        public CheckInAndOutDate(IHandler handler) : base(handler)
        {
        }

        public CheckInAndOutDate()
        {
            

        }

        public override void Handler(ReservationRequest request)
        {
            if (request.CheckIn > request.CheckOut)
            {
                throw new ArgumentException($"rezervasyon tarihleri yanlış!");
            }
            Next.Handler(request);
        }
    }

    public class SaveReservationToDatabaseHandler : HandlerBase
    {
        public SaveReservationToDatabaseHandler()
        {
        }

        public SaveReservationToDatabaseHandler(IHandler handler) : base(handler)
        {
        }

        public override void Handler(ReservationRequest request)
        {
            Console.WriteLine($"{request.Owner} tarafından {request.CheckIn.ToLongDateString()} tarihinde gelinecek şekilde rezervasyon tamamlandı");
        }
    }
}
