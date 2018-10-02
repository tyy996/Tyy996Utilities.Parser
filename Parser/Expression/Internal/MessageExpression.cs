using System;

namespace Tyy996Utilities.Parser.Expression
{
    internal sealed class MessageExpression : VauleExpression
    {
        public string Message { get { return (string)internalObject; } }
        public override Type GetValueType { get { return typeof(string); } }

        public MessageExpression(string message)
        {
            internalObject = message;
        }
    }
}
