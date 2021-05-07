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
                               MaskUser = true,
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
                              MaskUser = true,
                              UserName = "Larich Morales",




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
                              MaskUser = true,



                          });


            }
            #endregion

            #region UserGroup
            if (this._context.UserGroups.Count() < 1)
            {

                this._context.UserGroups.Add(
                           new Infrastructures.Domain.Models.UserGroup()
                           {
                               Id = Guid.Parse("152e9c2c-492e-47f8-807f-f5e14f507e99"),
                               UserId = Guid.Parse("1bb688b3-3228-48c5-80bb-35050994a8fa"),
                               GroupId = Guid.Parse("97624d06-c1c5-4790-acab-36d5ae507582")



                           });

                this._context.UserGroups.Add(
                           new Infrastructures.Domain.Models.UserGroup()
                           {
                               Id = Guid.Parse("d0ceb6af-a54a-45ec-85b5-d35ee4ded484"),
                               UserId = Guid.Parse("a265c0a2-5b7c-4d29-bdf1-f95780d820df"),
                               GroupId = Guid.Parse("dd781d9f-5552-4755-8253-337578045ee2")





                           });


                this._context.UserGroups.Add(
                           new Infrastructures.Domain.Models.UserGroup()
                           {
                               Id = Guid.Parse("f88fe5cc-4ff8-4313-889d-1fd2301e633c"),
                               UserId = Guid.Parse("f0c0f3ab-7cb6-48fd-abe8-45dc2d5c1bf1"),
                               GroupId = Guid.Parse("f3e1021c-ada6-4e87-90d1-461e7c0768f1")





                           });


            }
            #endregion

            #region UserRole
            if (this._context.UserRoles.Count() < 1)
            {

                this._context.UserRoles.Add(
                           new Infrastructures.Domain.Models.UserRole()
                           {
                               Id = Guid.Parse("267b62b0-80cd-45e1-b4b9-8dbc8aa82c83"),
                               UserId = Guid.Parse("1bb688b3-3228-48c5-80bb-35050994a8fa"),
                               Role = Infrastructures.Domain.Enums.Role.ContentAdmin,




                           });

                this._context.UserRoles.Add(
                           new Infrastructures.Domain.Models.UserRole()
                           {
                               Id = Guid.Parse("8324183b-61ea-49d8-aac3-c637f5181c70"),
                               UserId = Guid.Parse("a265c0a2-5b7c-4d29-bdf1-f95780d820df"),
                               Role = Infrastructures.Domain.Enums.Role.Admin,





                           });

                this._context.UserRoles.Add(
                       new Infrastructures.Domain.Models.UserRole()
                       {
                           Id = Guid.Parse("6165c70c-5a96-4c6b-8400-e30b73b4dc74"),
                           UserId = Guid.Parse("f0c0f3ab-7cb6-48fd-abe8-45dc2d5c1bf1"),
                           Role = Infrastructures.Domain.Enums.Role.User,





                       });


            }
            #endregion


            #region Services

            if (this._context.Services.Count() < 1)
            {
                //Manual-Individual-Wash-Services
                this._context.Services.Add(
                  new Infrastructures.Domain.Models.Service()
                  {
                      Vehicle = "Mr. Sponge's Economy Wash",
                      Description = "Small",
                      CreatedAt = DateTime.UtcNow,
                      UpdatedAt = DateTime.UtcNow,
                      Id = Guid.Parse("b0b923f7-74f4-4eb1-9832-23b772979da8"),
                      Price = 129, 
                      ServiceType = Infrastructures.Domain.Enums.ServiceType.Wash,
                      
                  });

                this._context.Services.Add(
                 new Infrastructures.Domain.Models.Service()
                 {
                     Vehicle = "Mr. Sponge’s Classic Swag (w/ vacuum)",
                     Description = "Small",
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow,
                     Id = Guid.Parse("7e4afd49-3d01-4bce-89c0-b4c18d06bf08"),
                     Price = 159,
                     ServiceType = Infrastructures.Domain.Enums.ServiceType.Wash,

                 });

                this._context.Services.Add(
                new Infrastructures.Domain.Models.Service()
                {
                    Vehicle = "Wash and Wax Deluxe",
                    Description = "Small",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    Id = Guid.Parse("f937603b-693a-4ba8-b38d-6b2e21c9962f"),
                    Price = 499,
                    ServiceType = Infrastructures.Domain.Enums.ServiceType.Wash,

                });

                this._context.Services.Add(
                new Infrastructures.Domain.Models.Service()
                {
                    Vehicle = "Mr. Sponge's Economy Wash",
                    Description = "Medium ",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    Id = Guid.Parse("f4ae51f3-629c-48ec-8695-f978f4c8e7a8"),
                    Price = 149,
                    ServiceType = Infrastructures.Domain.Enums.ServiceType.Wash,

                });

                this._context.Services.Add(
                 new Infrastructures.Domain.Models.Service()
                 {
                     Vehicle = "Mr. Sponge’s Classic Swag (w/ vacuum)",
                     Description = "Medium",
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow,
                     Id = Guid.Parse("c12cf5b4-a65c-461b-b5a5-9c05febef41a"),
                     Price = 179,
                     ServiceType = Infrastructures.Domain.Enums.ServiceType.Wash,

                 });

                this._context.Services.Add(
                new Infrastructures.Domain.Models.Service()
                {
                    Vehicle = "Wash and Wax Deluxe",
                    Description = "Medium",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    Id = Guid.Parse("4a5958f0-872f-4488-9170-e84d176743c6"),
                    Price = 519,
                    ServiceType = Infrastructures.Domain.Enums.ServiceType.Wash,

                });

                this._context.Services.Add(
              new Infrastructures.Domain.Models.Service()
              {
                  Vehicle = "Mr. Sponge's Economy Wash",
                  Description = "Large ",
                  CreatedAt = DateTime.UtcNow,
                  UpdatedAt = DateTime.UtcNow,
                  Id = Guid.Parse("91ae4d5f-ae88-4ba8-ac37-892cc2b16305"),
                  Price = 169,
                  ServiceType = Infrastructures.Domain.Enums.ServiceType.Wash,

              });

                this._context.Services.Add(
                 new Infrastructures.Domain.Models.Service()
                 {
                     Vehicle = "Mr. Sponge’s Classic Swag (w/ vacuum)",
                     Description = "Large",
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow,
                     Id = Guid.Parse("b25f14a3-16da-4ba1-95c0-a8bd41816613"),
                     Price = 199,
                     ServiceType = Infrastructures.Domain.Enums.ServiceType.Wash,

                 });

                this._context.Services.Add(
                new Infrastructures.Domain.Models.Service()
                {
                    Vehicle = "Wash and Wax Deluxe",
                    Description = "Large",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    Id = Guid.Parse("d913bb7c-2a68-484e-a197-ab199add60d0"),
                    Price = 539,
                    ServiceType = Infrastructures.Domain.Enums.ServiceType.Wash,

                });


                this._context.Services.Add(
              new Infrastructures.Domain.Models.Service()
              {
                  Vehicle = "Mr. Sponge's Economy Wash",
                  Description = "Extra" + " " + "Large",
                  CreatedAt = DateTime.UtcNow,
                  UpdatedAt = DateTime.UtcNow,
                  Id = Guid.Parse("bff598dd-79c7-4dd1-a0c1-f7d46f3984e9"),
                  Price = 189,
                  ServiceType = Infrastructures.Domain.Enums.ServiceType.Wash,

              });

                this._context.Services.Add(
                 new Infrastructures.Domain.Models.Service()
                 {
                     Vehicle = "Mr. Sponge’s Classic Swag " + " " + "(w/ vacuum)",
                     Description = "Extra" + " " + "Large",
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow,
                     Id = Guid.Parse("0d472148-341e-4121-8ffb-73904db002c3"),
                     Price = 219,
                     ServiceType = Infrastructures.Domain.Enums.ServiceType.Wash,

                 });

                this._context.Services.Add(
                new Infrastructures.Domain.Models.Service()
                {
                    Vehicle = "Wash and Wax Deluxe",
                    Description = "Extra" + " " + "Large",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    Id = Guid.Parse("4fffb666-2ccd-4750-878b-a84350be46bd"),
                    Price = 559,
                    ServiceType = Infrastructures.Domain.Enums.ServiceType.Wash,

                });
                //No images in top
                //Auto-Package-Wash-Services
                this._context.Services.Add(
                  new Infrastructures.Domain.Models.Service()
                  {
                      Vehicle = "MICRO" + " " +"(Small)",
                      Description = "Pressurised Body Wash," + "Foam Cannon Wash(Synthetic Wax & Conditioner)" + ",   Air Blow Dry" + ", Interior Vacuum and Cleaning" + ",  Glass Cleaning" + ",   Tire and Wheel Shine" + ", Engine Wipe",
                      CreatedAt = DateTime.UtcNow,
                      UpdatedAt = DateTime.UtcNow,
                      Id = Guid.Parse("77e2ced2-05c5-4cb5-a5c3-feb92f2f5f10"),
                      Price = 260,
                      ServiceType = Infrastructures.Domain.Enums.ServiceType.Wash,
                      Thumbnail = true,
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
                          Thumbnail = true,
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
                         Thumbnail = true,
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
                       Thumbnail = true,
                   });


                //Auto-Package-Waterless-Services
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
                       Thumbnail = true,
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
                     Thumbnail = true,
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
                    Thumbnail = true,
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
                      Thumbnail = true,
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
                   Thumbnail = true,
               });


                //Auto-Package-Shine-Services
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
                          Thumbnail = true,
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
                         Thumbnail = true,
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
                      Thumbnail = true,
                  });

                //Auto-Package-Signature-Services
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
                    ServiceType = Infrastructures.Domain.Enums.ServiceType.Signature,
                    Thumbnail = true,
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
                  ServiceType = Infrastructures.Domain.Enums.ServiceType.Signature,
                  Thumbnail = true,
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
                 ServiceType = Infrastructures.Domain.Enums.ServiceType.Signature,
                 Thumbnail = true,
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
                 ServiceType = Infrastructures.Domain.Enums.ServiceType.Signature,
                 Thumbnail = true,
             });
            }





            #endregion


            #region Booking
            if (this._context.Bookings.Count() < 1)
            {

                this._context.Bookings.Add(
                           new Infrastructures.Domain.Models.Booking()
                           {
                               Id = Guid.Parse("95729086-13dd-4e93-b01e-d1834b4b32be"),
                               BookingAddress = "Dinalupihan,Bataan",
                               UserId = Guid.Parse("1bb688b3-3228-48c5-80bb-35050994a8fa"),
                               Title = "MICRO" + "" + "(Small)",
                               ServiceType = Infrastructures.Domain.Enums.ServiceType.Wash,
                               Description = "Pressurised Body Wash," + "Foam Cannon Wash(Synthetic Wax & Conditioner)" + ",   Air Blow Dry" + ", Interior Vacuum and Cleaning" + ",  Glass Cleaning" + ",   Tire and Wheel Shine" + ", Engine Wipe",
                               Email = "arwintolentino@gmail.com",
                               UserName = "Arwin Tolentino",
                               Price = 260,
                               BookingStatus = Infrastructures.Domain.Enums.BookingStatus.Pending,
                               PaymentType = Infrastructures.Domain.Enums.PaymentType.Unpaid,
                               PhoneNumber = "09123456789",
                               CreatedAt = DateTime.UtcNow,
                               UpdatedAt = DateTime.UtcNow,
                               Time = "3:45 PM",
                               ServiceId = Guid.Parse("77e2ced2-05c5-4cb5-a5c3-feb92f2f5f10"),

                           });


                this._context.Bookings.Add(
                           new Infrastructures.Domain.Models.Booking()
                           {
                               Id = Guid.Parse("a17cc642-4616-44d3-a5ee-f1ade9442d38"),
                               BookingAddress = "Dinalupihan,Bataan",
                               UserId = Guid.Parse("a265c0a2-5b7c-4d29-bdf1-f95780d820df"),
                               Title = "SEDAN" + "" + "(Small)",
                               ServiceType = Infrastructures.Domain.Enums.ServiceType.Wash,
                               Description = "Pressurised Body Wash," + "Foam Cannon Wash(Synthetic Wax & Conditioner)" + ",   Air Blow Dry" + ", Interior Vacuum and Cleaning" + ",  Glass Cleaning" + ",   Tire and Wheel Shine" + ", Engine Wipe",
                               Email = "larichmorales@gmail.com",
                               UserName = "Larich Morales",
                               Price = 260,
                               BookingStatus = Infrastructures.Domain.Enums.BookingStatus.Pending,
                               PaymentType = Infrastructures.Domain.Enums.PaymentType.Unpaid,
                               PhoneNumber = "09123456789",
                               CreatedAt = DateTime.UtcNow,
                               UpdatedAt = DateTime.UtcNow,
                               Time = "3:45 PM",
                               ServiceId = Guid.Parse("bb8a61ba-a5bf-4026-9c86-0d7575d0df9d"),
                          





                           });


                this._context.Bookings.Add(
                           new Infrastructures.Domain.Models.Booking()
                           {
                               Id = Guid.Parse("dffa8f94-fd53-443c-8f3d-3cad56ce547a"),
                               BookingAddress = "Dinalupihan,Bataan",
                               UserId = Guid.Parse("f0c0f3ab-7cb6-48fd-abe8-45dc2d5c1bf1"),
                               Title = "HATCHBACK" + "" + "(Small)",
                               ServiceType = Infrastructures.Domain.Enums.ServiceType.Wash,
                               Description = "Pressurised Body Wash," + "Foam Cannon Wash(Synthetic Wax & Conditioner)" + ",   Air Blow Dry" + ", Interior Vacuum and Cleaning" + ",  Glass Cleaning" + ",   Tire and Wheel Shine" + ", Engine Wipe",
                                Email = "user1@gmail.com",
                               UserName = "User Tester",
                               Price = 240,
                               BookingStatus = Infrastructures.Domain.Enums.BookingStatus.Pending,
                               PaymentType = Infrastructures.Domain.Enums.PaymentType.Unpaid,
                               PhoneNumber = "",
                               CreatedAt = DateTime.UtcNow,
                               UpdatedAt = DateTime.UtcNow,
                               Time = "3:45 PM",
                               ServiceId = Guid.Parse("4b1eb8db-e4ff-44e0-93d4-18b841fde950"),


                           });

            }
            #endregion

            //foreach (Booking booking in _context.Bookings)
            //{
            //    var bookingDataBase = this._context.Bookings.Where(b =>
            //        b.ServiceId == booking.ServiceId &&
            //        b.CostumerId == booking.CostumerId).SingleOrDefault();

            //    if(bookingDataBase == null)
            //    {
            //        _context.Bookings.Add(booking);
            //    }
            //}

            this._context.SaveChanges();
            return Ok("Ok");
        }
    }
}
