using System;
using System.Collections.Generic;
using System.Text;

namespace IS421Midterm.Client.Events
{
    public class ConsoleEventAggregator
    {
        public ConsoleEvent consoleEvent = new ConsoleEvent();
        ProgramInit programInit = new ProgramInit();
        EnterOperation enterOperation = new EnterOperation();
        EnterNumericInput enterNumericInput = new EnterNumericInput();
        EnterMenuOption enterMenuOption = new EnterMenuOption();
        DivideByZero divideByZero = new DivideByZero();

        public void RegisterProgramInit()
        {
            consoleEvent.LogMessage += programInit.OnLog;
        }

        public void UnregisterProgramInit()
        {
            consoleEvent.LogMessage -= programInit.OnLog;
        }

        public void RegisterEnterOperation()
        {
            consoleEvent.LogMessage += enterOperation.OnLog;
        }

        public void UnregisterEnterOperation()
        {
            consoleEvent.LogMessage -= enterOperation.OnLog;
        }

        public void RegisterEnterNumericInput()
        {
            consoleEvent.LogMessage += enterNumericInput.OnLog;
        }

        public void UnregisterEnterNumericInput()
        {
            consoleEvent.LogMessage -= enterNumericInput.OnLog;
        }

        public void RegisterEnterMenuOption()
        {
            consoleEvent.LogMessage += enterMenuOption.OnLog;
        }

        public void UnregisterEnterMenuOption()
        {
            consoleEvent.LogMessage -= enterMenuOption.OnLog;
        }

        public void RegisterDivideByZero()
        {
            consoleEvent.LogMessage += divideByZero.OnLog;
        }

        public void UnregisterDivideByZero()
        {
            consoleEvent.LogMessage -= divideByZero.OnLog;
        }
    }
}
