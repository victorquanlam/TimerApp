﻿using SampleWebApiAspNetCore.Entities;
using SampleWebApiAspNetCore.Repositories;
using System;
using System.Threading.Tasks;

namespace SampleWebApiAspNetCore.Services
{
    public class SeedDataService : ISeedDataService
    {
        public async Task Initialize(FoodDbContext context)
        {
            context.FoodItems.Add(new FoodEntity() { Calories = 1000, Type = "Starter", Name = "Lasagne", Created = DateTime.Now });
            context.FoodItems.Add(new FoodEntity() { Calories = 1100, Type = "Main", Name = "Hamburger", Created = DateTime.Now });
            context.FoodItems.Add(new FoodEntity() { Calories = 1200, Type = "Dessert", Name = "Spaghetti", Created = DateTime.Now });
            context.FoodItems.Add(new FoodEntity() { Calories = 1300, Type = "Starter", Name = "Pizza", Created = DateTime.Now });

            await context.SaveChangesAsync();
        }
    }
}
