using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void ValueTypesAlsoPassByValue(){
            var x = GetInt();
            SetInt(x);

            //because csharp uses pass by value, x is still 3 even 
            //after we pass it to SetInt. The value of 3 is copied 
            //from x and put into int z in SetInt's argument
            Assert.Equal(3, x);
        }
        private void SetInt(int z){
            z = 42;
        }
        private int GetInt(){
            return 3;
        }

        [Fact]
        public void CSharpCanPassByRef()
        {
            var book1 = GetBook("Book1");
            //try and rename the book
            GetBookSetName(ref book1, "New Name");
            //check to see if the New Name was saved
            Assert.Equal("New Name", book1.Name);


        }
        //ref keyword tells csharp that we are passing by reference.
        //book is not a copy of the value of the book being passed, it is a reference
        private void GetBookSetName(ref Book book, string name)
        {
            //now we are making a new object. so book1 is now a new
            //Book called New Name
            book = new Book(name);
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            var book1 = GetBook("Book1");
            //try and rename the book
            GetBookSetName(book1, "New Name");
            //check to see if the New Name was saved
            Assert.Equal("Book1", book1.Name);


        }
        private void GetBookSetName(Book book, string name)
        {
            //change the name of the book to the incoming name parameter
            book = new Book(name);
        }
        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Book1");
            //try and rename the book
            SetName(book1, "New Name");
            //check to see if the New Name was saved
            Assert.Equal("New Name", book1.Name);
            

        }
        private void SetName(Book book, string name){
            //change the name of the book to the incoming name parameter
            book.Name = name;
        }
        [Fact]
        public void StringsBehaveLikeValueTypes(){
            string name = "Duncan";
            string upper = MakeUppercase(name);

            Assert.Equal("DUNCAN", upper);
        }
        private string MakeUppercase(string name){
            return name.ToUpper();
        }
        //write a test and instantiates a few books, and the checks 
        //to see if they are the same book or not.
        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book1");
            var book2 = GetBook("Book2");

            Assert.Equal("Book1", book1.Name);
            Assert.Equal("Book2", book2.Name);

        }
        public void TwoVarsCanReferenceSameObject()
        {
            var book1 = GetBook("Book1");
            var book2 = book1;

            //see if they are the same object
            Assert.Same(book1,book2);
            //this assert below is doing the same thing as
            //Assert.Same
            Assert.True(Object.ReferenceEquals(book1, book2));

        }
        Book GetBook(string name){
            return new Book(name);
        }
    }
}