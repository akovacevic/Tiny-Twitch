using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Tiny_Twitch
{
    public static class WebBrowserExtensions
    {
        private static string GetTwitchVideoPlayer(string channelName)
        {
            var sb = new StringBuilder();

            sb.Append("<html>");
            sb.Append("    <head>");
            sb.Append("    </head>");
            sb.Append("    <body>");
            sb.Append("        <iframe src=\"https://player.twitch.tv/?channel=" + channelName + "\" frameborder=\"0\" scrolling=\"no\" style=\"width: 100%; height: 100%; margin-top: -8px; margin-bottom: -8px;\"></iframe>");
            sb.Append("    </body>");
            sb.Append("</html>");

            return sb.ToString();
        }

        public static void ShowTwitchVideo(this Awesomium.Windows.Controls.WebControl webBrowser, string channelName)
        {
            if (webBrowser == null) throw new ArgumentNullException("webBrowser");

            webBrowser.LoadHTML(GetTwitchVideoPlayer(channelName));
        }
    }
}
