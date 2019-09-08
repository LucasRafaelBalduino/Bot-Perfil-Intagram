using System;
using System.Collections.Generic;
using System.Text;

namespace Bot.Intagram.Profile
{
    public class Profile
    {
        public String Username { get; set; }

        public Profile(string username)
        {
            Username = username;
        }

        public String IosAppName { get; set; }
        public String IosAppId { get; set; }
        public String IosUrls { get; set; }

        public String AndroIdAppName { get; set; }
        public String AndroIdAppId { get; set; }
        public String AndroIdUrl { get; set; }
        public String Type { get; set; }
        public String Image { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public String Url { get; set; }

        public override string ToString()
        {
            return "User Name: " 
                + Username 
                + "\n" 
                + "Title: " 
                + Title
                + "\n"
                + "Description: "
                + Description
                + "\n"
                + "Url: "
                + Url
                + "\n"
                + "Image: "
                + Image
                + "\n"
                ;
        }
    }
}
