using System;

namespace UnitTestStudy
{
    public static class StringHelper
    {
        public static bool IsStringLong(string input)
        {
            if (input.Length > 5)
                return true;

            return false;
        }
    }
}