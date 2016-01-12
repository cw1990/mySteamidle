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
        private int cardTime;
        private List<string> blacklist = new List<string>();
        private string updateUrl;
        private int maxGameNum;   

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

        public int MaxGameNum
        {
            get
            {
                return maxGameNum;
            }

            set
            {
                maxGameNum = value;
            }
        }
    }
}
