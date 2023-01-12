using System;

namespace WindowsForms.Data.Service.Exceptions; 

public class ServerErrorException : Exception {
    public ServerErrorException(string message) : base(message) { }
}