using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BilgeAdam.Business.BaseResult
{
    [Serializable]
    public class ServiceResult<T>
    {
        public ServiceResult()
        {
            InfoMessages = new List<string>();
            ValidationMessages = new List<string>();
        }
        public bool HasError { get; set; }
        [XmlIgnore]
        public Exception Exception { get; set; }
        public List<string> InfoMessages { get; set; }
        public List<string> ValidationMessages { get; set; }
        public int AffectedRow { get; set; }
        public T Result { get; set; }
        public int TotalItemCount { get; set; }
        public string ErrorMessage { get; set; }
    }
}
