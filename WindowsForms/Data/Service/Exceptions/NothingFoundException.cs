using System;

namespace WindowsForms.Data.Service.Exceptions; 

public class NothingFoundException : Exception {
    public NothingFoundException(string message) : base(message) { }
}