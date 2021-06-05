using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegatesCsharp
{
    public class Program
    {
        /// <summary>
        /// main entry point of the project
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            var video = new Video() {Title = "Manei Video" };
            var videoEncoder = new VideoEncoder(); // publisher

            var mailService = new MailService(); //Subscriber
            var messageService = new MessageService(); //Subscriber

            // to notify subscriber for the event through event handler +=
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}
