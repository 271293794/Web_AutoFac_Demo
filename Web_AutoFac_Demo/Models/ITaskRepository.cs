namespace Web_AutoFac_Demo.Models
{
    public  interface ITaskRepository
    {
        // 向 mongodb 或 sqlserver 或 写入txt文件
        int Add();
    }
}