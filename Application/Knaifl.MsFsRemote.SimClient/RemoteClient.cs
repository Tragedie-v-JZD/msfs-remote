using System;

namespace Knaifl.MsFsRemote.SimClient
{
    public sealed class RemoteClient : IDisposable
    {
        private readonly SimConnector simConnector;

        public RemoteClient(IntPtr windowHandle)
        {
            this.simConnector = new SimConnector(windowHandle);
        }

        public void SetHeading(uint heading)
        {
            this.simConnector.WriteEvent(SimEvents.HEADING_BUG_SET, heading);
        }

        public void SetCourse1(uint course)
        {
            this.simConnector.WriteEvent(SimEvents.VOR1_SET, course);
        }

        public void SetCourse2(uint course)
        {
            this.simConnector.WriteEvent(SimEvents.VOR2_SET, course);
        }

        public void SetAltitude(uint altitude)
        {
            this.simConnector.WriteEvent(SimEvents.AP_ALT_VAR_SET_ENGLISH, altitude);
        }

        public void SetSpeed(uint newSpeed)
        {
            this.simConnector.WriteEvent(SimEvents.AP_SPD_VAR_SET, newSpeed);
        }

        public void SetMachSpeed(uint newSpeed)
        {
            this.simConnector.WriteEvent(SimEvents.AP_MACH_VAR_SET, newSpeed);
        }

        public void SetNav1(uint frequency)
        {
            var bcdFrequency = HornerScheme.DecToBcd(frequency);

            this.simConnector.WriteEvent(SimEvents.NAV1_RADIO_SET, bcdFrequency);
        }

        public void SetNav2(uint frequency)
        {
            var bcdFrequency = HornerScheme.DecToBcd(frequency);

            this.simConnector.WriteEvent(SimEvents.NAV2_RADIO_SET, bcdFrequency);
        }

        public void SetAdf1(uint frequency)
        {
            frequency = frequency * 10000;
            var bcdFrequency = HornerScheme.DecToBcd(frequency);

            this.simConnector.WriteEvent(SimEvents.ADF_COMPLETE_SET, bcdFrequency);
        }

        public void SetAdf2(uint frequency)
        {
            frequency = frequency * 10000;
            var bcdFrequency = HornerScheme.DecToBcd(frequency);

            this.simConnector.WriteEvent(SimEvents.ADF2_COMPLETE_SET, bcdFrequency);
        }

        public void EnableAutopilot(bool mode)
        {
            if (mode == true)
            {
                this.simConnector.WriteEvent(SimEvents.AUTOPILOT_ON, 1);
            }
            else
            {
                this.simConnector.WriteEvent(SimEvents.AUTOPILOT_OFF, 0);
            }
        }

        public void EnableNav(bool mode)
        {
            if (mode == true)
            {
                this.simConnector.WriteEvent(SimEvents.AP_NAV1_HOLD_ON, 1);
            }
            else
            {
                this.simConnector.WriteEvent(SimEvents.AP_NAV1_HOLD_OFF, 0);
            }
        }

        public void EnableHdg(bool mode)
        {
            if (mode == true)
            {
                this.simConnector.WriteEvent(SimEvents.AP_HDG_HOLD_ON, 1);
            }
            else
            {
                this.simConnector.WriteEvent(SimEvents.AP_HDG_HOLD_OFF, 0);
            }
        }

        public void EnableApp(bool mode)
        {
            if (mode == true)
            {
                this.simConnector.WriteEvent(SimEvents.AP_APR_HOLD_ON, 1);
            }
            else
            {
                this.simConnector.WriteEvent(SimEvents.AP_APR_HOLD_OFF, 0);
            }
        }

        public void EnableFlc(bool mode)
        {
            if (mode == true)
            {
                this.simConnector.WriteEvent(SimEvents.FLIGHT_LEVEL_CHANGE_ON, 1);
            }
            else
            {
                this.simConnector.WriteEvent(SimEvents.FLIGHT_LEVEL_CHANGE_OFF, 0);
            }
        }

        public void EnableAlt(bool mode)
        {
            if (mode == true)
            {
                this.simConnector.WriteEvent(SimEvents.AP_ALT_HOLD_ON, 1);
            }
            else
            {
                this.simConnector.WriteEvent(SimEvents.AP_ALT_HOLD_OFF, 0);
            }
        }

        public void EnableYd(bool mode)
        {
            if (mode == true)
            {
                this.simConnector.WriteEvent(SimEvents.YAW_DAMPER_ON, 1);
            }
            else
            {
                this.simConnector.WriteEvent(SimEvents.YAW_DAMPER_OFF, 0);
            }
        }

        public void SwapNav1()
        {
            this.simConnector.WriteEvent(SimEvents.NAV1_RADIO_SWAP, 1);
        }

        public void SwapNav2()
        {
            this.simConnector.WriteEvent(SimEvents.NAV2_RADIO_SWAP, 1);
        }

        public void Dispose()
        {
            if (this.simConnector != null)
            {
                this.simConnector.Dispose();
            }
        }
    }
}
