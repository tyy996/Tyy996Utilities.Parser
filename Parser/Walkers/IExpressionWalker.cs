using System;
using System.Collections.Generic;
using Tyy996Utilities.Parser.Expression;

namespace Tyy996Utilities.Parser
{
    public interface IExpressionWalker : IDisposable
    {
        ExternalVariables ParserVariables { get; }
        Stack<VauleExpression> ValueStack { get; }
        Queue<VauleExpression> Results { get; }
        bool HasFailed { get; }

        bool StepThrough();
        bool Step();
        bool Step(out IExpression result);
        bool Fail(string message);
        void Message(string message);
    }
}
