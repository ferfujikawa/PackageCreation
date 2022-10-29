using StringExtensionPack;

namespace Tests
{
    public class StringExtensionsTests
    {
        [Theory]
        [InlineData("entity_framework_core")]
        public void Text_WithUnderline_ReturnCamelCase(string text)
        {
            var result = text.ToCamelCase();
            Assert.Equal("entityFrameworkCore", result);
        }

        [Theory]
        [InlineData("entityFrameworkcore")]
        [InlineData("dotnet-framework")]
        [InlineData("oláMundo")]
        public void Text_WithoutUnderline_ReturnLowered(string text)
        {
            var result = text.ToCamelCase();
            Assert.Equal(text.ToLower(), result);
        }
    }
}
