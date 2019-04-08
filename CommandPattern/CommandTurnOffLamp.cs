using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class CommandTurnOffLamp:ICommand //Concrete command
    {
        private Lamp _lamp;

        public CommandTurnOffLamp(Lamp lamp)
        {
            this._lamp = lamp;
        }

        public void execute()
        {
            this._lamp.TurnOff();
        }
    }
}
