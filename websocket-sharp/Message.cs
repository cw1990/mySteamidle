using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebSocketSharp
{
    public class Message
    {
        //LIN 上线
        //MSG 消息
        //OUT 离线
        //OLN 列表

        //Jsonson数据包定义
        //{
        //    Status:value1,
        //    From:value2,
        //    To:value2,
        //    Value:value2
        //}

        /// <summary>
        /// 消息类型:LIN 上线, MSG 消息, OUT 离线, OLN 列表
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// 来源ID
        /// </summary>
        public string From { get; set; }
        /// <summary>
        /// 去向ID
        /// </summary>
        public string To { get; set; }
        /// <summary>
        /// 数据
        /// </summary>
        public string Value { get; set; }

    }
}
