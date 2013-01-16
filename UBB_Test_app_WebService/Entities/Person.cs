using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerServiceApp.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public string FIO { get; set; }
    }
}