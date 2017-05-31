using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Anagram
{
  public class AnagramSearch
  {
    public void DeleteAll(List<string> list)
    {
      list.DeleteAll();
    }
    public List<string> LoadJson()
    {
      using (StreamReader r = new StreamReader("words.json"))
      {
        string json = r.ReadToEnd();
        List<string> words = JsonConvert.DeserializeObject<List<string>>(json);
        return words;
      }
    }

    public List<string> SearchForChar(string userInput, List<string> words)
    {
      List<string> matchList = new List<string>{};
      char [] inputArray = userInput.ToCharArray();
      for (int i=0; i<=(words.Count-1); i++)
      {
        if(words[i].Contains(inputArray[0].ToString()))
        {
          matchList.Add(words[i]);
        }
      }
      return matchList;
    }
  }
}
