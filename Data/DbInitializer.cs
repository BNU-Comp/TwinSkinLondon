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
            InitializeProduct(context);
            InitializeOrder(context);
            InitializeOrderItem(context);
            
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
            if (context.Product.Any())
            {
                return;
            }

            var Products = new Product[]
            {
               new Product
               {
                   //ProductID = 1,
                   Name = "TwinSkin London Cleanser",
                   Description = "A Cleanser is the first stage of any skincare routine, essential for removing make-up, dead skin cells, oil, dirt and other pollutants from the skin.This helps to prevent skin blemishes such as acne breaking out." +
                   "TwinSkin London’s Retinol and Collagen Cleanser is formulated to not only remove all of these impurities without making your skin dry but will get to work nourishing your skin with a tonne of anti - ageing ingredients helping to reverse the signs of ageing and leave your skin looking fantastic." +
                   "TwinSkin London’s Cleanser combines Retinol and Collagen and is packed with antioxidants reducing fine lines, wrinkles, crow’s feet and dark circles, giving your skin a natural, radiant glow, flawless complexion and an uplifting effect.",
                   Category = Categories.Facial,
                   ImageURL = "",
                   ProductPrice = 25,
                   VideoURL ="",
                   Quantity = 20,

               },
               new Product
               {
                   //ProductID = 2,
                   Name = "TwinSkin London Moisturiser",
                   Description = "A Moisturiser contains additional occlusive, moisturising ingredients to that of a Serum which when used daily prevents both dry and oily skin, the main causes of skin acne and other blemishes. " +
                   "TwinSkin London’s anti-ageing Moisturiser acts as a shield between your skin and the environment ensuring that all the anti-ageing goodies you nourish your skin with will be sealed for maximum results. This makes it perfect for applying once you have cleansed your skin and your serum has fully absorbed." +
                   "TwinSkin London’s Moisturiser combines Retinol and Collagen and is packed with antioxidants reducing fine lines, wrinkles, crow’s feet and dark circles, giving your skin a natural, radiant glow, flawless complexion and an uplifting effect.",
                   Category = Categories.Facial,
                   ImageURL = "",
                   ProductPrice = 30,
                   VideoURL ="",
                   Quantity = 20,

               },
               new Product
               {
                   //ProductID = 3,
                   Name = "TwinSkin London Serum",
                   Description = "A Serum does not contain certain moisturising ingredients allowing the texture to be substantially thinner with much smaller molecules than that of a moisturiser. This allows the Serum to be absorbed into the skin much faster and deliver active anti-ageing ingredients deeper into your skin. " +
                   "It is formulated to specifically target reversing the signs of ageing with no compromise, providing your skin with optimal anti-ageing benefits. For maximum results apply your serum after cleansing and always seal your serum into the skin with your moisturiser." +
                   "TwinSkin London’s Serum combines Retinol and Collagen and is packed with antioxidants reducing fine lines, wrinkles, crow’s feet and dark circles, giving your skin a natural, radiant glow, flawless complexion and an uplifting effect.",
                   Category = Categories.Facial,
                   ImageURL = "",
                   ProductPrice = 20,
                   VideoURL ="",
                   Quantity = 20,

               },
               new Product
               {
                   //ProductID = 4,
                   Name = "TwinSkin London Skin Care Bundle",
                   Description = "TwinSkin London’s Retinol and Collagen Bundle gives you the ultimate skincare routine for both preventing and reversing any signs of ageing.  Nourish your skin with Retinol, Collagen and tonnes of antioxidants while leaving your skin hydrated, blemish free and your complexion flawless." +
                   "TwinSkin London’s Cleanser, Serum and Moisturiser combine Retinol and Collagen and are packed with antioxidants reducing fine lines, wrinkles, crow’s feet and dark circles, giving your skin a natural, radiant glow, flawless complexion and an uplifting effect.",
                   Category = Categories.Facial,
                   ImageURL = "",
                   ProductPrice = 60,
                   VideoURL ="",
                   Quantity = 20,

               },
               new Product
               {
                   //ProductID = 5,
                   Name = "TwinSkin London Massage Wand",
                   Description = "",
                   Category = Categories.Accessories,
                   ImageURL = "dfjhsfsf",
                   ProductPrice = 10,
                   VideoURL ="gdwisd",
                   Quantity = 20,

               },
               new Product
               {
                   //ProductID = 6,
                   Name = "Twin Skin London Carry Bag",
                   Description = "",
                   Category = Categories.Accessories,
                   ImageURL = "",
                   ProductPrice = 15,
                   VideoURL ="",
                   Quantity = 20,

               },
               new Product
               {
                   //ProductID = 7,
                   Name = "Night Gel",
                   Description = "dffseb",
                   Category = Categories.Facial,
                   ImageURL = "dfjhsfsf",
                   ProductPrice = 10,
                   VideoURL ="gdwisd",
                   Quantity = 5,

               },
               new Product
               {
                   //ProductID = 8,
                   Name = "Night Gel",
                   Description = "dffseb",
                   Category = Categories.Facial,
                   ImageURL = "dfjhsfsf",
                   ProductPrice = 10,
                   VideoURL ="gdwisd",
                   Quantity = 5,

               },
               new Product
               {
                   //ProductID = 9,
                   Name = "Night Gel",
                   Description = "dffseb",
                   Category = Categories.Facial,
                   ImageURL = "dfjhsfsf",
                   ProductPrice = 10,
                   VideoURL ="gdwisd",
                   Quantity = 5,

               },
               new Product
               {
                   //ProductID = 10,
                   Name = "Night Gel",
                   Description = "dffseb",
                   Category = Categories.Facial,
                   ImageURL = "dfjhsfsf",
                   ProductPrice = 10,
                   VideoURL ="gdwisd",
                   Quantity = 5,

               }


            };

            foreach (Product c in Products)
            {
                context.Product.Add(c);
            }

            context.SaveChanges();
        }

        private static void InitializeOrderItem(ApplicationDbContext context)
        {
            if (context.OrderItem.Any())
            {
                return;
            }

            var OrderItems = new OrderItem[]
            {
               new OrderItem
               {
                   //OrderItemID = 1,
                  OrderID = 1004,
                  ProductID = 1002,
                  Price = 20,
                  Quantity = 2,

                },
               new OrderItem
               {
                   //OrderItemID = 2,
                  OrderID = 1005,
                  ProductID = 1003,
                  Price = 25,
                  Quantity = 1,

                },
               new OrderItem
               {
                   //OrderItemID = 3,
                  OrderID = 1006,
                  ProductID = 1004,
                  Price = 20,
                  Quantity = 2,

                },
               new OrderItem
               {
                   //OrderItemID = 4,
                  OrderID = 1007,
                  ProductID = 1005,
                  Price = 20,
                  Quantity = 2,

                },
               new OrderItem
               {
                   //OrderItemID = 5,
                  OrderID = 1008,
                  ProductID = 1006,
                  Price = 20,
                  Quantity = 2,

                },
               new OrderItem
               {
                   //OrderItemID = 6,
                  OrderID = 1009,
                  ProductID = 1007,
                  Price = 20,
                  Quantity = 2,

                },
               new OrderItem
               {
                   //OrderItemID = 7,
                  OrderID = 1009,
                  ProductID = 1008,
                  Price = 20,
                  Quantity = 2,

                },
               new OrderItem
               {
                   //OrderItemID = 8,
                  OrderID = 1010,
                  ProductID = 1009,
                  Price = 20,
                  Quantity = 2,

                },
               new OrderItem
               {
                   //OrderItemID = 9,
                  OrderID = 1011,
                  ProductID = 1010,
                  Price = 20,
                  Quantity = 2,

                },
               new OrderItem
               {
                   //OrderItemID = 10,
                  OrderID = 1012,
                  ProductID = 1010,
                  Price = 20,
                  Quantity = 2,

                },

            };
               foreach (OrderItem c in OrderItems)
            {
                context.OrderItem.Add(c);
            }

            context.SaveChanges();

        }

        private static void InitializeOrder(ApplicationDbContext context)
        {

            if (context.Order.Any())
            {
                return;
            }

            var Orders = new Order[]
            {
               new Order
               {
                   //OrderID = 1,
                  DateOrdered = new DateTime(2020, 5, 1, 8, 30, 52),
                  DateDelivered = new DateTime(2020, 5, 5, 12, 30, 21),
                  Status = "Delivered",
                  VAT = 20,
                  DeliveryCharge = 20,
                  CustomerID = 1,

                },
               new Order
               {
                   //OrderID = 2,
                  DateOrdered = new DateTime(2020, 5, 1, 8, 30, 52),
                  DateDelivered = new DateTime(2020, 5, 5, 12, 30, 21),
                  Status = "Delivered",
                  VAT = 20,
                  DeliveryCharge = 20,
                  CustomerID = 2,

                },
               new Order
               {
                   //OrderID = 3,
                  DateOrdered = new DateTime(2020, 5, 1, 8, 30, 52),
                  DateDelivered = new DateTime(2020, 5, 5, 12, 30, 21),
                  Status = "Delivered",
                  VAT = 20,
                  DeliveryCharge = 20,
                  CustomerID = 3,

                },
               new Order
               {
                   //OrderID = 4,
                  DateOrdered = new DateTime(2020, 5, 1, 8, 30, 52),
                  DateDelivered = new DateTime(2020, 5, 5, 12, 30, 21),
                  Status = "Delivered",
                  VAT = 20,
                  DeliveryCharge = 20,
                  CustomerID = 4,

                },
               new Order
               {
                   //OrderID = 4,
                  DateOrdered = new DateTime(2020, 5, 1, 8, 30, 52),
                  DateDelivered = new DateTime(2020, 5, 5, 12, 30, 21),
                  Status = "Delivered",
                  VAT = 20,
                  DeliveryCharge = 20,
                  CustomerID = 4,

                },
               new Order
               {
                   //OrderID = 5,
                  DateOrdered = new DateTime(2020, 5, 1, 8, 30, 52),
                  DateDelivered = new DateTime(2020, 5, 5, 12, 30, 21),
                  Status = "Delivered",
                  VAT = 20,
                  DeliveryCharge = 20,
                  CustomerID = 5,

                },
               new Order
               {
                   //OrderID = 6,
                  DateOrdered = new DateTime(2020, 5, 1, 8, 30, 52),
                  DateDelivered = new DateTime(2020, 5, 5, 12, 30, 21),
                  Status = "Delivered",
                  VAT = 20,
                  DeliveryCharge = 20,
                  CustomerID = 6,

                },
               new Order
               {
                   //OrderID = 7,
                  DateOrdered = new DateTime(2020, 5, 1, 8, 30, 52),
                  DateDelivered = new DateTime(2020, 5, 5, 12, 30, 21),
                  Status = "Delivered",
                  VAT = 20,
                  DeliveryCharge = 20,
                  CustomerID = 7,

                },
               new Order
               {
                   //OrderID = 8,
                  DateOrdered = new DateTime(2020, 5, 1, 8, 30, 52),
                  DateDelivered = new DateTime(2020, 5, 5, 12, 30, 21),
                  Status = "Delivered",
                  VAT = 20,
                  DeliveryCharge = 20,
                  CustomerID = 8,

                },
               new Order
               {
                   //OrderID = 9,
                  DateOrdered = new DateTime(2020, 5, 1, 8, 30, 52),
                  DateDelivered = new DateTime(2020, 5, 5, 12, 30, 21),
                  Status = "Delivered",
                  VAT = 20,
                  DeliveryCharge = 20,
                  CustomerID = 9,

                },
               new Order
               {
                   //OrderID = 10,
                  DateOrdered = new DateTime(2020, 5, 1, 8, 30, 52),
                  DateDelivered = new DateTime(2020, 5, 5, 12, 30, 21),
                  Status = "Delivered",
                  VAT = 20,
                  DeliveryCharge = 20,
                  CustomerID = 10,

                },
            };
        

            foreach (Order c in Orders)
            {
                context.Order.Add(c);
            }

            context.SaveChanges();
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
