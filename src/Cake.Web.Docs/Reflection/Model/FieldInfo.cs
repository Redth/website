﻿using Cake.Web.Docs.Identity;
using Mono.Cecil;

namespace Cake.Web.Docs.Reflection.Model
{
    internal sealed class FieldInfo : IFieldInfo
    {
        private readonly FieldDefinition _definition;
        private readonly IDocumentationMetadata _metadata;
        private readonly string _identity;

        public string Identity
        {
            get { return _identity; }
        }

        public IDocumentationMetadata Metadata
        {
            get { return _metadata; }
        }

        public FieldDefinition Definition
        {
            get { return _definition; }
        }

        public FieldInfo(FieldDefinition definition, IDocumentationMetadata metadata)
        {
            _definition = definition;
            _metadata = metadata;
            _identity = CRefGenerator.GetFieldCRef(definition);
        }
    }
}
