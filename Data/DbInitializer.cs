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
            InitializeMessage(context);
            InitializeReview(context);

        }


        private static void InitializeCustomers(ApplicationDbContext context)
        {
            if (context.Customers.Any())
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
                   PaymentCardID = 1,
                   //CustomerID= 1,
               },
                 new Customer
               {
                   FirstName= "Dawspm",
                   AddressID= 2,
                   LastName= "Elisha",
                   ContactNumber= "07653217863",
                   EmailAddress= "Eleazar@watson.tv",
                   PaymentCardID = 2,
                   //CustomerID= 2,
               },
                  new Customer
               {
                   FirstName= "Elizer",
                   AddressID= 3,
                   LastName= "Favian",
                   ContactNumber= "07653217862",
                   EmailAddress= "Fleta@verla.net",
                   PaymentCardID = 3,
                   //CustomerID= 3,
               },
                   new Customer
               {
                   FirstName= "Guillermo",
                   AddressID=4,
                   LastName= "Esmeralda",
                   ContactNumber= "07653217861",
                   EmailAddress= "Uriah.Hoeger@flo.net",
                   PaymentCardID = 4,
                   //CustomerID= 4,
               },
                    new Customer
               {
                   FirstName= "Cielo",
                   AddressID=5,
                   LastName= "Runolfsdottir",
                   ContactNumber= "07653217860",
                   EmailAddress="Lavon@mckenna.name",
                   PaymentCardID = 5,
                   //CustomerID= 5,
               },
                     new Customer
               {
                   FirstName= "Cierra",
                   AddressID= 6,
                   LastName= "Jeanie",
                   ContactNumber= "07653217866",
                   EmailAddress= "Jeanie@wilford.ca",
                   PaymentCardID = 6,
                   //CustomerID= 6,
               },
                      new Customer
               {
                   FirstName= "Yessenia",
                   AddressID= 7,
                   LastName= "Meredith",
                   ContactNumber= "07653217867",
                   EmailAddress="Letha_Spinka@kamryn.io",
                   PaymentCardID = 7,
                   //CustomerID= 7,
               },
                       new Customer
               {
                   FirstName= "Travon",
                   AddressID=8,
                   LastName= "Jones",
                   ContactNumber= "07653217868",
                   EmailAddress= "Amiya_Runte@billie.com",
                   PaymentCardID = 8,
                   //CustomerID= 8,
               },
                        new Customer
               {
                   FirstName= "Lorena",
                   AddressID= 9,
                   LastName= "Kadin",
                   ContactNumber= "07653217869",
                   EmailAddress= "Reed@adriana.co.uk",
                   PaymentCardID = 9,
                   //CustomerID= 9,
               },
               new Customer
               {
                   FirstName= "Alena",
                   AddressID= 10,
                   LastName= "Cole",
                   ContactNumber= "07653217865",
                   EmailAddress= "Kasey@markus.tv",
                   PaymentCardID = 10,
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
                  // AddressID = 4,
                   HouseNumber = "43",
                   Street = "Old Kent Road",
                   County = Counties.CityofLondon,
                   Town = "Southwark",
                   Postcode = "SE12 AW3",
               },
               new Address
               {
                  // AddressID = 5,
                   HouseNumber = "103B",
                   Street = "Raven's Court",
                   County = Counties.Cornwall,
                   Town = "Greenshire",
                   Postcode = "CO5 B4C",
               },
               new Address
               {
                  // AddressID = 6,
                   HouseNumber = "9",
                   Street = "Blenheim Close",
                   County = Counties.Kent,
                   Town = "Blenheim",
                   Postcode = "DA13 0PQ",
               },
               new Address
               {
                  // AddressID = 7,
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
                   ImageURL = "Website Cleanser Bottle.jpg",
                   ProductPrice = 25,
                   VideoURL ="TwinSkin Video.mov",
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
                   ImageURL = "Website Moisturiser Bottle.jpg",
                   ProductPrice = 30,
                   VideoURL ="TwinSkin Video.mov",
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
                   ImageURL = "Website Serum Bottle.jpg",
                   ProductPrice = 20,
                   VideoURL ="TwinSkin Video.mov",
                   Quantity = 20,

               },
               new Product
               {
                   //ProductID = 4,
                   Name = "TwinSkin London Skin Care Bundle",
                   Description = "TwinSkin London’s Retinol and Collagen Bundle gives you the ultimate skincare routine for both preventing and reversing any signs of ageing.  Nourish your skin with Retinol, Collagen and tonnes of antioxidants while leaving your skin hydrated, blemish free and your complexion flawless." +
                   "TwinSkin London’s Cleanser, Serum and Moisturiser combine Retinol and Collagen and are packed with antioxidants reducing fine lines, wrinkles, crow’s feet and dark circles, giving your skin a natural, radiant glow, flawless complexion and an uplifting effect.",
                   Category = Categories.Facial,
                   ImageURL = "Triple Pack - SAVE.jpg",
                   ProductPrice = 60,
                   VideoURL ="TwinSkin Video.mov",
                   Quantity = 20,

               },
               new Product
               {
                   //ProductID = 5,
                   Name = "TwinSkin London Eye Massage Wand",
                   Description = "The eye beauty instrument enables nutrients to penetrate deep into the skin for better absorption." +
                   "Intelligent sensor design: no manual switch, touch the product sensor area, the energy massage head contact with the skin, instant induction to start using.",
                   Category = Categories.Accessories,
                   ImageURL = "Eye Wand.jpg",
                   ProductPrice = 15,
                   VideoURL ="TwinSkin Video.mov",
                   Quantity = 20,

               },
               new Product
               {
                   //ProductID = 6,
                   Name = "TwinSkin London Carry Bag",
                   Description = "TwinSkin London's washbag has a zip top that keeps items safe and secure. The washbag has a waterproof lining and is a perfect size to store and transport all your essential toiletries. A simple white design.",
                   Category = Categories.Accessories,
                   ImageURL = "Wash Bag.jpg",
                   ProductPrice = 15,
                   VideoURL ="TwinSkin Video.mov",
                   Quantity = 20,

               },
               new Product
               {
                   //ProductID = 7,
                   Name = "TwinSkin London Serum & Cleanser Kit",
                   Description = "TwinSkin London’s Retinol and Collagen Bundle gives you the ultimate skincare routine for both preventing and reversing any signs of ageing.  Nourish your skin with Retinol, Collagen and tonnes of antioxidants while leaving your skin hydrated, blemish free and your complexion flawless. TwinSkin London’s Cleanser and Serum combine Retinol and Collagen and are packed with antioxidants reducing fine lines, wrinkles, crow’s feet and dark circles, giving your skin a natural, radiant glow, flawless complexion and an uplifting effect.",
                   Category = Categories.Facial,
                   ImageURL = "Cleanser and serum Bundle.jpg",
                   ProductPrice = 40,
                   VideoURL ="TwinSkin Video.mov",
                   Quantity = 5,

               },
               new Product
               {
                   //ProductID = 8,
                   Name = "TwinSkin London Accessory Kit",
                   Description = "All your skin care accesory needs in one complete bundle",
                   Category = Categories.Accessories,
                   ImageURL = "Accessory Bundle.jpg",
                   ProductPrice = 25,
                   VideoURL ="TwinSkin Video.mov",
                   Quantity = 20,

               },
               new Product
               {
                   //ProductID = 9,
                   Name = "TwinSKin London Skin Care Package",
                   Description = "Combine all of TwinSkin Londons Product in our complete package. Containing something for all your skin care needs, the perfect applicaticator and a need and stylish bag to carry all your skin care products in.",
                   Category = Categories.Facial,
                   ImageURL = "Complete Budle.jpg",
                   ProductPrice = 90,
                   VideoURL ="TwinSkin Video.mov",
                   Quantity = 20,

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
                  // OrderItemID = 1,
                  OrderID = 11,
                  ProductID = 1,
                  Price = 25,
                  Quantity = 2,

                },
               new OrderItem
               {
                  // OrderItemID = 2,
                  OrderID = 2,
                  ProductID = 2,
                  Price = 30,
                  Quantity = 1,

                },
               new OrderItem
               {
                  // OrderItemID = 3,
                  OrderID = 3,
                  ProductID = 3,
                  Price = 20,
                  Quantity = 2,

                },
               new OrderItem
               {
                  // OrderItemID = 4,
                  OrderID = 3,
                  ProductID = 4,
                  Price = 60,
                  Quantity = 2,

                },
               new OrderItem
               {
                  // OrderItemID = 5,
                  OrderID = 3,
                  ProductID = 5,
                  Price = 15,
                  Quantity = 2,

                },
               new OrderItem
               {
                  // OrderItemID = 6,
                  OrderID = 4,
                  ProductID = 6,
                  Price = 15,
                  Quantity = 2,

                },
               new OrderItem
               {
                  // OrderItemID = 7,
                  OrderID = 5,
                  ProductID = 6,
                  Price = 40,
                  Quantity = 2,

                },
               new OrderItem
               {
                  // OrderItemID = 8,
                  OrderID = 6,
                  ProductID = 7,
                  Price = 25,
                  Quantity = 2,

                },
               new OrderItem
               {
                  // OrderItemID = 9,
                  OrderID = 7,
                  ProductID = 8,
                  Price = 90,
                  Quantity = 2,

                },
               new OrderItem
               {
                  // OrderItemID = 10,
                  OrderID = 8,
                  ProductID = 9,
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
                  //OrderID = 2,
                  DateOrdered= new DateTime(2020, 5, 1),
                  Status = Status.Delivered,
                  VAT =20,
                  DeliveryCharge = 20,
                  CustomerID = 1,

                },
               new Order
               {
                  //OrderID = 3,
                  DateOrdered = new DateTime(2020, 5, 2),
                  Status = Status.InProgress,
                  VAT =20,
                  DeliveryCharge = 10,
                  CustomerID = 2,

                },
               new Order
               {
                  //OrderID = 4,
                  DateOrdered = new DateTime(2020, 5, 3),
                  Status = Status.Dispatched,
                  VAT =20,
                  DeliveryCharge = 20,
                  CustomerID = 3,

                },
               new Order
               {
                  //OrderID = 4,
                  DateOrdered= new DateTime(2020, 5, 4),
                 Status = Status.Delivered,
                 VAT =20,
                  DeliveryCharge = 7,
                  CustomerID = 4,

                },
               new Order
               {
                  //OrderID = 5,
                  DateOrdered= new DateTime(2020, 5, 4),
                  Status = Status.Delivered,
                  VAT =20,
                  DeliveryCharge = 14,
                   CustomerID = 5,


                },
               new Order
               {
                  //OrderID = 6,
                  DateOrdered = new DateTime(2020, 5, 5),
                  Status = Status.Delivered,
                VAT =20,
                  DeliveryCharge = 10,
                  CustomerID = 6,

                },
               new Order
               {
                  //OrderID = 7,
                  DateOrdered= new DateTime(2020, 5, 6),
                  Status = Status.Delivered,
                  VAT =20,
                  DeliveryCharge = 15,
                  CustomerID = 7,

                },
               new Order
               {
                  //OrderID = 8,
                  DateOrdered= new DateTime(2020, 5, 6),
                  Status = Status.Delivered,
                  VAT =20,
                  DeliveryCharge = 13,
                  CustomerID = 8,

                },
               new Order
               {
                  //OrderID = 9,
                  DateOrdered = new DateTime(2020, 5, 7),
                  Status = Status.Delivered,
                 VAT =20,
                  DeliveryCharge = 8,
                  CustomerID = 9,

                },
               new Order
               {
                  //OrderID = 10,
                  DateOrdered = new DateTime(2020, 5, 8),
                  Status = Status.Delivered,
               VAT =20,
                  DeliveryCharge = 16,
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
            if (context.Message.Any())
            {
                return;
            }

            var Messages = new Message[]
            {
                new Message
                {
                    //MessageID = 1,
                    Date = new DateTime(2020, 05, 05),
                    Subject = "Delivery",
                    MessageField = "I ordered my product 2 days ago with next day delivery and it hasnt turned up",
                    CustomerID = 1,
                },
                 new Message
                {
                    //MessageID = 2,
                    Date = new DateTime(2020, 05, 06),
                    Subject = "Availability",
                    MessageField = "I noticed this product is out of stock. When it is coming in?",
                    CustomerID = 2,
                },
                  new Message
                {
                    //MessageID = 3,
                    Date = new DateTime(2020, 05, 07),
                    Subject = "Product",
                    MessageField = "I wanted if you are bringing in any new face masks?",
                    CustomerID = 3,
                },
                   new Message
                {
                    //MessageID = 4,
                    Date = new DateTime(2020, 05, 08),
                    Subject = "Allergies",
                    MessageField = "I am allergic to nuts. Do you use wallnuts in your products?",
                    CustomerID = 4,
                },

                     new Message
                {
                    //MessageID = 5,
                    Date = new DateTime(2020, 05, 09),
                    Subject = "Delivery",
                    MessageField = "How much are your delivery cost?",
                    CustomerID = 5,
                },
                      new Message
                {
                    //MessageID = 6,
                    Date = new DateTime(2020, 05, 11),
                    Subject = "Product",
                    MessageField = "Why have you discontinued your Aloe-Vera Night Gel?",
                    CustomerID = 6,
                },
                       new Message
                       {
                    //MessageID = 7,
                    Date = new DateTime(2020, 05, 11),
                    Subject = "Order",
                    MessageField = "I did not receive a confirmation for my order by email.",
                    CustomerID = 7,
                },
                        new Message
                {
                    //MessageID = 8,
                    Date = new DateTime(2020, 05, 13),
                    Subject = "Order",
                    MessageField = "Are the delivery estimations on your website?",
                    CustomerID = 8,
                },
                         new Message
                {
                    //MessageID = 9,
                    Date = new DateTime(2020, 05, 12),
                    Subject = "Offers",
                    MessageField = "Do you have any offers available on your websites?",
                    CustomerID = 9,
                },
 new Message
                {
                    //MessageID = 10,
                    Date = new DateTime(2020, 05, 13),
                    Subject = "Offers",
                    MessageField = "Do you offers any student discounts?",
                    CustomerID = 10,
               },

            };
            foreach (Message c in Messages)
            {
                context.Message.Add(c);
            }

            context.SaveChanges();

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
            {

                if (context.Review.Any())
                {
                    return;
                }

                var Reviews = new Review[]
                {
                    new Review
                    {
                      // ReviewID=1,
                       CustomerID=1,
                       Date = new DateTime(2020,05,5,3,4,5),
                       ProductID=1,
                       StarRating=4,
                       ReviewField="This product was amazing. Great for my skin tone.",
                      
                    },
                     new Review
                    {
                      // ReviewID=2,
                       CustomerID=1,
                       Date = new DateTime(2020, 05, 8),
                       ProductID=2,
                       StarRating=3,
                       ReviewField="The product is worth the money but the parcel did arrived one day late.",
                      
                    },
                      new Review
                    {
                      // ReviewID=3,
                       CustomerID=3,
                       Date = new DateTime(2020, 05, 7),
                       ProductID=3,
                       StarRating=5,
                       ReviewField="Loved this product. Amazing.",
                       
                    },
                       new Review
                    {
                      // ReviewID=4,
                       CustomerID=4,
                       Date = new DateTime(2020, 05, 9),
                       ProductID=4,
                       StarRating=1,
                       ReviewField="The product did not do well for my skin. It left my skin irritated.",
                       
                    },
                        new Review
                    {
                       //ReviewID=5,
                       CustomerID=5,
                       Date = new DateTime(2020, 05, 6),
                       ProductID = 5,
                       StarRating = 5,
                       ReviewField="I ordered a whole skin care routine it has match my lifestyle perfectly.",
                       
                    },
                         new Review
                    {
                      // ReviewID=6,
                       CustomerID=6,
                       Date = new DateTime(2020, 05, 8),
                       ProductID=6,
                       StarRating=3,
                       ReviewField="The price is perfect for what you get.",
                    
                    },
                          new Review
                    {
                      // ReviewID=7,
                       CustomerID=7,
                       Date = new DateTime(2020, 05, 9),
                       ProductID=7,
                       StarRating=4,
                       ReviewField="Not have one problem with this brand, would recomend.",
                     
                    },
                           new Review
                    {
                      // ReviewID=8,
                       CustomerID=8,
                       Date = new DateTime(2020, 05, 10),
                       ProductID=8,
                       StarRating=2,
                       ReviewField="This is a terrible product.",
                      
                    },
                            new Review
                    {
                       //ReviewID=9,
                       CustomerID=9,
                       Date = new DateTime(2020, 05, 11),
                       ProductID=9,
                       StarRating=5,
                       ReviewField="Love it, love it, love it.",
                      
                    },
                             new Review
                    {
                      // ReviewID=10,
                       CustomerID=10,
                       Date = new DateTime(2020, 05, 12),
                       ProductID=10,
                       StarRating=2,
                       ReviewField="We don't get much for your money.",
                      
                   },

                };
                foreach (Review c in Reviews)
                {
                    context.Review.Add(c);
                }

                context.SaveChanges();

            }
        }

    } 
}

