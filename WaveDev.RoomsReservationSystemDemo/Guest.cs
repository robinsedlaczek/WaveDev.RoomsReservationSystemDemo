using System;

namespace RoomsReservationSystem
{
    internal class Guest : ISensitiveObject
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

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public CreditCard CreditCard { get; set; }
    }
}
