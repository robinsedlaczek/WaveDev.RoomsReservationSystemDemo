using System;

namespace RoomsReservationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var creditCard = new CreditCard
            {
                Id = 1,
                Number = "560580100",
                ValidUntil = DateTime.Today.AddYears(1),
                VerificationNumber = 111
            };

            var guest = new Guest
            {
                Id = 1,
                FirstName = "Max",
                LastName = "Muster",
                CreditCard = creditCard
            };

            Console.WriteLine(guest.FirstName);
            Console.WriteLine(guest.CreditCard.Number);

        }
    }
}
