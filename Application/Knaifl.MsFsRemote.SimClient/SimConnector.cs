using System;
using System.Runtime.InteropServices;
using Microsoft.FlightSimulator.SimConnect;

namespace Knaifl.MsFsRemote.SimClient
{
    internal sealed class SimConnector : IDisposable
    {
        private SimConnect simConnect;

        public SimConnector(IntPtr windowHandle)
        {
            try
            {
                this.simConnect = new SimConnect("MSFS Remote", windowHandle, 0x402, null, 0);
                this.PrepareClientEvents();
            }
            catch (COMException ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {
            if (this.simConnect != null)
            {
                this.simConnect.Dispose();
                this.simConnect = null;
            }
        }

        public void WriteEvent(SimEvents actionEvent, uint data)
        {
            this.simConnect.TransmitClientEvent(0U, actionEvent, data, (Enum)Notifications.GROUP0, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
        }

        private string PrepareClientEvent(SimEvents simEvent)
        {
            return simEvent.ToString();
        }

        private void PrepareClientEvents()
        {
            foreach (SimEvents simEvent in Enum.GetValues(typeof(SimEvents)))
            {
                var simEventString = this.PrepareClientEvent(simEvent);
                this.simConnect.MapClientEventToSimEvent(simEvent, simEventString);
            }
        }
    }
}
