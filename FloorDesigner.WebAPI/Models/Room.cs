using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FloorDesigner.WebAPI.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int XPos { get; set; }
        public int YPos { get; set; }
        public int Rotation { get; set; }
        public string Name { get; set; }
        public int FloorId { get; set; }

        //[ForeignKey("FloorId")]
        //public Floor Floor { get; set; } 
    }
}