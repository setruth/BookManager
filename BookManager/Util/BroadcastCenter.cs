using System;
using System.Collections.Generic;

namespace BookManager.Util
{
    public static class BroadcastCenter
    {
        private static readonly Dictionary<Type, Delegate> _subscribers = new Dictionary<Type, Delegate>();

        public static void Subscribe<T>(Action<T> action)
        {
            var broadcastType = typeof(T);
            if (_subscribers.ContainsKey(broadcastType))
            {
                _subscribers[broadcastType] = Delegate.Combine(_subscribers[broadcastType], action);
            }
            else
            {
                _subscribers[broadcastType] = action;
            }
        }

        public static void RemoveSubscribe<T>(Action<T> action)
        {
            var broadcastType = typeof(T);
            var actions = _subscribers[broadcastType];
            if (actions!=null)
            {
                _subscribers[broadcastType]= Delegate.Remove(actions, action);                
            }
        }

        public static void Publish<T>(T broadcast)
        {
            var broadcastType = typeof(T);
            var actions = _subscribers[broadcastType] as Action<T>;
            actions?.Invoke(broadcast);
        }
    }
}