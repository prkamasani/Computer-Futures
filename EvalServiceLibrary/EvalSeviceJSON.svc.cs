using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EvalServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EvalSeviceJSON" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EvalSeviceJSON.svc or EvalSeviceJSON.svc.cs at the Solution Explorer and start debugging.
    public class EvalSeviceJSON : IEvalSeviceJSON
    {
      
        [WebInvoke (Method ="GET", UriTemplate ="GetHellowworld", RequestFormat = WebMessageFormat.Json)]
        public string HellowworldGet()
        {
            return "Hellow World";
        }
        [WebInvoke(Method = "POST", UriTemplate = "GetHellowworld", RequestFormat = WebMessageFormat.Json)]
        public string HellowworldPost()
        {
            return "Hellow World";
        }
    }
}
