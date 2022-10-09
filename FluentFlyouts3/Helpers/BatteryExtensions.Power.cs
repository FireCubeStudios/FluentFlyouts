﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Power;
using Windows.System.Power;

namespace FluentFlyouts3.Helpers
{
    public static partial class BatteryExtensions
    {
        /// <summary>
        /// Gets power status and usage level in text.
        /// </summary>
        /// <param name="report">A BatteryReport object.</param>
        /// <returns>Returns text representing power usage, or Charging.</returns>
        public static string GetPowerUsageText(this BatteryReport report) => report.Status != BatteryStatus.Charging ? CalculateUsage(report) : "Charging";

        /// <summary>
        /// Converts BatterReport info into text to represent power consumption.
        /// </summary>
        /// <param name="report">A BatteryReport object.</param>
        /// <returns>Returns text representing power usage./returns>
        public static string CalculateUsage(this BatteryReport report)
        {
            return ((int)Math.Abs((decimal)report.ChargeRateInMilliwatts)) switch
            {
                int i when i > 0 && i <= 8000 => "Very low usage",
                int i when i > 8000 && i <= 12000 => "Low usage",
                int i when i > 12000 && i <= 16000 => "Medium usage",
                int i when i > 16000 && i <= 20000 => "High usage",
                _ => "Very high usage"
            };
        }
    }
}
