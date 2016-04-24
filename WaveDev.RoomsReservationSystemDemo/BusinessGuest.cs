using System.Collections.Generic;

namespace RoomsReservationSystem
{
    internal class BusinessGuest : Guest
    {
        public BusinessGuest(int id, string firstName, string lastName) 
            : base(id, firstName, lastName)
        {
            CreditCards = new List<CreditCard>();
        }

        public IList<CreditCard> CreditCards { get; }


    }
}
