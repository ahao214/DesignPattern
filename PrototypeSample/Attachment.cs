﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeSample
{
    /// <summary>
    /// 附件类
    /// </summary>
    public class Attachment
    {
        public string name { get; set; }

        public void Download()
        {
            Console.WriteLine("下载附件,文件名为：{0}", name);
        }
    }
}
