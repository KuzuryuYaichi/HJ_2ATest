using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections.Concurrent;
using System.Threading;

namespace Test2A
{
    public class SaveTXT
    {
        private ConcurrentQueue<byte[]> m_queue;
        /// <summary>
        /// 数据存储路径
        /// </summary>
        private string path;
        /// <summary>
        /// 数据流
        /// </summary>
        private StreamWriter sw;
        /// <summary>
        /// 数据存储标志位
        /// </summary>
        private bool m_FlagSave = false;

        private string name = "数据";
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public SaveTXT()
        {
            m_queue = new ConcurrentQueue<byte[]>();
            Thread RecvThread = new Thread(recvThread);
            RecvThread.IsBackground = true;
            RecvThread.Start();
        }

        public void Start()
        {
            if (m_FlagSave == true)
                return;
            path = @"RecvData\" +name+ DateTime.Now.Date.ToString("yyyy-MM-dd");
            DirectoryInfo fi = new DirectoryInfo(path);
            if (!fi.Exists)
                fi.Create();
            sw = new StreamWriter(path + "\\" + DateTime.Now.ToString("MM-dd-HH-mm") + name + ".txt");
            m_FlagSave = true;
        }
        public void Stop()
        {
            if (m_FlagSave == false)
                return;
            sw.Close();
            m_FlagSave = false;
        }
        public void PushData(byte[] t)
        {
            m_queue.Enqueue(t);
        }

        void recvThread()
        {
            while (true)
            {
                if (m_queue.IsEmpty == false)
                {
                    byte[] t;
                    m_queue.TryDequeue(out t);

                    if (m_FlagSave == true)
                    {
                        for (int i = 0; i < t.Length; i++)
                        {
                            sw.Write(t[i].ToString("x2") + " ");
                        }
                        sw.Write("\r\n");
                    }
                }
            }
        }
    }
}
