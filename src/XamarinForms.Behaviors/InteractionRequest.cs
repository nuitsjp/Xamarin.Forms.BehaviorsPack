using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinForms.Behaviors
{
    public class InteractionRequest : IInteractionRequest
    {
        public event EventHandler<EventArgs> Requested;

        public void Request()
        {
            Request(this);
        }

        public void Request(object sender)
        {
            Requested?.Invoke(sender, EventArgs.Empty);
        }
    }
}
