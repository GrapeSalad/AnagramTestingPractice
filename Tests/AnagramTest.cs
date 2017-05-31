using Xunit;
using System;
using System.Collections.Generic;

namespace Anagram
{
  public class AnagramTests : IDisposable
  {

    [Fact]
    public void ContainsCar()
    {
      AnagramSearch instance = new AnagramSearch();
      Assert.Equal(true, instance.LoadJson().Contains("car"));
    }
    [Fact]
    public void ContainsCharacter()
    {
      List<string> testList = new List<string> {"cat", "dog", "car", "tree", "arc"};
      AnagramSearch instance = new AnagramSearch();
      List<string> testList1 = new List<string> {"car", "arc"};
      List<string> matchList = instance.SearchForChar("car", testList);

      Assert.Equal(testList1, matchList);
    }
  }
}
