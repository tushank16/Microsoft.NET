﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService_Entity_Product
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,
                                   BodyStyle = WebMessageBodyStyle.Bare,
                                   UriTemplate = "GetProducts")]

        List<Product> GetProducts();


        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,
                                   BodyStyle = WebMessageBodyStyle.Bare,
                                   UriTemplate = "ViewProduct/?id={id}")]

        Product ViewProduct(int id);


        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json,
                                   BodyStyle = WebMessageBodyStyle.Bare,
                                   UriTemplate = "AddProduct")]

        int AddProduct(Product product);
    }
}
