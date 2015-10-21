using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace idleApp.Class
{
    class CmdHelper
    {
        Hashtable cmdlist;

        List<string> chelplist;

        public CmdHelper()
        {
            initialize();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        private void initialize()
        {
            chelplist = new List<string>();
            chelplist.Add("help,查看帮助\r\n");
            chelplist.Add("run,运行单个程序\r\n");
            chelplist.Add("stop,停止运行\r\n");
            chelplist.Add("update,检查更新\r\n");

            Func<string,string> help = p => HelpCmd(p);

            cmdlist = new Hashtable();
            cmdlist.Add("help", help);
        }

        #region 命令
        private string HelpCmd(string param)
        {
            string a = param;
            return a;
        }
        #endregion


        /// <summary>
        /// 检查命令
        /// </summary>
        /// <param name="value"></param>
        /// <returns>是否是已知命令</returns>
        public string CheckKey(string value)
        {
            if (cmdlist.ContainsKey(value))
            {
                return GetValue(value)("1");
            }
            else
            {
                return String.Format("(╯‵□′)╯︵┻━┻ 没有找到{0}这个命令,请输入help查看帮助", value);
            }
        }

        /// <summary>
        /// 根据键获取对应值
        /// </summary>
        /// <param name="key">键</param>
        /// <returns></returns>
        public Func<string,string> GetValue(string key)
        {
            //在哈希表中查询是否存在对应的键值
            if (cmdlist.ContainsKey(key))
                return (Func<string,string>)cmdlist[key];
            else
                return null; //没有匹配的键值
        }

    }
}
