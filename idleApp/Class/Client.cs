//using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using WebSocketSharp;

namespace idleApp.Class
{
    class Client
    {
        //ws://218.95.142.27:85        
        BackgroundWorker _bw = new BackgroundWorker();
        //103.224.80.82
        string addr = "103.224.80.82";
        string port = "85";
        //private WebSocket ws;
        private int snum = 0;
        private string myid = "0";
        private string sendto = "0";
        #region 属性
        ///<summary>
        ///地址
        ///</summary>
        public string Address
        {
            get
            {
                return addr;
            }

            set
            {
                addr = value;
            }
        }

        ///<summary>
        ///端口
        ///</summary>
        public string Port
        {
            get
            {
                return port;
            }

            set
            {
                port = value;
            }
        }

        #endregion

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="num">S码</param>
        public Client(int snum)
        {
            this.snum = snum;
            _bw.DoWork += bw_DoWork;
            _bw.RunWorkerAsync("Start to configure");
        }

        void bw_DoWork(object bw_sender, DoWorkEventArgs bw_e)
        {
            // 这里在工作线程上执行配置客户端
            string url = "ws://" + addr + ":" + port;
            ws = new WebSocket(url);
#if DEBUG
            ws.Log.Level = LogLevel.Trace;
#endif
            Message mgs = new Message();

            ws.OnOpen += (sender, e) =>
            {
                //注册用户名
                string name = "st" + snum;

                //设定数据
                //格式
                //LIN 0 0 name 
                mgs.Status = "LIN";
                mgs.From = "0";
                mgs.To = "0";
                mgs.Value = name;

                //数据实体序列化和反序列化
                string json = JsonHelper.SerializeObject(mgs);
                ws.Send(json);
            };
            ws.OnMessage += (sender, e) =>
            {

                mgs = JsonHelper.DeserializeJsonToObject<Message>(e.Data);

                if (mgs.Status == "OLN")
                {
                    myid = mgs.To;
                }

            };

            ws.OnClose += (sender, e) =>
            {

            };
            ws.WaitTime = TimeSpan.FromSeconds(10);
            ws.EmitOnPing = true;

            //连接
            Connect();
        }

        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="value">消息</param>
        public void Send(string value)
        {
            Message msg = new Message();
            msg.Status = "MSG";
            msg.From = myid;
            msg.To = sendto;
            msg.Value = value;
            string json = JsonHelper.SerializeObject(msg);
            ws.Send(json);

        }

        /// <summary>
        /// 连接服务器
        /// </summary>
        public void Connect()
        {
            ws.ConnectAsync();
        }

        /// <summary>
        /// 断开连接
        /// </summary>
        public void Close()
        {
            ws.Close();
        }
    }
}
