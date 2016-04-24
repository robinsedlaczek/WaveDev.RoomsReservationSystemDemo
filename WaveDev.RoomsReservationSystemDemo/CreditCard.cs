using System;

namespace RoomsReservationSystem
{
    internal class CreditCard : ISensitiveObject
    {
        public int Id
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string Number { get; set; }

        public DateTime ValidUntil { get; set; }

        public int VerificationNumber { get; set; }
    }
}