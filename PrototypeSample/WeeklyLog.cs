using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeSample
{
    /// <summary>
    /// 周报类：充当原型角色
    /// </summary>
    public class WeeklyLog
    {
        private Attachment attachment;
        private string name;
        private string date;
        private string content;

        public Attachment Attachment
        {
            get { return attachment; }
            set { attachment = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        //使用MemberwiseClone()方法实现浅克隆
        public WeeklyLog Clone()
        {
            return this.MemberwiseClone() as WeeklyLog;     //类型转换
        }

    }
}
