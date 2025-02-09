using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventEase.Models
{
    public class EventModel
    {
        public int Id { get; set; }
        public string? Name { get; set; } // La proprietà Name con nullable
    }
}