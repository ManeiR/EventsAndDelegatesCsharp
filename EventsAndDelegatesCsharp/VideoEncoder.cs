using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsAndDelegatesCsharp
{

    /// <summary>
    /// Publisher that notifies or publishes
    /// to multiple subscriber when a video is encoded
    /// </summary>
    public class VideoEncoder
    {
         //1- Define a delegate:
         //      Contract / Agreement between the Publisher and subscriber
         //      determines signature of the method in subscriber
         //      will be called when publisher publishes an event
         //2- Define an event based on this delegate
         //3- Raise / Publish the event

        //No need to create a delegate if using .Net EventHandler

        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        //public event VideoEncodedEventHandler VideoEncoded;

        public event EventHandler<VideoEventArgs> VideoEncoded = delegate { };

       public void Encode(Video video)
       {
            Console.WriteLine("Encoding video.........");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
       }

        /// <summary>
        /// pointer method that notifies to subscriber
        /// </summary>
        /// <param name="video"></param>
        protected virtual void OnVideoEncoded(Video video)
        {
            if(VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video});
            }
        }
    }
}
