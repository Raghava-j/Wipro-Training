using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SocialMedia
    {
        public virtual void Post()
        {
            Console.WriteLine("Posting on social media");
        }
    }
    class FacebookPost : SocialMedia
    {
        public override void Post()
        {
            Console.WriteLine("Posting on Facebook");
        }
    }
    class TwitterPost : SocialMedia
    {
        public override void Post()
        {
            Console.WriteLine("Tweet on Twitter");
        }
    }
    class InstagramPost : SocialMedia
    {
        public override void Post()
        {
            Console.WriteLine("Posting on Instagram");
        }
    }
}

using System;
namespace ConsoleApp1;

class Program
{
    static void Main()
    {
        FacebookPost fp = new FacebookPost();
        fp.Post();
        TwitterPost tp = new TwitterPost();
        tp.Post();
        InstagramPost ip = new InstagramPost();
        ip.Post();
    }
}