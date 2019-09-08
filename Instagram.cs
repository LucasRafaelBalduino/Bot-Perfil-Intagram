using System;
using System.Net;

namespace Bot.Intagram.Profile
{
    public static class Instagram
    {
        public static Profile GetProfileByuser(string username)
        {
            var profile = new Profile(username);
            String url = @"https://www.instagram.com/" + username + "/";

            string markup;
            using (WebClient c = new WebClient())
            {
                markup = c.DownloadString(url);
            }

            HtmlAgilityPack.HtmlDocument html = new HtmlAgilityPack.HtmlDocument();

            html.LoadHtml(markup);

            var list = html.DocumentNode.SelectNodes("//meta");

            foreach (var node in list)
            {
                String property = node.GetAttributeValue("property", "");

                if (property == "al:ios:app_name")
                {
                    profile.IosAppName = node.GetAttributeValue("content", "");
                }
                else if (property == "al:ios:app_store_id")
                {
                    profile.IosAppId = node.GetAttributeValue("content", "");
                }
                else if (property == "al:ios:url")
                {
                    profile.IosUrls = node.GetAttributeValue("content", "");
                }
                else if (property == "al:android:app_name")
                {
                    profile.AndroIdAppName = node.GetAttributeValue("content", "");
                }
                else if (property == "al:android:package")
                {
                    profile.AndroIdAppId = node.GetAttributeValue("content", "");
                }
                else if (property == "al:android:url")
                {
                    profile.AndroIdUrl = node.GetAttributeValue("content", "");
                }
                else if (property == "og:type")
                {
                    profile.Type = node.GetAttributeValue("content", "");
                }
                else if (property == "og:image")
                {
                    profile.Image = node.GetAttributeValue("content", "");
                }
                else if (property == "og:title")
                {
                    profile.Title = node.GetAttributeValue("content", "");
                }
                else if (property == "og:description")
                {
                    profile.Description = node.GetAttributeValue("content", "");
                }
                else if (property == "og:url")
                {
                    profile.Url = node.GetAttributeValue("content", "");
                }
            }

            return profile;
        }
    }
}
