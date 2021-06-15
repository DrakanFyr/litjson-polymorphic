using System;

namespace LitJson
{
    [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Class, AllowMultiple = true)]
    public class SubtypeAttribute : Attribute
    {
        public string SubtypeId => _subtypeId;
        public Type Subtype => _subtype;

        private string _subtypeId;
        private Type _subtype;
        
        public SubtypeAttribute(Type enumType, int enumValue, Type subtype)
        {
            _subtypeId = Enum.GetName(enumType, enumValue);
            _subtype = subtype;
        }
        
        public SubtypeAttribute(Type subtype, string subtypeId)
        {
            _subtypeId = subtypeId;
            _subtype = subtype;
        }
    }
}