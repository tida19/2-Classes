using System.Collections.Generic;

namespace index
{
    public class HittpCookie
    {
        private Dictionary<string, string> _dictionary;
        public DataTime Expiry { get; set; }
        public HittpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }
        public void SetTime(string key, string value)
        {

        }
        public void GetTime(string key)
        {

        }
        public string this[string key]
        {
            get
            {
                return _dictionary[key];
            }
            set
            {
                _dictionary[key] = value;
            }
        }
        public class DataTime
        {

        }
    }
}
