using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Logic
{
  public  class Deck
    {
      public int[] DeckValues { get; set; }

      public string ChangeCardUi(int i)
      {
          string path = Path.Combine(Environment.CurrentDirectory, @"Assets\Images\cards\Deck1");
          string[] fileEntries = Directory.GetFiles(path);
          string file="";
          if (i > 9)
          {
              i=10;
          }
          foreach (string fileName in fileEntries)
          {
              if (i > 1)
              {
                  if (fileName.Contains(i.ToString(CultureInfo.InvariantCulture)))
                  {
                      file = fileName;
                      break;
                  }
              }
              else if(i == 1)
              {

                  if (fileName.Contains("Ace"))
                  {
                      file = fileName;
                      break;
                  }
              }
             
          }
              
          return file;
      }


 
    }
}
