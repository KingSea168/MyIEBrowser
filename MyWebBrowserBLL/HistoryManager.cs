using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyWebBrowserDAL;
using MyWebBrowserModels;

namespace MyWebBrowserBLL
{
    public class HistoryManager
    {
        private HistoryService hisService = new HistoryService();

        /// <summary>
        /// 保存历史记录
        /// </summary>
        /// <param name="historyList"></param>
        /// <returns></returns>
        public bool SaveHistory(List<History> historyList)
        {
            return hisService.SaveHistory(historyList);
        }

        /// <summary>
        /// 获取历史记录
        /// </summary>
        /// <returns></returns>
        public List<History> GetHistory()
        {
            return hisService.GetHistory();
        }
    }
}
