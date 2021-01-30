namespace Knaifl.MsFsRemote.SimClient
{
    public static class HornerScheme
    {
        public static uint DecToBcd(uint decNumber)
        {
            return Calculation(decNumber, 10, 0x10);
        }

        public static uint BcdToDec(uint bcdNumber)
        {
            return Calculation(bcdNumber, 0x10, 10);
        }

        private static uint Calculation(uint number, uint divider, uint factor)
        {
            uint remainder = 0, quotient = 0, result = 0;
            remainder = number % divider;
            quotient = number / divider;
            if (!(quotient == 0 && remainder == 0))
            {
                result += Calculation(quotient, divider, factor) * factor + remainder;
            }
            return result;
        }
    }
}
