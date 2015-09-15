using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace idleApp.Class
{
    class GetIDName
    {
        string srchtml;
        List<string> badlist = new List<string>() { "303700", "368020", "335590", "267420" };

        #region 属性
        string regexID;
        string regexCard;

        public string RegexID
        {
            get
            {
                return regexID;
            }

            set
            {
                regexID = value;
            }
        }

        public string RegexCard
        {
            get
            {
                return regexCard;
            }

            set
            {
                regexCard = value;
            }
        }

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

            #region test
            //<div class=\"badge_title_stats_playtime\">([^<]*)</div> 67-9=58

            //<span class=\"progress_info_bold\">([^<]*)</span> 54

            //<div class=\"card_drop_info_body\">([^<]*)</div> 55

            //<div class="card_drop_info_dialog" id="(.*?)" style 53
            #endregion
            if (string.IsNullOrEmpty(regexID) || string.IsNullOrEmpty(regexCard))
                return null;

            //id
            MatchCollection mc_id = Regex.Matches(srchtml, regexID);
            //name
            MatchCollection mc_card = Regex.Matches(srchtml, regexCard);
            List<string> tmpcard = new List<string>();
            for (int i = 0; i < mc_card.Count; i++)
            {
                //剔除无效条目
                if (Regex.IsMatch(mc_card[i].Groups[1].Value, "\\d") && !mc_card[i].Value.Contains("任务中"))
                {
                    string str = mc_card[i].Groups[1].Value;
                    string regex = @"(\d+)";
                    Match mstr = Regex.Match(str, regex);
                    tmpcard.Add(mstr.Groups[1].Value);
                }
            }
            List<AppMember> tmplist = new List<AppMember>();
            if (mc_id.Count != 0)
            {
                for (int i = 0; i < mc_id.Count; i++)
                {
                    if (!badlist.Contains(mc_id[i].Value) && tmpcard[i] != null)
                    {
                        AppMember member = new AppMember();
                        member.Id = mc_id[i].Value;
                        member.Name = GetAppName(member.Id);
                        member.CardNum = tmpcard[i];
                        tmplist.Add(member);
                    }
                }

                return tmplist;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 拉取Name
        /// </summary>
        /// <param name="appid"></param>
        /// <returns></returns>
        private string GetAppName(String appid)
        {
            try
            {
                WebRequest request = WebRequest.Create("http://store.steampowered.com/api/appdetails/?appids=" + appid + "&filters=basic");
                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream, Encoding.UTF8);
                string api_raw = reader.ReadToEnd();
                string name = Regex.Match(api_raw, "\"game\",\"name\":\"(.+?)\"").Groups[1].Value;
                name = name.Replace("\\u00ae", "®");
                name = name.Replace("\\u2122", "™");
                name = name.Replace("\\u2019", "'");
                name = name.Replace("\\u00f6", "ö");
                reader.Close();
                response.Close();
                return name;
            }
            catch (Exception e)
            {
                return "网络错误,获取失败";
            }

        }
    }
}
