using Phonebook_Application; // Reference to your main project namespace
using Xunit;                 // For unit testing attributes and assertions

namespace Phonebook_Application.Tests
{
    public class PhonebookTests
    {
        [Fact]
        public void AddContact_ShouldAddNewContact()
        {
            // Arrange
            var phonebook = new Phonebook();

            // Act
            phonebook.AddContact("Alice", "123456789");

            // Assert
            var result = phonebook.SearchContact("Alice");
            Assert.NotNull(result);
            Assert.Equal("Alice", result.Name);
            Assert.Equal("123456789", result.PhoneNumber);
        }

        [Fact]
        public void DeleteContact_ShouldRemoveContact()
        {
            var phonebook = new Phonebook();
            phonebook.AddContact("Bob", "987654321");

            phonebook.DeleteContact("Bob");

            var result = phonebook.SearchContact("Bob");
            Assert.Null(result);
        }
    }
}
