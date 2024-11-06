﻿namespace LightNap.Scaffolding.TemplateManager
{
    internal static class TemplateProcessor
    {
        public static string ProcessTemplate(string templateContent, TemplateParameters templateParameters)
        {
            foreach (var replacement in templateParameters.Replacements)
            {
                templateContent = templateContent.Replace($"<#= {replacement.Key} #>", replacement.Value);
            }
            return templateContent;
        }
    }
}