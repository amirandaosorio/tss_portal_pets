using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portal_pets.Pages.Login.Registrarse
{
    public partial class Registrar : ComponentBase
    {




        public class Order
        {
            public int CardId { get; set; }
            public string CardNr { get; set; }
            public DateTime ExpiryDate { get; set; }
            public string CardHolder { get; set; }
            public string Name { get; set; }
            public string Address1 { get; set; }
            public string Address2 { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip { get; set; }
            public int Country { get; set; }
            public int StoreId { get; set; }
            public string Warehouse { get; set; }
            public string Region { get; set; }
            public string System { get; set; }
            public int TransId { get; set; }
            public string Register { get; set; }
            public string Clerk { get; set; }
            public decimal Amount { get; set; }
            public decimal Tax { get; set; }
            public DateTime OrderDate { get; set; }
            public DateTime ShipDate { get; set; }
        }

        public class CreditCard
        {
            public int CardId { get; set; }
            public string CardNr { get; set; }
        }

        public class Country
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        Order order = new Order()
        {
            ExpiryDate = DateTime.Parse("10/10/2022"),
            OrderDate = DateTime.Now,
            ShipDate = DateTime.Now
        };

        List<CreditCard> cards = new List<CreditCard>()
{
        new CreditCard() { CardId = 1, CardNr = "5555555555554444" },
        new CreditCard() { CardId = 2, CardNr = "4012888888881881" }
    };

        List<Country> countries = new List<Country>()
{
        new Country() { Id = 1, Name = "USA" },
        new Country() { Id = 2, Name = "Germany" }
    };

        void Submit(Order arg)
        {
            //
        }

        void Cancel()
        {
            //
        }


    }
}
