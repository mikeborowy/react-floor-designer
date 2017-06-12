using FloorDesigner.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FloorDesigner.WebAPI.Context
{
    public class FloorDBContext:DbContext
    {
        public DbSet<Floor> Floors { get; set; }
        public DbSet<Room> Rooms { get; set; }
    }
}