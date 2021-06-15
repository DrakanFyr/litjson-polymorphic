using System;

namespace LitJson
{
    [AttributeUsage(AttributeTargets.Class)]
    public class SubtypeMapAttribute : Attribute
    {
        public Type SubtypeMap => _subtypeMap;
        
        private Type _subtypeMap;

        public SubtypeMapAttribute(Type subtypeMap) => _subtypeMap = subtypeMap;
    }
}