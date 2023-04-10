// ******************************************************************************
//  ©  Sebastiaan Dammann | damsteen.nl
//
//  File:           : INotificationSubscription.cs
//  Project         : RetroTime.Application
// ******************************************************************************

namespace RetroTime.Application.Notifications;

public interface INotificationSubscription<in TSubscriber> where TSubscriber : ISubscriber {
    void Subscribe(TSubscriber subscriber);

    void Unsubscribe(TSubscriber subscriber);
}
