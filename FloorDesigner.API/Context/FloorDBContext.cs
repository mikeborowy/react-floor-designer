using FloorDesigner.API.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FloorDesigner.API.Context
{
    public class FloorDBContext:DbContext
    {
        public DbSet<Floor> Floors { get; set; }
        public DbSet<Room> Rooms { get; set; }
    }
}