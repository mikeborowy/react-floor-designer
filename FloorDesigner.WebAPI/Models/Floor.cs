using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FloorDesigner.WebAPI.Models
{
    public class Floor
    {
        public Floor() {

            Rooms = new List<Room>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Room> Rooms { get; set; }

    }
}