using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace idleApp.Class
{
    class GetIDName
    {
        string srchtml;
        List<string> badlist = new List<string>() { "303700", "368020", "335590", "267420" };

        #region 属性

        public List<string> Badlist
        {
            get
            {
                return badlist;
            }

            set
            {
                badlist = value;
            }
        }

        #endregion

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="value">源码</param>
        public GetIDName(string value)
        {
            srchtml = value;
        }

        ///  <summary>
        ///  获取ID数据
        ///  </summary>
        public List<AppMember> Getid()
        {
            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(srchtml);
            List<AppMember> tmplist = new List<AppMember>();
            try
            {
                foreach (var badge in document.DocumentNode.SelectNodes("//div[@class=\"badge_row is_link\"]"))
                {
                    var appIdNode = badge.SelectSingleNode(".//a[@class=\"badge_row_overlay\"]").Attributes["href"].Value;
                    var appid = Regex.Match(appIdNode, @"gamecards/(\d+)/").Groups[1].Value;

                    if (string.IsNullOrWhiteSpace(appid) || badlist.Contains(appid) || appIdNode.Contains("border=1"))
                    {
                        continue;
                    }

                    var hoursNode = badge.SelectSingleNode(".//div[@class=\"badge_title_stats_playtime\"]");
                    var hours = hoursNode == null ? string.Empty : Regex.Match(hoursNode.InnerText, @"[0-9\.,]+").Value;

                    var nameNode = badge.SelectSingleNode(".//div[@class=\"badge_title\"]");
                    var name = WebUtility.HtmlDecode(nameNode.FirstChild.InnerText).Trim();

                    var cardNode = badge.SelectSingleNode(".//span[@class=\"progress_info_bold\"]");
                    var cards = cardNode == null ? string.Empty : Regex.Match(cardNode.InnerText, @"[0-9]+").Value;

                    if (!string.IsNullOrWhiteSpace(cards))
                    {
                        AppMember member = new AppMember();
                        member.Id = appid;
                        member.Name = name;
                        member.CardNum = cards;
                        member.Time = hours == string.Empty ? "0" : hours;
                        tmplist.Add(member);
                    }
                }
            }
            catch
            {
                throw new Exception("源代码不正确");
            }
            return tmplist;
        }  
    }
}
