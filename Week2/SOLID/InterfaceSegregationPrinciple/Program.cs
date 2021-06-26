using System;

namespace InterfaceSegregationPrinciple
{
    //Each function should have an interface according to its purpose.
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public interface IMessage
        {
            public string From { get; set; }
            public string To { get; set; }
            public string Body { get; set; }

            // public int Duration { get; set; }
            // public string ImageFormat { get; set; }
            // public byte[] SoundStream { get; set; }
            // void SaveImage();
        }

        public interface IVideoMessage : IMessage
        {
            public int Duration { get; set; }

        }

        public interface IImageMessage : IMessage
        {
            public string ImageFormat { get; set; }
            void SaveImage();
        }
        public interface IAudioMessage : IMessage
        {
            public byte[] SoundStream { get; set; }
        }


        public class VideoMessage : IVideoMessage
        {
            public int Duration { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string From { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string To { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string Body { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        }


    }
}
