using FloorDesigner.API.Context;
using FloorDesigner.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FloorDesigner.API.Repository
{
    public class FloorRepository
    {
        private FloorDBContext db = new FloorDBContext();

        public List<Floor> Get() {

            return db.Floors.ToList();
        }

        public void Insert(Floor floor)
        {
            db.Floors.Add(floor);
            db.SaveChanges();
        }

        public void Update(Floor floor)
        {
            Floor floorToUpdate = db
                .Floors
                .SingleOrDefault(x => x.Id == floor.Id);

            floorToUpdate.Id = floor.Id;
            floorToUpdate.Name = floor.Name;
            floorToUpdate.Rooms= floor.Rooms;

            db.SaveChanges();
        }

        public void Delete(Floor floor)
        {
            Floor floorToDelete = db
                .Floors
                .SingleOrDefault(x => x.Id == floor.Id);

            db.Floors.Remove(floorToDelete);
            db.SaveChanges();
        }
    }
}