namespace Projeto2.models
{
    public class Log
    {
        private static Log _log;
        private Log()
        {

        }

        public static Log getInstance()
        {
            if(this._log == null)
            {
                this._log = new Log();
            }
            return this._log;
        }
    }
}