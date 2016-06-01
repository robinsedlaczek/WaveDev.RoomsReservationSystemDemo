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

            var guest = new PrivateGuest(1, "Max", "Muster", creditCard);
            
            //if (guest is Guest("1", "Max", *))
            //{
            //    var newGuest = guest with { FirstName = "Paul" };
            //}

            Console.WriteLine(guest.FirstName);
            Console.WriteLine(guest.CreditCard.Number);

        }

        private ISensitiveObject CreatePrivateGuest()
        {
            var creditCard = CreateCreditCard();
            return new PrivateGuest(3, "Robin", "Sedlaczek", creditCard);
        }

        private CreditCard CreateCreditCard()
        {
            var creditCard = new CreditCard
            {
                Id = 1,
                Number = "560580100",
                ValidUntil = DateTime.Today.AddYears(1),
                VerificationNumber = 111
            };

            return creditCard;
        }

        private Guest CreateBusinessGuest()
        {
            return new BusinessGuest(2, "Siemens", string.Empty);
        }

        private Guest CreateBusinessGuestWithCreditCard()
        {
            var guest = new BusinessGuest(2, "Siemens", string.Empty);

            var creditCard = CreateCreditCard();
            guest.CreditCards.Add(creditCard);

            return guest;
        }


    }
}
