using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace OrderOnlineFood
{
    public enum SendEmail
    {
        Yes,
        No
    }
    public class OperationResult
    {

        private readonly SendEmail _sendEmail;
        public string Greetings { get; set; }
        public OperationResult(SendEmail sendEmail,string greetings)
        {
            _sendEmail = sendEmail;
             Greetings = greetings ?? throw new ArgumentNullException(nameof(greetings));
        }

        public override string ToString()
        {
            return $"{_sendEmail} -- with message -- {Greetings}";
        }

        
    }

}
