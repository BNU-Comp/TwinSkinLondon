using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwinSkinLondon.Models;

namespace TwinSkinLondon.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            InitializeAddress(context);
            InitializePaymentCard(context);
            InitializeCustomers(context);
          
            //InitializeProduct(context);
            
            //InitializeMessage(context);
            //InitializeOrder(context);
            //InitializeOrderItem(context);
            //InitializeReview(context);

        }


        private static void InitializeCustomers(ApplicationDbContext context)
        {
           if(context.Customers.Any())
            {
                return;
            }

            var Customers = new Customer[]
            {
               
                new Customer
               {
                   FirstName= "Rebecca",
                   AddressID= 1,
                   LastName= "Abbott",
                   ContactNumber= "07653217864",
                   EmailAddress= "Gunner_Wilkinson@demetris.com",
                   PaymentCardID = 1
                   //CustomerID= 1,
               },
                 new Customer
               {
                   FirstName= "Dawspm",
                   AddressID= 2,
                   LastName= "Elisha",
                   ContactNumber= "07653217863",
                   EmailAddress= "Eleazar@watson.tv",
                   PaymentCardID = 2
                   //CustomerID= 2,
               },
                  new Customer
               {
                   FirstName= "Elizer",
                   AddressID= 3,
                   LastName= "Favian",
                   ContactNumber= "07653217862",
                   EmailAddress= "Fleta@verla.net",
                   PaymentCardID = 3
                   //CustomerID= 3,
               },
                   new Customer
               {
                   FirstName= "Guillermo",
                   AddressID=4,
                   LastName= "Esmeralda",
                   ContactNumber= "07653217861",
                   EmailAddress= "Uriah.Hoeger@flo.net",
                   PaymentCardID = 4
                   //CustomerID= 4,
               },
                    new Customer
               {
                   FirstName= "Cielo",
                   AddressID=5,
                   LastName= "Runolfsdottir",
                   ContactNumber= "07653217860",
                   EmailAddress="Lavon@mckenna.name",
                   PaymentCardID = 5
                   //CustomerID= 5,
               },
                     new Customer
               {
                   FirstName= "Cierra",
                   AddressID= 6,
                   LastName= "Jeanie",
                   ContactNumber= "07653217866",
                   EmailAddress= "Jeanie@wilford.ca",
                   PaymentCardID = 6
                   //CustomerID= 6,
               },
                      new Customer
               {
                   FirstName= "Yessenia",
                   AddressID= 7,
                   LastName= "Meredith",
                   ContactNumber= "07653217867",
                   EmailAddress="Letha_Spinka@kamryn.io",
                   PaymentCardID = 7
                   //CustomerID= 7,
               },
                       new Customer
               {
                   FirstName= "Travon",
                   AddressID=8,
                   LastName= "Jones",
                   ContactNumber= "07653217868",
                   EmailAddress= "Amiya_Runte@billie.com",
                   PaymentCardID = 8
                   //CustomerID= 8,
               },
                        new Customer
               {
                   FirstName= "Lorena",
                   AddressID= 9,
                   LastName= "Kadin",
                   ContactNumber= "07653217869",
                   EmailAddress= "Reed@adriana.co.uk",
                   PaymentCardID = 9
                   //CustomerID= 9,
               },
               new Customer
               {
                   FirstName= "Alena",
                   AddressID= 10,
                   LastName= "Cole",
                   ContactNumber= "07653217865",
                   EmailAddress= "Kasey@markus.tv",
                   PaymentCardID = 10
                   //CustomerID= 10,
               },

            };

            foreach (Customer c in Customers)
            {
                context.Customers.Add(c);
            }

            context.SaveChanges();
        }

        private static void InitializeAddress(ApplicationDbContext context)
        {
            if (context.Addresses.Any())
            {
                return;
            }

            var Addresses = new Address[]
            {
               new Address
               {
                   //AddressID = 1,
                   HouseNumber = "7",
                   Street = "Park Lane",
                   County = Counties.Wiltshire,
                   Town = "Chippenham",
                   Postcode = "CH12 RR5",
               },
               new Address
               {
                   //AddressID = 2,
                   HouseNumber = "30A",
                   Street = "Powlmore Avenue",
                   County = Counties.Shropshire,
                   Town = "Slough",
                   Postcode = "SL10 E33",
               },
               new Address
               {
                   //AddressID = 3,
                   HouseNumber = "Lord's Manor",
                   Street = "Mayfair",
                   County = Counties.CityofLondon,
                   Town = "Westminster",
                   Postcode = "W1G 8AJ",
               },
               new Address
               {
                   //AddressID = 4,
                   HouseNumber = "43",
                   Street = "Old Kent Road",
                   County = Counties.CityofLondon,
                   Town = "Southwark",
                   Postcode = "SE12 AW3",
               },
               new Address
               {
                   //AddressID = 5,
                   HouseNumber = "103B",
                   Street = "Raven's Court",
                   County = Counties.Cornwall,
                   Town = "Greenshire",
                   Postcode = "CO5 B4C",
               },
               new Address
               {
                   //AddressID = 6,
                   HouseNumber = "9",
                   Street = "Blenheim Close",
                   County = Counties.Kent,
                   Town = "Blenheim",
                   Postcode = "DA13 0PQ",
               },
               new Address
               {
                   //AddressID = 7,
                   HouseNumber = "221b",
                   Street = "Baker Street",
                   County = Counties.GreaterLondon,
                   Town = "Westminster",
                   Postcode = "NW1 6XE",
               },
               new Address
               {
                   //AddressID = 8,
                   HouseNumber = "45",
                   Street = "Spooner Street",
                   County = Counties.Derbyshire,
                   Town = "Maidstone",
                   Postcode = "DE3 B55",
               },
               new Address
               {
                   //AddressID = 9,
                   HouseNumber = "15",
                   Street = "Sesame Street",
                   County = Counties.NorthYorkshire,
                   Town = "Leeds",
                   Postcode = "LE10 AE2",
               },
               new Address
               {
                   //AddressID = 10,
                   HouseNumber = "10",
                   Street = "Bond Street",
                   County = Counties.Kent,
                   Town = "Gravesend",
                   Postcode = "KE10 1EW",
               },

            };

            foreach (Address c in Addresses)
            {
                context.Addresses.Add(c);
            }

            context.SaveChanges();
        }

        private static void InitializeProduct(ApplicationDbContext context)
        {

        }

        private static void InitializeOrderItem(ApplicationDbContext context)
        {

        }

        private static void InitializeOrder(ApplicationDbContext context)
        {

        }

        private static void InitializeMessage(ApplicationDbContext context)
        {
        }

        private static void InitializePaymentCard(ApplicationDbContext context)
        {

            if (context.PaymentCard.Any())
            {
                return;
            }

            var paymentCards = new PaymentCard[]
            {
                new PaymentCard
                {
                    CardName = "Rebecca",
                    CardNumber = "1234 5678 1234 5678",
                    CVV = 201,
                    ExpiryMonth = 11,
                    ExpiryYear = 2020,

                },
            new PaymentCard
            {
                CardName = "Dawspm",
                CardNumber = "5673 5788 1124 5698",
                CVV = 341,
                ExpiryMonth = 9,
                ExpiryYear = 2022,

            },
                new PaymentCard
                {
                    CardName = "Elizer",
                    CardNumber = "9265 5568 1244 6867",
                    CVV = 450,
                    ExpiryMonth = 2,
                    ExpiryYear = 2025,

                },
                new PaymentCard
                {
                    CardName = "Guillermo",
                    CardNumber = "7364 5128 9684 9067",
                    CVV = 309,
                    ExpiryMonth = 11,
                    ExpiryYear = 2020,

                },
                new PaymentCard
                {
                    CardName = "Cielo",
                    CardNumber = "4676 1289 9032 7902",
                    CVV = 102,
                    ExpiryMonth = 7,
                    ExpiryYear = 2028,

                },
                new PaymentCard
                {
                    CardName = "Cirra",
                    CardNumber = "8974 6788 1924 9088",
                    CVV = 567,
                    ExpiryMonth = 5,
                    ExpiryYear = 2027,

                },
                new PaymentCard
                {
                    CardName = "Yessenia",
                    CardNumber = "5634 6734 8934 7638",
                    CVV = 221,
                    ExpiryMonth = 1,
                    ExpiryYear = 2020,

                },
                new PaymentCard
                {
                    CardName = "Travon",
                    CardNumber = "6784 6736 6372 7997",
                    CVV = 999,
                    ExpiryMonth = 2,
                    ExpiryYear = 2030,

                },
                new PaymentCard
                {
                    CardName = "Lorena",
                    CardNumber = "5634 6778 7388 5908",
                    CVV = 666,
                    ExpiryMonth = 11,
                    ExpiryYear = 2020,

                },
                new PaymentCard
                {
                    CardName = "Alena",
                    CardNumber = "8934 2784 1234 7464",
                    CVV = 100,
                    ExpiryMonth = 8,
                    ExpiryYear = 2034,

                },

            };
            foreach (PaymentCard c in paymentCards)
            {
                context.PaymentCard.Add(c);
            }

            context.SaveChanges();

        }

        private static void InitializeReview(ApplicationDbContext context)
        {

        }
    }

}
