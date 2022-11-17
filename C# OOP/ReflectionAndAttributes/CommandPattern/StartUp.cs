﻿using CommandPattern.Core.Contracts;
using CommandPattern.Core;
using CommandPattern.Utilities;
using CommandPattern.Utilities.Contracts;

namespace CommandPattern
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            ICommandInterpreter command = new CommandInterpreter();
            IEngine engine = new Engine(command);
            engine.Run();
        }
    }
}
