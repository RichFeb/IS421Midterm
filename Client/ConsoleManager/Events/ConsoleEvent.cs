using System;

namespace IS421Midterm.Client.ConsoleManager.Events
{
    public class ConsoleEvent
    {
        public event EventHandler<ConsoleEventArgs> UserInput;

        public event EventHandler LogMessage;

        public void GetUserStringInput(string input)
        {
            OnUserInput(input);
        }

        protected virtual void OnUserInput(string input)
        {
            UserInput?.Invoke(this, new ConsoleEventArgs() { StringInput = input });
        }

        public void GetUserNumericInput(double input)
        {
            OnUserInput(input);
        }

        protected virtual void OnUserInput(double input)
        {
            UserInput?.Invoke(this, new ConsoleEventArgs() { NumericInput = input });
        }

        public void GetUserAction(Func<double, double, double> input)
        {
            OnUserInput(input);
        }

        protected virtual void OnUserInput(Func<double, double, double> input)
        {
            UserInput?.Invoke(this, new ConsoleEventArgs() { OperationInput = input });
        }

        public void Log()
        {
            OnLog();
        }
        protected virtual void OnLog()
        {
            LogMessage?.Invoke(this, EventArgs.Empty);

        }


    }
}
