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

        StringBuilder cmdHelpText = new StringBuilder();

        public CmdHelper()
        {
            initialize();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        private void initialize()
        {
            cmdHelpText.Append("\r\n");
            cmdHelpText.Append("       注意:控制台功能正在开发中\r\n");
            cmdHelpText.Append("       help,查看帮助\r\n");
            cmdHelpText.Append("       run,运行单个程序\r\n");
            //cmdHelpText.Append("       stop,停止运行\r\n");
            //cmdHelpText.Append("       update,检查更新\r\n");

            Func<string[],string> help = p => HelpCmd(p);

            Func<string[], string> run = p => RunCmd(p);

            cmdlist = new Hashtable();
            cmdlist.Add("help", help);
            cmdlist.Add("run", run);
        }

        #region 命令
        private string HelpCmd(string[] param)
        {
            if(param.Length > 1)
            {
                StringBuilder cmdTmpText = new StringBuilder();
                switch(param[1])
                {
                    case "run":
                        cmdTmpText.Append("用法: run [id] [name]\r\n");
                        cmdTmpText.Append("选项:\r\n");
                        cmdTmpText.Append("   id GameID\r\n");
                        cmdTmpText.Append("   name 显示的Game名称，可自定义(名字里不要带空格)\r\n");
                        cmdTmpText.Append("范例:\r\n");
                        cmdTmpText.Append("   run 570\r\n");
                        cmdTmpText.Append("   run 570 Word2016");
                        break;
                    default:
                        cmdTmpText.AppendFormat("{0}不是有效命令",param[1]);
                        break;
                }
                return cmdTmpText.ToString();
            }
            else
            {
                return cmdHelpText.ToString();
            }
        }

        private string RunCmd(string[] param)
        {
            StringBuilder cmdRunText = new StringBuilder();
            if (param.Length > 1)
            {
                if (CmdRunApp(param))
                {
                    cmdRunText.AppendFormat("ID：{0}启动成功。如果没有启动，请检查是否被安全软件阻拦",param[1]);
                    return cmdRunText.ToString();
                }
                else
                {
                    cmdRunText.AppendFormat("挂机程序启动被阻止,请检查是否被安全软件阻拦");
                    return cmdRunText.ToString();
                }

            }
            else
            {
                cmdRunText.Append("命令错误，请输入help run查阅帮助");
                return cmdRunText.ToString();
            }
        }
        #endregion

        #region 功能
        /// <summary>
        /// 检查命令
        /// </summary>
        /// <param name="value"></param>
        /// <returns>是否是已知命令</returns>
        public string CheckKey(string value)
        {
            string[] cmd = value.Split(' ');
            try
            {
                if (cmdlist.ContainsKey(cmd[0]))
                {
                    return GetValue(cmd[0])(cmd);
                }
                else
                {
                    return String.Format("(╯‵□′)╯︵┻━┻ 没有找到{0}这个命令,请输入help查看帮助", cmd[0]);
                }
            }
            catch(Exception e)
            {
                return String.Format("(╯‵□′)╯︵┻━┻ 没有找到{0}这个命令,请输入help查看帮助", value);
            }
        }

        /// <summary>
        /// 根据键获取对应值
        /// </summary>
        /// <param name="key">键</param>
        /// <returns></returns>
        public Func<string[],string> GetValue(string key)
        {
            //在哈希表中查询是否存在对应的键值
            if (cmdlist.ContainsKey(key))
                return (Func<string[],string>)cmdlist[key];
            else
                return null; //没有匹配的键值
        }
        #endregion

        #region Run
        private System.Diagnostics.Process gameApp;
        private bool CmdRunApp(string[] mArguments)
        {
            gameApp = new System.Diagnostics.Process();
            gameApp.StartInfo.UseShellExecute = true;
            gameApp.StartInfo.CreateNoWindow = true;
            gameApp.StartInfo.FileName = "App.exe";
            try
            {
                gameApp.StartInfo.Arguments = string.Format("{0} {1}", mArguments[1], ToBase64(mArguments[2]));
            }
            catch
            {
                gameApp.StartInfo.Arguments = mArguments[1];
            }

            try
            {
                gameApp.Start();
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void CmdStopApp()
        {

        }
        #endregion

        private string ToBase64(string value)
        {
            string base64name = value;
            byte[] messageByte = Encoding.UTF8.GetBytes(base64name);
            base64name = Convert.ToBase64String(messageByte);
            return base64name;
        }
    }
}
