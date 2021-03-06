﻿using System;


// Placed in System namespace since including a reference to Magyar is enough to indicate a desire to use this functionality.
namespace System
{
    public static class Strings
    {
        public const string Asterix = "*";
        public const string Ellipsis = "...";
        public const string Empty = ""; // Constant, as opposed to String.Empty, which is static readonly. Constants can be used as default parameter values.
        public const string Space = " ";
        public const string Tab = "\t";
    }
}
