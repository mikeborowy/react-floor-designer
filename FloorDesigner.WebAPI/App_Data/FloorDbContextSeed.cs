using FloorDesigner.WebAPI.Context;
using FloorDesigner.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FloorDesigner.WebAPI.App_Data
{
    public class FloorDbContextSeed: DropCreateDatabaseIfModelChanges<FloorDBContext>
    {
        protected override void Seed(FloorDBContext context)
        {
            Floor f1 = new Floor()
            {
                Name = "Floor 1",
                Rooms = new List<Room>() {
                    new Room(){
                        Name = "Room 1",
                        Width = 2,
                        Height = 2,
                        XPos = 1,
                        YPos = 1,
                        Rotation = 0
                    },
                    new Room(){
                        Name = "Room 2",
                        Width = 2,
                        Height = 3,
                        XPos = 1,
                        YPos = 3,
                        Rotation = 0
                    },
                    new Room(){
                        Name = "Room 3",
                        Width = 4,
                        Height = 2,
                        XPos = 8,
                        YPos = 3,
                        Rotation = 0
                    }
                }
            };

            context.Floors.Add(f1);

            base.Seed(context);
        }
    }
}