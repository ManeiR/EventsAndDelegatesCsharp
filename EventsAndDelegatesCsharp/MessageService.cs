using System;
using System.Threading;

namespace EventsAndDelegatesCsharp
{
    public class MessageService
    {
        /// <summary>
        ///subscribes to publisher event
        /// </summary>
        /// <param name="source"></param>
        /// <param name="args"></param>
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageService : Sending a text message to " + args.Video.Title);
            Thread.Sleep(3000);
        }

    }
}
