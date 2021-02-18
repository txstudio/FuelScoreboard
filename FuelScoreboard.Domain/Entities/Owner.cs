using System;
using System.Collections.Generic;

namespace FuelScoreboard.Domain.Entities
{
    /// <summary>
    /// 擁有者
    /// </summary>
    public class Owner
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime? Birth { get; set; }

        public IList<Vehicle> Vehicles { get; private set; }
    }
}
