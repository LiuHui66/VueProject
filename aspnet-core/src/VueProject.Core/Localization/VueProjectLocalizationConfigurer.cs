using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace VueProject.Localization
{
    public static class VueProjectLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(VueProjectConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(VueProjectLocalizationConfigurer).GetAssembly(),
                        "VueProject.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
