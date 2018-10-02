﻿using System;

namespace Tyy996Utilities.Parser.Expression
{
    internal sealed class InvalidExpression : VauleExpression
    {
        public string Message { get { return (string)internalObject; } }
        public override Type GetValueType { get { return typeof(string); } }

        public InvalidExpression(string message)
        {
            internalObject = message;
        }
    }
}
