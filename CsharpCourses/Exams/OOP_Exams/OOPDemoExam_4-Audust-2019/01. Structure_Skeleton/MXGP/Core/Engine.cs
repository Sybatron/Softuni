using MXGP.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MXGP.Core
{
    public class Engine : IEngine
    {
        private IChampionshipController championshipController;

        public Engine()
        {
            championshipController = new ChampionshipController();
        }

        public void Run()
        {
            while (true)
            {
                var inputInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var command = inputInfo[0];

                if (command == "CreateRider")
                {
                    var name = inputInfo[1];

                    championshipController.CreateRider(name);
                }
                //TODO All commands
                if (command == "End")
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
