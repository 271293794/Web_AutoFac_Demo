using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_AutoFac_Demo.Models;
namespace Web_AutoFac_Demo.Controllers
{
    public class TaskController : Controller
    {
        // GET: Task
        private ITaskRepository _repository;
        private ILogger _logger;

        // Autofac 会自动找到注册的类型
        // 并把值传递给它们
        public TaskController(ITaskRepository repository,ILogger logger)
        {
            this._repository = repository;
            this._logger = logger;
        }
        public TaskController() { }
        public ActionResult Index()
        {
            Add_WriteLog();
            return View();
        }

        public void Add_WriteLog()
        {
            // 不使用具体的日志类和存储类
            _repository.Add();
            _logger.Write();
        }
    }
}