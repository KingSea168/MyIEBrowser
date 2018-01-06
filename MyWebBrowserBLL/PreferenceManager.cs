using MyWebBrowserDAL;
using MyWebBrowserModels;

namespace MyWebBrowserBLL
{
    public class PreferenceManager
    {
        private PreferenceService preferService = new PreferenceService();

        /// <summary>
        /// 获取首选项
        /// </summary>
        /// <returns></returns>
        public Preference GetPreference()
        {
            return preferService.GetPreference();
        }

        /// <summary>
        /// 保存首选项
        /// </summary>
        /// <param name="prefer"></param>
        /// <returns></returns>
        public bool SavePreference(Preference prefer)
        {
            return preferService.SavePreference(prefer);
        }
    }
}
