using System;

namespace WindowsForms.Data.Service.Exceptions; 

public class TokenExpiredException : Exception {
    public TokenExpiredException(string message) : base(message) { }
}