using System;
using System.Reflection;

namespace RandevuYonetimSistemi.MvcUI.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}