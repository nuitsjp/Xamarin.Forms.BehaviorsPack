using System;

namespace XamarinForms.Behaviors
{
    public interface IInteractionRequest<TEventArgs> where TEventArgs : EventArgs
    {
        event EventHandler<TEventArgs> Requested;
    }

    public interface IInteractionRequest : IInteractionRequest<EventArgs>
    {
        
    }
}
