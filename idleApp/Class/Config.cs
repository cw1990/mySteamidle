using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace idleApp.Class
{
    /// <summary>
    /// 配置文件
    /// </summary>
    public class Config
    {
        private string regexID;
        private string regexCard;
        private int cardTime;
        private List<string> blacklist = new List<string>();
        private string updateUrl;

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

        public int CardTime
        {
            get
            {
                return cardTime;
            }

            set
            {
                cardTime = value;
            }
        }

        public List<string> Blacklist
        {
            get
            {
                return blacklist;
            }

            set
            {
                blacklist = value;
            }
        }

        public string UpdateUrl
        {
            get
            {
                return updateUrl;
            }

            set
            {
                updateUrl = value;
            }
        }
    }
}
