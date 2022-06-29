using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Services.Filters;
using Services.Readers;

namespace Services
{
    public class ServicesAutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // Readers
            builder.RegisterType<TextFromFileReader>().As<ITextFromFileReader>();

            // Services
            builder.RegisterType<TextFilterService>().As<ITextFilterService>();

            // Filters
            builder.RegisterType<WordsWithMiddleVowelFilter>().As<IFilter>();
            builder.RegisterType<LengthLessThanThreeFilter>().As<IFilter>();
            builder.RegisterType<WordsWithTFilter>().As<IFilter>();

            base.Load(builder);
        }
    }
}
