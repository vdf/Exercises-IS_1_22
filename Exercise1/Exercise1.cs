using System;

namespace Exercise1
{
    public class Engine
    {
        private const int StateStopped = 1;
        private const int StateStarted = 2;
        public int engineState;

        public void Start(int engineState)
        {
            Console.Out.WriteLine( "Start" );
            engineState = StateStopped;
        }

        public void Stop(int engineState)
        {
            Console.Out.WriteLine( "Stop" );
            engineState = StateStarted;
        }

        public String GetState()
        {
            String state = null;

            if (engineState == StateStopped)
                state = "STOPPED";
            else if (engineState == StateStarted)
                state = "STARTED";

            return state;
        }
    }
}
