using System;

namespace hetu.businesslogic
{
    public static class HetuValidator
    {
        public static bool isValidSSN(String ssn)
        {
            if (ssn.Length != 11)
            {
                return false;
            }
            return true;
        }
    }
}
