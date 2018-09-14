﻿using PhotoFInd.Domain.Core.Events;
using System;
//using FluentValidation.Results;

namespace PhotoFind.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; private set; }
        //public ValidationResult ValidationResult { get; set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }

        public abstract bool IsValid();
    }
}
