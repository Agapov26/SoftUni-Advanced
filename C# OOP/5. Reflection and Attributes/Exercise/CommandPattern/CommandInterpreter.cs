using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] parts = args.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string command = $"{parts[0]}Command";

            var commandArgs = parts.Skip(1).ToArray();
            var assmebly = Assembly.GetEntryAssembly();

            Type type = assmebly.GetTypes().FirstOrDefault(t => t.Name == command);

            if (type == null)
            {
                throw new ArgumentException("Invalid type!");
            }

            var instance =  (ICommand)Activator.CreateInstance(type);
            return instance?.Execute(commandArgs);
        }
    }
}
