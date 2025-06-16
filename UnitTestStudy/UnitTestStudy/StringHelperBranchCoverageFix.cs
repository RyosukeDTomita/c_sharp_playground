using System;

namespace UnitTestStudy
{
    /**
    分岐網羅率(Branch Coverage)が高くなってもテストの品質が向上しない例
    両方の分岐（true/false）をテストしているが、WasLastStringLongの状態確認を忘れている
    **/
    public static class StringHelperBranchCoverageFix
    {
        public static bool WasLastStringLong { get; private set; }
        
        public static bool IsStringLong(string input)
        {
            if (input.Length > 5)
                return true;
            return false;
        }
    }
}