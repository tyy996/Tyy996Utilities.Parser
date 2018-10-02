using System;

namespace Tyy996Utilities.Parser.Expression
{
    public interface IOperatorExpression : IExpression
    {
        VauleExpression GetValue { get; }
        bool Process(IExpressionWalker walker);
    }
}
