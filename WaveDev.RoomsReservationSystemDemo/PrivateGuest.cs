namespace RoomsReservationSystem
{
    internal class PrivateGuest : Guest
    {
        public PrivateGuest(int id, string firstName, string lastName, CreditCard creditCard) 
            : base(id, firstName, lastName)
        {
            CreditCard = creditCard;
        }

        public CreditCard CreditCard { get; }
    }

}
