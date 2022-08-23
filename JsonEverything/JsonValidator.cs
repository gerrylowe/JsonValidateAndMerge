using Json.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace JsonEverything
{
    internal static class JsonValidator
    {
        public static void Validate(JsonSchema schema, string json)
        {
            var validationOptions = ValidationOptions.Default;
            validationOptions.OutputFormat = OutputFormat.Basic;
            var results = schema.Validate(JsonNode.Parse(json), validationOptions);
            Console.WriteLine($"Validation result: {results.IsValid} {results.Message}");
        }
    }
}
