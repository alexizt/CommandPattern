using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class CommandTurnOnLamp : ICommand //Concrete command
    {
        private Lamp _lamp;

        public CommandTurnOnLamp(Lamp lamp) {
            this._lamp = lamp;
        }

        public void execute()
        {
            this._lamp.TurnOn();
        }
    }
}
