namespace UnitTests;

[TestClass]
public sealed class L_020_ValidParenthese
{
    [TestMethod]
    public void Test_ValidParenthese()
    {
        var solution = new LeetCode.L020_ValidParenthese.Solution();
        Assert.IsTrue(solution.IsValid("(6,5)-(14,6)"));
        Assert.IsTrue(solution.IsValid("()"));
        Assert.IsTrue(solution.IsValid("()[]{}"));
        Assert.IsFalse(solution.IsValid("(]"));
        Assert.IsTrue(solution.IsValid("([])"));
        Assert.IsFalse(solution.IsValid("([)]"));
    }
}
