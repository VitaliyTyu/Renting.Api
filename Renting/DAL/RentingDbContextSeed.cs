using System;
using System.Linq;
using System.Threading.Tasks;

using Lab9.App.DAL.Entities;

namespace Lab9.App.DAL
{
    public class RentingDbContextSeed
    {
        public static async Task InitializeDb(RentingDbContext db)
        {
            if (db.Items.Any())
                return;

            var country1 = new Country() { Name = "�����", ApprovalRating = 8 };
            var country2 = new Country() { Name = "������", ApprovalRating = 7 };
            var country3 = new Country() { Name = "��������", ApprovalRating = 6 };
            await db.Countries.AddRangeAsync(country1, country2, country3);


            var item1 = new Item() { Name = "����", RentPrice = 100.00m, Length = 150, Country = country1 };
            var item2 = new Item() { Name = "�����", RentPrice = 75.00m, Length = 100, Country = country2 };
            var item3 = new Item() { Name = "�������", RentPrice = 10.00m, Country = country2 };
            var item4 = new Item() { Name = "����", RentPrice = 10.00m, Length = 2000, Country = country3 };
            await db.Items.AddRangeAsync(item1, item2, item3, item4);


            var customer1 = new Customer() { Name = "����", Age = 20, Height = 180, ShoeSizeRu = 45 };
            var customer2 = new Customer() { Name = "�����", Age = 25, Height = 170, ShoeSizeRu = 40 };
            var customer3 = new Customer() { Name = "����", Age = 30, Height = 175, ShoeSizeRu = 42 };
            await db.Customers.AddRangeAsync(customer1, customer2, customer3);


            var rent1 = new Rent() { StartDate = new DateTime(2022, 12, 1), ExpectedEndDate = new DateTime(2022, 12, 3), Customer = customer1, Item = item1 };
            var rent2 = new Rent() { StartDate = new DateTime(2022, 12, 1), ExpectedEndDate = new DateTime(2022, 12, 3), Customer = customer1, Item = item4 };
            var rent3 = new Rent() { StartDate = new DateTime(2022, 12, 5), ExpectedEndDate = new DateTime(2022, 12, 6), Customer = customer2, Item = item2 };
            var rent4 = new Rent() { StartDate = new DateTime(2022, 12, 5), ExpectedEndDate = new DateTime(2022, 12, 6), Customer = customer3, Item = item2 };
            var rent5 = new Rent() { StartDate = new DateTime(2022, 12, 5), ExpectedEndDate = new DateTime(2022, 12, 6), Customer = customer3, Item = item3 };
            await db.Rents.AddRangeAsync(rent1, rent2, rent3, rent4, rent5);

            var penalty1 = new Penalty() { Type = "������� ����������", Price = 1000m, Rent = rent1 };
            await db.Penalties.AddRangeAsync(penalty1);

            await db.SaveChangesAsync();
        }
    }
}