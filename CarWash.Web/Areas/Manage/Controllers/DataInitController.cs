using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarWash.Web.Infrastructures.Domain.Data;
using CarWash.Web.Infrastructures.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarWash.Web.Areas.Manage.Controllers
{
    public class DataInitController : Controller
    {
        private readonly DefaultDbContext _context;
        public DataInitController(DefaultDbContext context)
        {
            _context = context;
        }

        [HttpGet, Route("manage/data-init/execute")]
        public IActionResult DataInit()
        {

            #region Group
            if (this._context.Groups.Count() < 1)
            {
                this._context.Groups.Add(
                    new Infrastructures.Domain.Models.Group()
                    {
                        Id = Guid.Parse("97624d06-c1c5-4790-acab-36d5ae507582"),
                        Description = "Group 1",
                        Name = "Group 1",
                        Status = Infrastructures.Domain.Enums.Status.Active
                    });


                this._context.Groups.Add(
                   new Infrastructures.Domain.Models.Group()
                   {
                       Id = Guid.Parse("dd781d9f-5552-4755-8253-337578045ee2"),
                       Description = "Group 2",
                       Name = "Group 2",
                       Status = Infrastructures.Domain.Enums.Status.Active
                   });


                this._context.Groups.Add(
                   new Infrastructures.Domain.Models.Group()
                   {
                       Id = Guid.Parse("f3e1021c-ada6-4e87-90d1-461e7c0768f1"),
                       Description = "Group 3",
                       Name = "Group 3",
                       Status = Infrastructures.Domain.Enums.Status.Active
                   });


                this._context.Groups.Add(
                   new Infrastructures.Domain.Models.Group()
                   {
                       Id = Guid.Parse("f177da53-bcca-47fb-b56d-c3ba26f13c47"),
                       Description = "Group 4",
                       Name = "Group 4",
                       Status = Infrastructures.Domain.Enums.Status.Active
                   });


                this._context.Groups.Add(
                   new Infrastructures.Domain.Models.Group()
                   {
                       Id = Guid.Parse("ca12429f-85ef-4bff-b33a-7e2a2ac6327c"),
                       Description = "Group 5",
                       Name = "Group 5",
                       Status = Infrastructures.Domain.Enums.Status.Active
                   });
            }
            #endregion

       
          

            #region User
            if (this._context.Users.Count() < 1)
            {

                this._context.Users.Add(
                           new Infrastructures.Domain.Models.User()
                           {
                               Id = Guid.Parse("1bb688b3-3228-48c5-80bb-35050994a8fa"),
                               FirstName = "Arwin",
                               LastName = "Tolentino,",
                               LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                               LoginRetries = 0,
                               RegistrationCode = "ABCDEFG",
                               EmailAddress = "arwintolentino@gmail.com",
                               Gender = Infrastructures.Domain.Enums.Gender.Male,
                               Password = BCrypt.BCryptHelper.HashPassword("Arwin123", BCrypt.BCryptHelper.GenerateSalt(9)),
                               PhoneNumber = "09123456789",
                           
                               UserName = "Arwin Tolentino",




                           });

                this._context.Users.Add(
                          new Infrastructures.Domain.Models.User()
                          {
                              Id = Guid.Parse("a265c0a2-5b7c-4d29-bdf1-f95780d820df"),
                              FirstName = "Larich",
                              LastName = "Morales,",
                              LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                              LoginRetries = 0,
                              RegistrationCode = "ABCDEFG",
                              EmailAddress = "larichmorales@gmail.com",
                              Gender = Infrastructures.Domain.Enums.Gender.Male,
                              Password = BCrypt.BCryptHelper.HashPassword("larich123", BCrypt.BCryptHelper.GenerateSalt(9)),
                              PhoneNumber = "09123456789",

                              UserName = "Larich Tolentino",




                          });


                this._context.Users.Add(
                          new Infrastructures.Domain.Models.User()
                          {
                              Id = Guid.Parse("f0c0f3ab-7cb6-48fd-abe8-45dc2d5c1bf1"),
                              FirstName = "User1",
                              LastName = "User1,",
                              LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                              LoginRetries = 0,
                              RegistrationCode = "ABCDEFG",
                              EmailAddress = "user1@gmail.com",
                              Gender = Infrastructures.Domain.Enums.Gender.Male,
                              Password = BCrypt.BCryptHelper.HashPassword("user123", BCrypt.BCryptHelper.GenerateSalt(9)),
                              PhoneNumber = "09123456789",
                              UserName = "User1 Tester",




                          });


            }
            #endregion

            #region UserGroup
            if (this._context.UserGroups.Count() < 1)
            {

                this._context.UserGroups.Add(
                           new Infrastructures.Domain.Models.UserGroup()
                           {
                               Id = Guid.Parse("f2a67339-22d5-4a59-ad6f-1ce4e6bf09c3"),
                               UserId = Guid.Parse("1bb688b3-3228-48c5-80bb-35050994a8fa"),
                               GroupId = Guid.Parse("97624d06-c1c5-4790-acab-36d5ae507582")



                           });

                this._context.UserGroups.Add(
                           new Infrastructures.Domain.Models.UserGroup()
                           {
                               Id = Guid.Parse("dbe8b2f9-98a3-4813-8a2b-3376a2605327"),
                               UserId = Guid.Parse("a265c0a2-5b7c-4d29-bdf1-f95780d820df"),
                               GroupId = Guid.Parse("dd781d9f-5552-4755-8253-337578045ee2")





                           });


              
            }
            #endregion

            #region UserRole
            if (this._context.UserRoles.Count() < 1)
            {

                this._context.UserRoles.Add(
                           new Infrastructures.Domain.Models.UserRole()
                           {
                               Id = Guid.Parse("1bb688b3-3228-48c5-80bb-35050994a8fa"),
                               UserId = Guid.Parse("1bb688b3-3228-48c5-80bb-35050994a8fa"),
                               Role = Infrastructures.Domain.Enums.Role.ContentAdmin,




                           });

                this._context.UserRoles.Add(
                           new Infrastructures.Domain.Models.UserRole()
                           {
                               Id = Guid.Parse("804970a0-63b4-4d43-8ada-4dca94ea1fec"),
                               UserId = Guid.Parse("a265c0a2-5b7c-4d29-bdf1-f95780d820df"),
                               Role = Infrastructures.Domain.Enums.Role.Admin,





                           });

                this._context.UserRoles.Add(
                       new Infrastructures.Domain.Models.UserRole()
                       {
                           Id = Guid.Parse("2d237735-2473-4d4b-a926-c1d74b1f03ea"),
                           UserId = Guid.Parse("f0c0f3ab-7cb6-48fd-abe8-45dc2d5c1bf1"),
                           Role = Infrastructures.Domain.Enums.Role.User,





                       });


            }
            #endregion


            #region Services

            if (this._context.Services.Count() < 1)
            {
                this._context.Services.Add(
                        new Infrastructures.Domain.Models.Service()
                        {
                            Vehicle = "Small",
                            Description = "Pressurised Body Wash," + "Foam Cannon Wash(Synthetic Wax & Conditioner)" + ",   Air Blow Dry" + ", Interior Vacuum and Cleaning" + ",  Glass Cleaning" + ",   Tire and Wheel Shine" + ", Engine Wipe",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,
                            Id = Guid.Parse("48c17352-e45f-46b8-b288-532dfd989f43"),
                            Price = 260,
                            ServiceType = Infrastructures.Domain.Enums.ServiceType.Wash,

                        });

                this._context.Services.Add(
                      new Infrastructures.Domain.Models.Service()
                      {
                          Vehicle = "Medium",
                          Description = "Waterless wash light to medium Dirt or Stain," + " Bead and Shine Chemical Wash(Carnauba, Polymer and Siloxane)," + ", Tire and Wheel Shine" + "  Plush Microfiber Towel Hand Dry," + "  Engine Wipe",                       
                          CreatedAt = DateTime.UtcNow,
                          UpdatedAt = DateTime.UtcNow,
                          Id = Guid.Parse("cade2002-37c6-4beb-a731-9ca411be158f"),
                          Price = 450,
                          ServiceType = Infrastructures.Domain.Enums.ServiceType.Waterless,

                      });

                this._context.Services.Add(
                        new Infrastructures.Domain.Models.Service()
                        {
                            Vehicle = "Large",
                            Description = "  Pressurised Body Wash," + " Paint Degrimming and Tar Removal," + " Foam Cannon Wash(Synthetic Wash and Conditioner)," + "   Air Blow Dry," + "   Interior Vacuum and Cleaning,"+ "DA1.0 paint Cleaning and Degreasing," + "  J1.0 Sealant Wax Spray(Carnauba, Polymer, Siloxane)" + "Glass Cleaning," + "Tire and Wheel Shine," + " Engine wipe",
                             CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,
                            Id = Guid.Parse("4ea25ac2-48fe-4362-a397-a1c2db9f91db"),
                            Price = 1000,
                            ServiceType = Infrastructures.Domain.Enums.ServiceType.Shine,

                        });

                this._context.Services.Add(
                    new Infrastructures.Domain.Models.Service()
                    {
                        Vehicle = "Extra Large",
                        Description = "  Pressurised Body Wash," + "  Paint Degrimming and Tar Removal," + "Foam Cannon Wash(Synthetic Wash and Conditioner)," + " Air Blow Dry,"+ " Interior Vacuum and Cleaning," + "  DA1.0 paint Cleaning and Degreasing," + " J1.0 Sealant Wax Spray(Carnauba, Polymer, Siloxane)," + " Glass Cleaning," 
                        + " Tire and Wheel Shine," + "NJ1.0 Engine Degreasing / Wipe Down," + " Zero Bacteria ",
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Id = Guid.Parse("117b87c1-8f39-4b64-8a54-4bed313afb87"),
                        Price = 3000,
                        ServiceType = Infrastructures.Domain.Enums.ServiceType.Signature,

                    });



                this._context.Services.Add(
                  new Infrastructures.Domain.Models.Service()
                  {
                      Vehicle = "MICRO" + "" +"(Small)",
                      Description = "Pressurised Body Wash," + "Foam Cannon Wash(Synthetic Wax & Conditioner)" + ",   Air Blow Dry" + ", Interior Vacuum and Cleaning" + ",  Glass Cleaning" + ",   Tire and Wheel Shine" + ", Engine Wipe",
                      CreatedAt = DateTime.UtcNow,
                      UpdatedAt = DateTime.UtcNow,
                      Id = Guid.Parse("77e2ced2-05c5-4cb5-a5c3-feb92f2f5f10"),
                      Price = 260,
                      ServiceType = Infrastructures.Domain.Enums.ServiceType.Wash,

                  });


                this._context.Services.Add(
                      new Infrastructures.Domain.Models.Service()
                      {
                          Vehicle = "SEDAN" +"" + "(Small)",
                          Description = "Pressurised Body Wash," + "Foam Cannon Wash(Synthetic Wax & Conditioner)" + ",   Air Blow Dry" + ", Interior Vacuum and Cleaning" + ",  Glass Cleaning" + ",   Tire and Wheel Shine" + ", Engine Wipe",
                          CreatedAt = DateTime.UtcNow,
                          UpdatedAt = DateTime.UtcNow,
                          Id = Guid.Parse("bb8a61ba-a5bf-4026-9c86-0d7575d0df9d"),
                          Price = 260,
                          ServiceType = Infrastructures.Domain.Enums.ServiceType.Wash,

                      });

                this._context.Services.Add(
                     new Infrastructures.Domain.Models.Service()
                     {
                         Vehicle = "HATCHBACK" + "" + "(Small)",
                         Description = "Pressurised Body Wash," + "Foam Cannon Wash(Synthetic Wax & Conditioner)" + ",   Air Blow Dry" + ", Interior Vacuum and Cleaning" + ",  Glass Cleaning" + ",   Tire and Wheel Shine" + ", Engine Wipe",
                         CreatedAt = DateTime.UtcNow,
                         UpdatedAt = DateTime.UtcNow,
                         Id = Guid.Parse("4b1eb8db-e4ff-44e0-93d4-18b841fde950"),
                         Price = 260,
                         ServiceType = Infrastructures.Domain.Enums.ServiceType.Wash,

                     });


                this._context.Services.Add(
                   new Infrastructures.Domain.Models.Service()
                   {
                       Vehicle = "CONVERTIBLE" + "" + "(Small)",
                       Description = "Pressurised Body Wash," + "Foam Cannon Wash(Synthetic Wax & Conditioner)" + ",   Air Blow Dry" + ", Interior Vacuum and Cleaning" + ",  Glass Cleaning" + ",   Tire and Wheel Shine" + ", Engine Wipe",
                       CreatedAt = DateTime.UtcNow,
                       UpdatedAt = DateTime.UtcNow,
                       Id = Guid.Parse("b17b378c-6a3f-4105-ab96-e9766c543f12"),
                       Price = 260,
                       ServiceType = Infrastructures.Domain.Enums.ServiceType.Wash,

                   });

             

                this._context.Services.Add(
                   new Infrastructures.Domain.Models.Service()
                   {
                       Vehicle = "MPV" +"" +"(Medium)",
                       Description = "Waterless wash light to medium Dirt or Stain," + " Bead and Shine Chemical Wash(Carnauba, Polymer and Siloxane)," + ", Tire and Wheel Shine" + "  Plush Microfiber Towel Hand Dry," + "  Engine Wipe",
                       CreatedAt = DateTime.UtcNow,
                       UpdatedAt = DateTime.UtcNow,
                       Id = Guid.Parse("f628a4cc-8163-47d2-9662-37e15d2d9d6c"),
                       Price = 450,
                       ServiceType = Infrastructures.Domain.Enums.ServiceType.Waterless,

                   });

                this._context.Services.Add(
                 new Infrastructures.Domain.Models.Service()
                 {
                     Vehicle = "PICKUP" + "" + "(Medium)",
                     Description = "Waterless wash light to medium Dirt or Stain," + " Bead and Shine Chemical Wash(Carnauba, Polymer and Siloxane)," + ", Tire and Wheel Shine" + "  Plush Microfiber Towel Hand Dry," + "  Engine Wipe",
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow,
                     Id = Guid.Parse("b19014ed-800c-4feb-8de9-4ed0c5aaebcf"),
                     Price = 450,
                     ServiceType = Infrastructures.Domain.Enums.ServiceType.Waterless,

                 });

                this._context.Services.Add(
                new Infrastructures.Domain.Models.Service()
                {
                    Vehicle = "WAGON" + "" + "(Medium)",
                    Description = "Waterless wash light to medium Dirt or Stain," + " Bead and Shine Chemical Wash(Carnauba, Polymer and Siloxane)," + ", Tire and Wheel Shine" + "  Plush Microfiber Towel Hand Dry," + "  Engine Wipe",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    Id = Guid.Parse("7aa9d3bb-738e-457e-a3cf-c955058dd8f3"),
                    Price = 450,
                    ServiceType = Infrastructures.Domain.Enums.ServiceType.Waterless,

                });

                this._context.Services.Add(
                  new Infrastructures.Domain.Models.Service()
                  {
                      Vehicle = "LUXURY" + "" + "(Medium)",
                      Description = "Waterless wash light to medium Dirt or Stain," + " Bead and Shine Chemical Wash(Carnauba, Polymer and Siloxane)," + ", Tire and Wheel Shine" + "  Plush Microfiber Towel Hand Dry," + "  Engine Wipe",
                      CreatedAt = DateTime.UtcNow,
                      UpdatedAt = DateTime.UtcNow,
                      Id = Guid.Parse("b526d015-3862-4449-aede-e00194f3493e"),
                      Price = 450,
                      ServiceType = Infrastructures.Domain.Enums.ServiceType.Waterless,

                  });

                this._context.Services.Add(
               new Infrastructures.Domain.Models.Service()
               {
                   Vehicle = "CABRIOLET" + "" + "(Medium)",
                   Description = "Waterless wash light to medium Dirt or Stain," + " Bead and Shine Chemical Wash(Carnauba, Polymer and Siloxane)," + ", Tire and Wheel Shine" + "  Plush Microfiber Towel Hand Dry," + "  Engine Wipe",
                   CreatedAt = DateTime.UtcNow,
                   UpdatedAt = DateTime.UtcNow,
                   Id = Guid.Parse("3696c397-1b67-435e-8f57-bf92b8922201"),
                   Price = 450,
                   ServiceType = Infrastructures.Domain.Enums.ServiceType.Waterless,

               });



                this._context.Services.Add(
                      new Infrastructures.Domain.Models.Service()
                      {
                          Vehicle = "COUPE" +""+ "Large",
                          Description = "  Pressurised Body Wash," + " Paint Degrimming and Tar Removal," + " Foam Cannon Wash(Synthetic Wash and Conditioner)," + "   Air Blow Dry," + "   Interior Vacuum and Cleaning," + "DA1.0 paint Cleaning and Degreasing," + "  J1.0 Sealant Wax Spray(Carnauba, Polymer, Siloxane)" + "Glass Cleaning," + "Tire and Wheel Shine," + " Engine wipe",
                          CreatedAt = DateTime.UtcNow,
                          UpdatedAt = DateTime.UtcNow,
                          Id = Guid.Parse("e9a86cf4-075c-43ba-ae07-9831ee239a23"),
                          Price = 1000,
                          ServiceType = Infrastructures.Domain.Enums.ServiceType.Shine,

                      });


                this._context.Services.Add(
                     new Infrastructures.Domain.Models.Service()
                     {
                         Vehicle = "SPORT CAR" + "" + "Large",
                         Description = "  Pressurised Body Wash," + " Paint Degrimming and Tar Removal," + " Foam Cannon Wash(Synthetic Wash and Conditioner)," + "   Air Blow Dry," + "   Interior Vacuum and Cleaning," + "DA1.0 paint Cleaning and Degreasing," + "  J1.0 Sealant Wax Spray(Carnauba, Polymer, Siloxane)" + "Glass Cleaning," + "Tire and Wheel Shine," + " Engine wipe",
                         CreatedAt = DateTime.UtcNow,
                         UpdatedAt = DateTime.UtcNow,
                         Id = Guid.Parse("3685ab21-ce0c-4937-b85e-ef83d236f79c"),
                         Price = 1000,
                         ServiceType = Infrastructures.Domain.Enums.ServiceType.Shine,

                     });

                this._context.Services.Add(
                  new Infrastructures.Domain.Models.Service()
                  {
                      Vehicle = "MUSCLE CAR" + "" + "Large",
                      Description = "  Pressurised Body Wash," + " Paint Degrimming and Tar Removal," + " Foam Cannon Wash(Synthetic Wash and Conditioner)," + "   Air Blow Dry," + "   Interior Vacuum and Cleaning," + "DA1.0 paint Cleaning and Degreasing," + "  J1.0 Sealant Wax Spray(Carnauba, Polymer, Siloxane)" + "Glass Cleaning," + "Tire and Wheel Shine," + " Engine wipe",
                      CreatedAt = DateTime.UtcNow,
                      UpdatedAt = DateTime.UtcNow,
                      Id = Guid.Parse("0452de9b-68d9-4f1f-b5e3-1cf88dae91e7"),
                      Price = 1000,
                      ServiceType = Infrastructures.Domain.Enums.ServiceType.Shine,

                  });


                    this._context.Services.Add(
                new Infrastructures.Domain.Models.Service()
                {
                    Vehicle = "LIMOUSINE" + "" + "EXTRA LARGE",
                    Description = "  Pressurised Body Wash," + "  Paint Degrimming and Tar Removal," + "Foam Cannon Wash(Synthetic Wash and Conditioner)," + " Air Blow Dry," + " Interior Vacuum and Cleaning," + "  DA1.0 paint Cleaning and Degreasing," + " J1.0 Sealant Wax Spray(Carnauba, Polymer, Siloxane)," + " Glass Cleaning,"
                        + " Tire and Wheel Shine," + "NJ1.0 Engine Degreasing / Wipe Down," + " Zero Bacteria ",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    Id = Guid.Parse("d8de9aaf-8e4f-4b45-9486-451032d4696a"),
                    Price = 3000,
                    ServiceType = Infrastructures.Domain.Enums.ServiceType.Wash,

                });

                        this._context.Services.Add(
              new Infrastructures.Domain.Models.Service()
              {
                  Vehicle = "CAMPER VAN" + "" + "EXTRA LARGE",
                  Description = "  Pressurised Body Wash," + "  Paint Degrimming and Tar Removal," + "Foam Cannon Wash(Synthetic Wash and Conditioner)," + " Air Blow Dry," + " Interior Vacuum and Cleaning," + "  DA1.0 paint Cleaning and Degreasing," + " J1.0 Sealant Wax Spray(Carnauba, Polymer, Siloxane)," + " Glass Cleaning,"
                      + " Tire and Wheel Shine," + "NJ1.0 Engine Degreasing / Wipe Down," + " Zero Bacteria ",
                  CreatedAt = DateTime.UtcNow,
                  UpdatedAt = DateTime.UtcNow,
                  Id = Guid.Parse("f109a8ff-e169-4191-8916-eae435484327"),
                  Price = 3000,
                  ServiceType = Infrastructures.Domain.Enums.ServiceType.Wash,

              });


                        this._context.Services.Add(
             new Infrastructures.Domain.Models.Service()
             {
                 Vehicle = "TRUCK" + "" + "EXTRA LARGE",
                 Description = "  Pressurised Body Wash," + "  Paint Degrimming and Tar Removal," + "Foam Cannon Wash(Synthetic Wash and Conditioner)," + " Air Blow Dry," + " Interior Vacuum and Cleaning," + "  DA1.0 paint Cleaning and Degreasing," + " J1.0 Sealant Wax Spray(Carnauba, Polymer, Siloxane)," + " Glass Cleaning,"
                     + " Tire and Wheel Shine," + "NJ1.0 Engine Degreasing / Wipe Down," + " Zero Bacteria ",
                 CreatedAt = DateTime.UtcNow,
                 UpdatedAt = DateTime.UtcNow,
                 Id = Guid.Parse("37379123-92b9-4234-b403-1a0f3674f19e"),
                 Price = 3000,
                 ServiceType = Infrastructures.Domain.Enums.ServiceType.Wash,

             });


                        this._context.Services.Add(
             new Infrastructures.Domain.Models.Service()
             {
                 Vehicle = "BIG TRUCK" + "" + "EXTRA LARGE",
                 Description = "  Pressurised Body Wash," + "  Paint Degrimming and Tar Removal," + "Foam Cannon Wash(Synthetic Wash and Conditioner)," + " Air Blow Dry," + " Interior Vacuum and Cleaning," + "  DA1.0 paint Cleaning and Degreasing," + " J1.0 Sealant Wax Spray(Carnauba, Polymer, Siloxane)," + " Glass Cleaning,"
                     + " Tire and Wheel Shine," + "NJ1.0 Engine Degreasing / Wipe Down," + " Zero Bacteria ",
                 CreatedAt = DateTime.UtcNow,
                 UpdatedAt = DateTime.UtcNow,
                 Id = Guid.Parse("e7bedc19-d3c2-47b2-b710-97b1de1faec7"),
                 Price = 3000,
                 ServiceType = Infrastructures.Domain.Enums.ServiceType.Wash,

             });
            }





            #endregion


            #region Booking
            if (this._context.Bookings.Count() < 1)
            {

                this._context.Bookings.Add(
                           new Infrastructures.Domain.Models.Booking()
                           {
                               Id = Guid.Parse("4fd5b1b2-7031-48b2-9ec4-f402daeb62b0"),
                               BookingAddress = "Dinalupihan,Bataan",
                               CostumerId = Guid.Parse("1bb688b3-3228-48c5-80bb-35050994a8fa"),
                               CreatedAt = DateTime.UtcNow,
                               UpdatedAt = DateTime.UtcNow,
                               Time = "3:45 PM",
                               ServiceId = Guid.Parse("77e2ced2-05c5-4cb5-a5c3-feb92f2f5f10"),
                               
                               




                           });


                this._context.Bookings.Add(
                           new Infrastructures.Domain.Models.Booking()
                           {
                               Id = Guid.Parse("6e69691a-6f1a-4227-ad59-d8340348f38f"),
                               BookingAddress = "Dinalupihan,Bataan",
                               CostumerId = Guid.Parse("a265c0a2-5b7c-4d29-bdf1-f95780d820df"),
                               CreatedAt = DateTime.UtcNow,
                               UpdatedAt = DateTime.UtcNow,
                      
                               Time = "3:45 PM",
                               ServiceId = Guid.Parse("bb8a61ba-a5bf-4026-9c86-0d7575d0df9d"),
                          





                           });


                this._context.Bookings.Add(
                           new Infrastructures.Domain.Models.Booking()
                           {
                               Id = Guid.Parse("510b2356-f08a-4b46-a5ab-f4bc2b4d5f93"),
                               BookingAddress = "Dinalupihan,Bataan",
                               CostumerId = Guid.Parse("f0c0f3ab-7cb6-48fd-abe8-45dc2d5c1bf1"),
                               CreatedAt = DateTime.UtcNow,
                               UpdatedAt = DateTime.UtcNow,
                               Time = "3:45 PM",
                               ServiceId = Guid.Parse("4b1eb8db-e4ff-44e0-93d4-18b841fde950"),


                           });

            }
            #endregion

            foreach (Booking booking in _context.Bookings)
            {
                var bookingDataBase = this._context.Bookings.Where(b =>
                    b.ServiceId == booking.ServiceId &&
                    b.CostumerId == booking.CostumerId).SingleOrDefault();

                if(bookingDataBase == null)
                {
                    _context.Bookings.Add(booking);
                }
            }

            this._context.SaveChanges();
            return Ok("Ok");
        }
    }
}
