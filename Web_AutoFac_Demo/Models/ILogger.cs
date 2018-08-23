using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_AutoFac_Demo.Models
{
    public interface ILogger
    {
        // 向 mongodb 或 sqlserver 或 写入txt文件
        void Write();
    }
}
