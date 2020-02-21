using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace PokemonApp.Core.Extentions
{
    public class EnumListExtension : MarkupExtension
    {
        private Type enumType_;

        public EnumListExtension(Type type)
        {
            enumType_ = type;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return Enum.GetValues(enumType_);
        }
    }
}
