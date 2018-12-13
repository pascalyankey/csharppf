using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace CSharpPFOefenmap
{
    public class Twitter
    {
        string bestandsnaam = @"C:\Data\twitter.obj";
        public void PostTweet(Tweet tweet)
        {
            Tweets tweets = new Tweets();
            tweets.AddTweet(tweet);

            try
            {
                using (var bestand = File.Open(bestandsnaam, FileMode.OpenOrCreate))
                {
                    BinaryFormatter schrijver = new BinaryFormatter();
                    schrijver.Serialize(bestand, tweet);

                    Console.WriteLine(tweet.ToString());
                }
            }
            catch (IOException)
            {
                throw new Exception("Fout bij het schrijven naar het bestand!");
            }
            catch (SerializationException)
            {
                Console.WriteLine("Fout bij het serialiseren/deserialiseren");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        public void ShowTweets()
        {
            List<Tweet> tweets = new List<Tweet>();
            try
            {
                using (var bestand = File.Open(bestandsnaam, FileMode.Open, FileAccess.Read))
                {
                    var lezer = new BinaryFormatter();
                    tweets = (List<Tweet>)lezer.Deserialize(bestand);
                    foreach (var tweet in tweets)
                    {
                        Console.WriteLine(tweet.ToString());
                    }
                }
            }
            catch (IOException)
            {
                throw new Exception("Fout bij het lezen van het bestand!");
            }
            catch (SerializationException)
            {
                Console.WriteLine("Fout bij het serialiseren/deserialiseren");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ShowTweets(string naam)
        {

        }
    }
}
