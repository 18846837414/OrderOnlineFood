using System;

namespace OrderOnlineFood
{
    public class EmailGreeter : IEmailProvider
    {
        private readonly IGreeter _greeter;


        public EmailGreeter(IGreeter greeter)
        {
            _greeter = greeter ?? throw new ArgumentNullException(nameof(greeter));

        }

        public OperationResult SendEmail()
        {

            string message = _greeter.GetMessageToPrint();
            OperationResult op = new OperationResult(sendEmail: OrderOnlineFood.SendEmail.Yes, greetings: message);
            return op;
        }
    }
}
