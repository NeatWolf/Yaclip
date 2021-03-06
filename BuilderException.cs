﻿using System;

namespace Yaclip
{
    public class BuilderException : Exception
    {
        public BuilderException() : base()
        {
        }

        public BuilderException(string message) : base(message)
        {
        }

        public BuilderException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
