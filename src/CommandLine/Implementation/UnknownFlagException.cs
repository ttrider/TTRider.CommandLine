using System;

namespace TTRider.FluidCommandLine.Implementation
{
    public class UnknownFlagException : Exception
    {
        public string Parameter { get; private set; }

        public UnknownFlagException(string parameter)
        {
            this.Parameter = parameter;
        }
    }

    public class MissingCommandException : Exception
    {

        public MissingCommandException()
        {
        }
    }
}