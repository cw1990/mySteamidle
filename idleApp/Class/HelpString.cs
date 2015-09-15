using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace idleApp.Class
{
    class HelpString
    {
        StringBuilder help;

        public HelpString()
        {
            help = new StringBuilder();
            help.Append("1.如果不能加载游戏名称\r\n");
            help.Append("应该是网络问题\r\n");
            help.Append("因为游戏名称是从steam官网上拉下来的\r\n");
            help.Append("右下角的图片同理\r\n");
            help.Append("不影响挂机的\r\n");
            help.Append("\r\n");
            help.Append("2.如果游戏没有启动\r\n");
            help.Append("请打开文件夹\r\n");
            help.Append("把里边的exe和dll文件解除锁定\r\n");
            help.Append("右键文件-属性 就可以看到\r\n");
        }

        public override string ToString()
        {
            return help.ToString();
        }
    }
}
