using System;
using System.Collections.Generic;
using Tyy996Utilities.Parser.Expression;

namespace Tyy996Utilities.Parser
{
    public class ExpressionDictionary : Dictionary<string, Func<IOperatorExpression>>
    {
        public static ExpressionDictionary Standard
        {
            get
            {
                return new ExpressionDictionary()
                {
                    { "+", () => new AddExpression() },
                    { "-", () => new SubtractExpression() },
                    { "*", () => new MultiplyExpression() },
                    { "/", () => new DivideExpression() },
                    { "print", () => new PrintExpression() },
                };

            }
        }
    }
}
