using System;

namespace FuelScoreboard.Domain.Entities
{
    /// <summary>
    /// 加油紀錄
    /// </summary>
    public class FillUpLog
    {
        /// <summary>
        /// 時間
        /// </summary>
        public DateTime? EventDate { get; set; }

        /// <summary>
        /// 總里程
        /// </summary>
        public decimal? Odometer { get; set; }

        /// <summary>
        /// 公升
        /// </summary>
        public decimal? Liter { get; set; }

        /// <summary>
        /// 行駛里程
        /// </summary>
        public decimal? Meter { get; set; }

        /// <summary>
        /// 金額
        /// </summary>
        public decimal? Money { get; set; }

        /// <summary>
        /// 公里/公升
        /// </summary>
        public decimal? KmPerLiter 
        { 
            get 
            {
                if (this.Meter.HasValue == false)
                    return null;

                if (this.Liter.HasValue == false)
                    return null;

                return Math.Round(this.Meter.Value / this.Liter.Value, 2);
            } 
        }
    }
}
