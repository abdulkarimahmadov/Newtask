﻿using System;

public class CapacityLimitException : Exception
{
    public CapacityLimitException(string message) : base(message) { }
}
