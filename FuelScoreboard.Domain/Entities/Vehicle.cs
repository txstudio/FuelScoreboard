using System.Collections.Generic;

namespace FuelScoreboard.Domain.Entities
{
    /// <summary>
    /// 車輛
    /// </summary>
    public class Vehicle
    {
        public Vehicle()
        {
            this.FillUpLogs = new List<FillUpLog>();
        }

        /// <summary>
        /// 車牌號碼
        /// </summary>
        public string RegistrationPlate { get; set; }

        public string Note { get; set; }

        public IList<FillUpLog> FillUpLogs { get; private set; }
    }
}
