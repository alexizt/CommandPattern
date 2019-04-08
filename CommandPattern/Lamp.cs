using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class Lamp // This is the Receiver Class
    {
        private LampStateEnum _LampState;

        public LampStateEnum LampState
        {
            get { return _LampState; }
        }

        public Lamp() {
            this._LampState = LampStateEnum.Off;
        }

        public void TurnOn() {
            this._LampState = LampStateEnum.On;
        }

        public void TurnOff()
        {
            this._LampState = LampStateEnum.Off;
        }

        public string Description() {
            return "The Lamp is " + this._LampState.ToString();
        }

        public enum LampStateEnum {
            On=1,
            Off=2
        }

    }
}
