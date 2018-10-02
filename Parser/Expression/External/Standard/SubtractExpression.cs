using System;

namespace Tyy996Utilities.Parser.Expression
{
    public sealed class SubtractExpression : LeftRightExpression
    {
        protected override bool process(IExpressionWalker walker, VauleExpression left, VauleExpression right)
        {
            var leftNumber = left as VauleExpression.NumericVauleExpression;

            if (leftNumber == null)
            {
                walker.Fail("Internal parsing error: Expected value on the left to be a number.");
                return false;
            }

            var rightNumber = right as VauleExpression.NumericVauleExpression;

            if (rightNumber == null)
            {
                walker.Fail("Internal parsing error: Expected value on the right to be a number.");
                return false;
            }

            result = new VauleExpression.FloatVauleExpression(leftNumber.Value - rightNumber.Value);
            walker.ValueStack.Push(result);
            return true;
        }
    }
}
