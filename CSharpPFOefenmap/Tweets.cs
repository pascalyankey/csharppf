using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace CSharpPFOefenmap
{
    public class Tweets
    {
        public List<Tweet> Berichten { get; }
        public void AddTweet(Tweet tweet)
        {
            Berichten.Add(tweet);
        }
    }
}
