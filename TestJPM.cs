using System;
using System.Collections.Generic;
using System.Text;

namespace CodilitySamples
{
    public class TestJPM
    {

        public void fn()
        {
            char[] Word = new char[] { 'o', 'n', 'e' };
            string str = "fsdfds";


            for (int i = 0; i < Word.Length; i++)
            {
                if (str.Contains(Word[i]))
                {

                }
            }

        }
        public string Solution( string line)
        {
            Dictionary<int, ResultClass> staticData = new Dictionary<int, ResultClass>();
            staticData.Add(0, new ResultClass("zero"));
            staticData.Add(1, new ResultClass("one"));
            staticData.Add(2, new ResultClass("two"));
            //staticData.Add(3, new ResultClass("three"));
            //staticData.Add(4, new ResultClass("zero"));
            //staticData.Add(5, new ResultClass("zero"));
            //staticData.Add(6, new ResultClass("zero"));
            //staticData.Add(7, new ResultClass("zero"));
            //staticData.Add(8, new ResultClass("zero"));
            //staticData.Add(9, new ResultClass("zero"));
 
            char[] givenstring = line.ToCharArray();


            List<ResultClass> ObjList = new List<ResultClass>();

            for (int i = 0; i < staticData.Count - 1; i++)
            {
                for (int j = 0; j < givenstring.Length - 1; j++)
                {
                    for (int x = 0; x < staticData[i].Word.Length - 1; x++)
                    {
                        if (givenstring[j] == staticData[i].Word[x])
                        {
                            staticData[i].resultArray[x] = true;

                            bool setCount = true;
                            for (int z = 0; z < staticData[i].resultArray.Length-1; z++)
                            {
                                if (!staticData[i].resultArray[z]) { setCount = false; }
                            }
                            if (setCount)
                            {
                                staticData[i].Count += 1;
                            }
                        }
                    }
                }
            }

            StringBuilder final = new StringBuilder();

            for (int i = 0; i < staticData.Count; i++)
            {
                for (int j = 0; j < staticData[i].Count; j++)
                    if (staticData[i].Count > 0)
                    {
                        final.Append(staticData[i].ToString());
                    }
            }


            return final.ToString();
        }

    }
}


public class ResultClass
{
    public ResultClass(string value)
    {
        Word = value;
        resultArray = new bool[value.Length];
        Array.Fill(resultArray, false);
        Count = 0;
    }
    public string Word { get; set; }
    public bool[] resultArray { get; set; }
    public int Count { get; set; }
}
 
