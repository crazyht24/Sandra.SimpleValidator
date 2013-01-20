﻿namespace Sandra.SimpleValidator.Rules
{
    public class MinimumLength : IRule
    {
        private readonly int _length;

        public MinimumLength()
        {
            Message = "Field needs to be minimum length of ";
        }

        public MinimumLength(int length)
        {
            _length = length;
            Message += length;
        }

        public bool IsValid(object value)
        {
            return ((string) value).Length >= _length;
        }

        public string Message { get; set; }

        public IRule WithMessage(string message)
        {
            Message = message;

            return this;
        }
    }
}