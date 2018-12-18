using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public string bestandsnaam = @"C:\Data\twitter.obj";

        public void PostBericht(Tweet tweet)
        {
            var alleTweets = new Tweets();
            try
            {
                if (File.Exists(bestandsnaam))
                {
                    using (var bestand = File.Open(bestandsnaam, FileMode.Open, FileAccess.Read))
                    {
                        var lezer = new BinaryFormatter();
                        var bestaandLijst = (Tweets)lezer.Deserialize(bestand);
                        foreach (var item in bestaandLijst.Berichten)
                            alleTweets.AddTweet(item);
                        alleTweets.AddTweet(tweet);
                    }
                    using (var bestand = File.Open(bestandsnaam, FileMode.OpenOrCreate))
                    {
                        var schrijver = new BinaryFormatter();
                        schrijver.Serialize(bestand, alleTweets);
                    }
                } else
                {
                    using (var bestand = File.Open(bestandsnaam, FileMode.OpenOrCreate))
                    {
                        var schrijver = new BinaryFormatter();
                        alleTweets.AddTweet(tweet);
                        schrijver.Serialize(bestand, alleTweets);
                    }
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
        
        public void ToonBerichten()
        {
            var vandaag = DateTime.Now;
            try
            {
                if (File.Exists(bestandsnaam))
                {
                    using (var bestand = File.Open(bestandsnaam, FileMode.Open, FileAccess.Read))
                    {
                        var lezer = new BinaryFormatter();
                        var tweets = (Tweets)lezer.Deserialize(bestand);
                        var recent = from recentbericht in tweets.Berichten orderby recentbericht.Tijdstip descending select recentbericht;
                        foreach (var tweet in recent)
                        {
                            if (tweet.Tijdstip.Date == vandaag.Date)
                            {
                                if (vandaag.Hour > tweet.Tijdstip.Hour)
                                {
                                    Console.WriteLine($"{tweet.Naam}: {tweet.Bericht} - {vandaag.Hour - tweet.Tijdstip.Hour} uren geleden");
                                }
                                else if (vandaag.Hour == tweet.Tijdstip.Hour)
                                {
                                    Console.WriteLine($"{tweet.Naam}: {tweet.Bericht} - {vandaag.Minute - tweet.Tijdstip.Minute} minuten geleden");
                                }
                                else
                                {
                                    Console.WriteLine($"{tweet.Naam}: {tweet.Bericht} - {tweet.Tijdstip.TimeOfDay.ToString("hh\\:mm")}");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"{tweet.Naam}: {tweet.Bericht} - {tweet.Tijdstip.Date.ToString("dd-MM-yyyy")}");
                            }
                        }
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

        public void ToonBerichten(string naam)
        {
            var vandaag = DateTime.Now;
            try
            {
                if (File.Exists(bestandsnaam))
                {
                    using (var bestand = File.Open(bestandsnaam, FileMode.Open, FileAccess.Read))
                    {
                        var lezer = new BinaryFormatter();
                        var tweets = (Tweets)lezer.Deserialize(bestand);
                        var recentPersoon = from recentbericht in tweets.Berichten where recentbericht.Naam == naam orderby recentbericht.Tijdstip descending select recentbericht;
                        foreach (var tweet in recentPersoon)
                        {
                            if (tweet.Tijdstip.Date == vandaag.Date)
                            {
                                if (vandaag.Hour > tweet.Tijdstip.Hour)
                                {
                                    Console.WriteLine($"{tweet.Naam}: {tweet.Bericht} - {vandaag.Hour - tweet.Tijdstip.Hour} uren geleden");
                                }
                                else if (vandaag.Hour == tweet.Tijdstip.Hour)
                                {
                                    Console.WriteLine($"{tweet.Naam}: {tweet.Bericht} - {vandaag.Minute - tweet.Tijdstip.Minute} minuten geleden");
                                }
                                else
                                {
                                    Console.WriteLine($"{tweet.Naam}: {tweet.Bericht} - {tweet.Tijdstip.TimeOfDay.ToString("hh\\:mm")}");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"{tweet.Naam}: {tweet.Bericht} - {tweet.Tijdstip.Date.ToString("dd-MM-yyyy")}");
                            }
                        }
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
    }
}
