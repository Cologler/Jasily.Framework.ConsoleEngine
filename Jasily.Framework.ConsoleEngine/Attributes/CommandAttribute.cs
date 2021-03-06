﻿using System;

namespace Jasily.Framework.ConsoleEngine.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public sealed class CommandAttribute : NameAttribute
    {
        public CommandAttribute(string commandName)
            : base(commandName)
        {
        }

        public CommandType CommandType { get; set; } = CommandType.Custom;
    }
}