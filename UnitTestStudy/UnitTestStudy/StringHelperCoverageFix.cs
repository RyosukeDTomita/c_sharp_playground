using System;

namespace UnitTestStudy
{
    /**
    テストの品質は変わらないのにCoverageが良くなってしまう例
    **/
    public static class StringHelperCoverageFix
    {
        public static bool IsStringLong(string input)
        {
            // if (input.Length > 5)
            //     return true;
            // return false;
            return input.Length > 5 ? true : false;
        }
    }
}