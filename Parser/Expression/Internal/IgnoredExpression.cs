using System;

namespace Tyy996Utilities.Parser.Expression
{
    internal sealed class IgnoredExpression : IExpression
    {
        public ExpressionType Type { get { return ExpressionType.Invailed; } }
    }
}
