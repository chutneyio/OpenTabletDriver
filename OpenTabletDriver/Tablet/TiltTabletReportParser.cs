﻿using OpenTabletDriver.Plugin.Tablet;

namespace OpenTabletDriver.Tablet
{
    public class TiltTabletReportParser : IReportParser<IDeviceReport>
    {
        public virtual IDeviceReport Parse(byte[] data)
        {
            return new TiltTabletReport(data);
        }
    }
}