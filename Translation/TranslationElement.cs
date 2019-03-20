﻿using System;

namespace DotNetTranslator
{
    [Serializable]
    public class TranslationElement
    {
        public string Name = "";
        public string Value = "";
        public string Credits = "";

        /// <summary>
        /// Translation for some element
        /// </summary>
        /// <param name="name">Element Name</param>
        /// <param name="value">Translation Value</param>
        /// <param name="credits">Translation Value Authors</param>
        public TranslationElement(string name, string value, string credits = "(C) ")
        {
            Name = name;
            Value = value;
            Credits = credits;
        }

        /// <summary>
        /// Emptry contructor for deserializer. DO NOT USE IT.
        /// </summary>
        public TranslationElement() { }

        public override string ToString()
            => Value;
    }
}
