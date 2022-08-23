// See https://aka.ms/new-console-template for more information
using Json.Schema;
using JsonEverything;

//
// Some simple validation tests.
//
var mySchema = JsonSchema.FromText("""
            {
                "properties":{
                "myProperty":{
                    "type":"string",
                    "minLength":10
                }
                },
                "required":["myProperty"]
            }
            """);
JsonValidator.Validate(mySchema, """
{
}
""");
JsonValidator.Validate(mySchema, """
{
    "myProperty":123
}
""");
JsonValidator.Validate(mySchema, """
{
    "myProperty":"123456789"
}
""");
JsonValidator.Validate(mySchema, """
{
    "myProperty":"1234567890"
}
""");

//
// Some simple merge tests.
//
JsonMerger.Merge("""
{
    "myProperty":"1234567890"
}
""", """
{
    "yourProperty":"hello"
}
""");

Console.WriteLine("Success!");
