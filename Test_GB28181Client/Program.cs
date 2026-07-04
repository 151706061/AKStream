using System;
using LibCommon;
using LibGB28181SipClient;

namespace Test_GB28181Client
{
    [Serializable]
    
    public class AuthStructs
    {
        private string _date;
        private string? _msg;
        private string? _plugName;
        private bool? _flag;

        
        public string Date
        {
            get => _date;
            set => _date = value;
        }

        public string Msg
        {
            get => _msg;
            set => _msg = value;
        }
        public string PlugName
        {
            get => _plugName;
            set => _plugName = value;
        }

        public bool? Flag
        {
            get => _flag;
            set => _flag = value;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("{0}", ("dxper".Equals("net")).ToString().ToUpper());
            var post = new AuthStructs
            {
                Date = "data",
                Msg = "msg",
                PlugName = "Common.pbr.IdentifyTag",
                Flag = false,
            }.ToJson();
            var http = "http://singleauth.zjguardian.com:49997/auth/applicationinfo/v1/commit";
            var https = "https://singleauth.zjguardian.com:49998/auth/applicationinfo/v1/commit";
            var ret=NetHelper.HttpPostRequest(https, null,
                post, "utf-8", 5000);
            Console.WriteLine(ret);
        }
    }
}