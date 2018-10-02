using System;

namespace Tyy996Utilities.Parser.Expression
{
    public class FormatExpression : RightExpression
    {
        protected override bool process(IExpressionWalker walker, VauleExpression right)
        {
            var stringValue = right as VauleExpression.StringVauleExpression;

            if (stringValue == null)
                return walker.Fail("Internal parsing error: Expected value for run command to be a string.");

            return true;
        }
    }
}
