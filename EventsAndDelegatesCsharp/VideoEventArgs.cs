using System;

namespace EventsAndDelegatesCsharp
{
    /// <summary>
    /// class to pass data to subscriber through event handler
    /// </summary>
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
}
