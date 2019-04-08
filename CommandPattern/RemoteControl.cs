using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class RemoteControl
    {
        private Lamp _lamp;

        public RemoteControl(Lamp lamp) {
            this._lamp = lamp;
        }

        public void ClickOn() {
            var cmd= new CommandTurnOnLamp(this._lamp);
            cmd.execute();
        }

        public void ClickOff()
        {
            var cmd = new CommandTurnOffLamp(this._lamp);
            cmd.execute();
        }
    }
}
