using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.BehavioralPatterns.Command
{
    public class Client
    {
        public static void Execute()
        {
            var garden = new Garden(5);
            var command1 = new PlantCommand(garden, "drzewo");
            var command2 = new RemoveCommand(garden, "drzewo");
            var command3 = new RemoveCommand(garden, "słonecznik");
            var command4 = new PlantCommand(garden, "słonecznik");

            var plantTreeButton = new CommandInvoker(command1);
            var removeTreeButton = new CommandInvoker(command2);
            var removeSunflowerButton = new CommandInvoker(command3);
            var plantSunflowerButton = new CommandInvoker(command4);

            Console.WriteLine(garden);
            plantTreeButton.Invoke();
            plantSunflowerButton.Invoke();
            plantSunflowerButton.Invoke();
            plantTreeButton.Invoke();
            plantTreeButton.Invoke();
            plantTreeButton.Invoke();
            removeTreeButton.Invoke();
            plantTreeButton.Invoke();
            Console.WriteLine(garden);

            CommandInvoker.Undo();
            CommandInvoker.Undo();
            CommandInvoker.Undo();
            CommandInvoker.Undo();
            CommandInvoker.Undo();
            CommandInvoker.Undo();
            CommandInvoker.Undo();
            CommandInvoker.Undo();

            Console.WriteLine(garden);
            removeTreeButton.Invoke();
            removeSunflowerButton.Invoke();
            Console.WriteLine(garden);


            CommandInvoker.Undo();
            CommandInvoker.Undo();
            Console.WriteLine(garden);

        }
    }
}
