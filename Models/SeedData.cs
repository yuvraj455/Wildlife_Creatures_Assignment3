using Microsoft.DotNet.Scaffolding.Shared.CodeModifier.CodeChange;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using WildlifeCreatures_Assignment3.Data;

namespace WildlifeCreatures_Assignment3.Models
{
    // Class responsible for seeding initial data into the database
    public class SeedData
    {
        // Method to initialize the seeding process
        public static void Initialize(IServiceProvider serviceProvider)
        {
            // Using statement ensures proper disposal of resources
            using (var context = new WildlifeCreatures_Assignment3Context(
                serviceProvider.GetRequiredService<DbContextOptions<WildlifeCreatures_Assignment3Context>>()))
            {
                // Check if data already exists
                if (context.WildlifeModel.Any())
                {
                    return;   // Database has been seeded
                }

                
                context.WildlifeModel.AddRange(

                    // Adding sample wildlife creatures
                    new WildlifeModel
                    {
                        Name = "Elephant",
                        Weight = 6000.0, // in kg
                        PhotoUrl = "https://cdn.britannica.com/02/152302-050-1A984FCB/African-savanna-elephant.jpg",
                        Habitat = "Forest, Grassland",
                        CurrentPopulation = 415000
                    },
                    new WildlifeModel
                    {
                        Name = "Lion",
                        Weight = 190.0, // in kg
                        PhotoUrl = "https://img.freepik.com/free-photo/view-wild-lion-nature_23-2150460851.jpg",
                        Habitat = "Savannah",
                        CurrentPopulation = 20000
                    },
                    new WildlifeModel
                    {
                        Name = "Tiger",
                        Weight = 300.0, // in kg
                        PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/81/2012_Suedchinesischer_Tiger.JPG/2560px-2012_Suedchinesischer_Tiger.JPG",
                        Habitat = "Forest",
                        CurrentPopulation = 3900
                    },
                    new WildlifeModel
                    {
                        Name = "Giraffe",
                        Weight = 1600.0, // in kg
                        PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/4/44/Giraffa_camelopardalis_reticulata_01%2C_flip.jpg",
                        Habitat = "Savannah",
                        CurrentPopulation = 97000
                    },
                    new WildlifeModel
                    {
                        Name = "Grizzly Bear",
                        Weight = 340.0, // in kg
                        PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/a/ab/Grizzly_Bear_%286968121996%29.jpg",
                        Habitat = "Forest, Mountain",
                        CurrentPopulation = 55000
                    },
                    new WildlifeModel
                    {
                        Name = "Hippopotamus",
                        Weight = 1500.0, // in kg
                        PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f2/Portrait_Hippopotamus_in_the_water.jpg/800px-Portrait_Hippopotamus_in_the_water.jpg",
                        Habitat = "River",
                        CurrentPopulation = 130000
                    },
                    new WildlifeModel
                    {
                        Name = "Polar Bear",
                        Weight = 450.0, // in kg
                        PhotoUrl = "https://i.natgeofe.com/k/55256f3f-2cf1-4b93-9d95-a13b0faa30a6/Mom-and-Babies_Polar-Bear_KIDS_0223-crop_3x2.jpg",
                        Habitat = "Arctic",
                        CurrentPopulation = 22000
                    },
                    new WildlifeModel
                    {
                        Name = "Kangaroo",
                        Weight = 90.0, // in kg
                        PhotoUrl = "https://i.natgeofe.com/k/aa4c480f-89ec-4c21-97c3-4348a9c310bf/kangaroo-joey.jpg",
                        Habitat = "Grassland",
                        CurrentPopulation = 34000000
                    },
                    new WildlifeModel
                    {
                        Name = "Zebra",
                        Weight = 400.0, // in kg
                        PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/9/96/Common_zebra_1.jpg",
                        Habitat = "Grassland",
                        CurrentPopulation = 500000
                    },
                    new WildlifeModel
                    {
                        Name = "Gorilla",
                        Weight = 195.0, // in kg
                        PhotoUrl = "https://www.pbs.org/wnet/nature/files/2021/07/amy-reed-XB5E4D-Ipco-unsplash-scaled-e1627330380270.jpg",
                        Habitat = "Forest",
                        CurrentPopulation = 98000
                    },
                    new WildlifeModel
                    {
                        Name = "Panda",
                        Weight = 120.0, // in kg
                        PhotoUrl = "https://i.natgeofe.com/k/75ac774d-e6c7-44fa-b787-d0e20742f797/giant-panda-eating_4x3.jpg",
                        Habitat = "Forest",
                        CurrentPopulation = 1864
                    },
                    new WildlifeModel
                    {
                        Name = "Penguin",
                        Weight = 15.0, // in kg
                        PhotoUrl = "https://nzbirdsonline.org.nz/sites/all/files/2X2A1697%20King%20Penguin%20bol.jpg",
                        Habitat = "Antarctic",
                        CurrentPopulation = 12000000
                    },
                    new WildlifeModel
                    {
                        Name = "Rhino",
                        Weight = 2300.0, // in kg
                        PhotoUrl = "https://d1jyxxz9imt9yb.cloudfront.net/medialib/3641/image/s768x1300/AdobeStock_456205385_420075_reduced.jpg",
                        Habitat = "Grassland",
                        CurrentPopulation = 29000
                    },
                    new WildlifeModel
                    {
                        Name = "Wolf",
                        Weight = 45.0, // in kg
                        PhotoUrl = "https://i.natgeofe.com/k/093c14b4-978e-41f7-b1aa-3aff5d1c608a/gray-wolf-closeup_4x3.jpg",
                        Habitat = "Forest, Tundra",
                        CurrentPopulation = 300000
                    },
                    new WildlifeModel
                    {
                        Name = "Eagle",
                        Weight = 4.0, // in kg
                        PhotoUrl = "https://images.rawpixel.com/image_800/cHJpdmF0ZS9sci9pbWFnZXMvd2Vic2l0ZS8yMDIzLTA5L3Jhd3BpeGVsX29mZmljZV8zM19hbWVyaWNhbl9iYWxkX2VhZ2xlX2h1bnRpbmdfYXRfbGFrZV9pc29sYXRlX180MDg2MWQ2Ny0yNzcyLTRkNWMtYmVjNC1hNzUzNTE2MTg3YTBfMS5qcGc.jpg",
                        Habitat = "Mountains",
                        CurrentPopulation = 250000
                    }

                );
                // Save changes to the database
                context.SaveChanges();
            }
        }
    }
}
