
/*
  Good enough pottern. Has actual usage that make sense but too easy to become God Object
*/
namespace DesignPattern
{
    class VideoFile {}

    class OggCompressionCodec {}

    class VideoConverter {
        void Convert(string fileName, string format)
        {
            if(format == "Video") {
                var video = new VideoFile();
            } else {
                var compression = new OggCompressionCodec();
            }
        }
    }
    
}