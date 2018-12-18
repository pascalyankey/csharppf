using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace CSharpPFOefenmap
{
    [Serializable]
    public class Tweets
    {
        private List<Tweet> berichtenValue;

        public ReadOnlyCollection<Tweet> Berichten
        {
            get
            {
                return new ReadOnlyCollection<Tweet>(berichtenValue);
            }
        }

        public void AddTweet(Tweet tweet)
        {
            if (berichtenValue == null)
                berichtenValue = new List<Tweet>();
            this.berichtenValue.Add(tweet);
        }
    }
}
