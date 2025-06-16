using Xunit;

namespace UnitTestStudy.Tests
{
    /**
    分岐網羅率(Branch Coverage)が高くなってもテストの品質が向上しない例
    両方の分岐（true/false）をテストしているが、副作用（WasLastStringLong）の確認を忘れている
    **/
    public class StringHelperBranchCoverageFixTests
    {
        [Fact]
        public void Test_IsStringLong_ShortString()
        {
            // 短い文字列をテスト（falseの分岐）
            bool result = StringHelperBranchCoverageFix.IsStringLong("abc");
            bool result2 = StringHelperBranchCoverageFix.IsStringLong("abcdef");
            
            Assert.Equal(false, result);
            // 問題: result2の値を確認していない。
        }
    }
}