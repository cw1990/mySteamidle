using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;
using System.Net;
using System.Xml;

namespace Update
{
    /// <summary>
    /// 更新完成触发的事件
    /// </summary>
    public delegate void UpdateState();

    /// <summary>
    /// 更新进度变化触发的事件
    /// </summary>
    public delegate void UpdateProgress(int ProgressValue, string text);

    /// <summary>
    /// 程序更新
    /// </summary>
    public class SoftUpdate
    {
        WebClient wc;
        private string download;
        private string updateUrl;

        #region 构造函数
        public SoftUpdate() { }

        /// <summary>
        /// 程序更新
        /// </summary>
        /// <param name="file">要更新的文件</param>
        public SoftUpdate(string url, string file, string softName)
        {
            this.LoadFile = file;
            this.SoftName = softName;
            this.updateUrl = url;
        }
        #endregion

        #region 属性
        private string loadFile;
        private string newVerson;
        private string softName;
        private bool isUpdate;

        /// <summary>
        /// 或取是否需要更新
        /// </summary>
        public bool IsUpdate
        {
            get
            {
                checkUpdate();
                return isUpdate;
            }
        }

        /// <summary>
        /// 要检查更新的文件
        /// </summary>
        public string LoadFile
        {
            get { return loadFile; }
            set { loadFile = value; }
        }

        /// <summary>
        /// 程序集新版本
        /// </summary>
        public string NewVerson
        {
            get { return newVerson; }
        }

        /// <summary>
        /// 升级的名称
        /// </summary>
        public string SoftName
        {
            get { return softName; }
            set { softName = value; }
        }

        /// <summary>
        /// 升级配置的XML文件地址
        /// </summary>
        public string UpdateUrl
        {
            get
            {
                return updateUrl;
            }
        }

        #endregion

        /// <summary>
        /// 更新完成时触发的事件
        /// </summary>
        public event UpdateState UpdateFinish;
        private void isFinish()
        {
            if (UpdateFinish != null)
                UpdateFinish();
        }

        /// <summary>
        /// 更新进度变化触发的事件
        /// </summary>
        public event UpdateProgress UpdateProgressChage;
        private void isChage(int ProgressValue, string text)
        {
            UpdateProgressChage(ProgressValue, text);
        }

        /// <summary>
        /// 下载更新
        /// </summary>
        public void Update()
        {
            try
            {
                if (!isUpdate)
                    return;

                wc = new WebClient();
                //是否存在正在进行中的Web请求
                if (wc.IsBusy)
                {
                    wc.CancelAsync();
                }
                //绑定事件
                wc.DownloadProgressChanged += Wc_DownloadProgressChanged;
                wc.DownloadFileCompleted += Wc_DownloadFileCompleted;

                string filename = "";
                string exten = download.Substring(download.LastIndexOf("."));
                if (loadFile.IndexOf(@"/") == -1)
                    filename = "Update_" + Path.GetFileNameWithoutExtension(loadFile) + exten;
                else
                    filename = Path.GetDirectoryName(loadFile) + "//Update_" + Path.GetFileNameWithoutExtension(loadFile) + exten;

                wc.DownloadFileAsync(new Uri(download), filename);
            }
            catch
            {
                throw new Exception("更新出现错误，网络连接失败！");
            }
        }

        private void Wc_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            wc.Dispose();
            isFinish();
        }

        private void Wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            string Text = string.Format("{0}/{1}(字节)", e.BytesReceived, e.TotalBytesToReceive);
            isChage(e.ProgressPercentage, Text);
        }

        /// <summary>
        /// 检查是否需要更新
        /// </summary>
        public void checkUpdate()
        {
            try
            {
                WebClient wc = new WebClient();
                Stream stream = wc.OpenRead(updateUrl);
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(stream);
                XmlNode list = xmlDoc.SelectSingleNode("Update");
                foreach (XmlNode node in list)
                {
                    if (node.Name == "Soft" && node.Attributes["Name"].Value.ToLower() == SoftName.ToLower())
                    {
                        foreach (XmlNode xml in node)
                        {
                            if (xml.Name == "Verson")
                                newVerson = xml.InnerText;
                            else
                                download = xml.InnerText;
                        }
                    }
                }

                Version ver = new Version(newVerson);
                Version verson = Assembly.LoadFrom(loadFile).GetName().Version;
                int tm = verson.CompareTo(ver);

                if (tm >= 0)
                    isUpdate = false;
                else
                    isUpdate = true;
            }
            catch (Exception ex)
            {
                throw new Exception("更新出现错误，请确认网络连接无误后重试！");
            }
        }

        /// <summary>
        /// 获取要更新的文件
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.loadFile;
        }
    }
}