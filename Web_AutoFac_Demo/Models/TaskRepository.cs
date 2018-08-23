using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_AutoFac_Demo.Models
{
    public class TaskRepository : ITaskRepository
    {
        public int Add()
        {
            //System.Diagnostics.Debug.WriteLine 查看输出窗口
            System.Diagnostics.Debug.WriteLine("添加成功"); return 1;
        }


    }
}