using System;
using System.Reflection;

namespace ASP.NET_WebAPI_with_Entity.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}