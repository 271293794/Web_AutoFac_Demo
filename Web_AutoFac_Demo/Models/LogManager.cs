using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_AutoFac_Demo.Models
{
    public class LogManager : ILogger
    {
        private DateTime _dateTime;
        public LogManager(DateTime dateTime)
        {
            this._dateTime = dateTime;
        }
        public void Write()
        {
            //System.Diagnostics.Debug.WriteLine 查看输出窗口
            System.Diagnostics.Debug.WriteLine("向数据库写入日志：" + _dateTime.ToLocalTime());


        }

    }
}