using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace guessing
{
    class Florida
    {
        //question to ask user that is randomize in Programs
        private string[] quest = new string[11] { "When did Florida become part of the United states?: ",
                                                  "What is the capital of Florida?: ",
                                                  "True or False, Florida has more toll roads and bridges than any other state in the Union: ",
                                                  "What is the Fern Capital of the World. Provide answer with city, state",
                                                  "How many feet above sea level is the highest point in Florida?",
                                                  "True or False: Florida has more golf courses than any other state and is home to the World Golf Hall of Fame and Museum in St. Augustine.",
                                                  "True or False: Florida’s largest river, the St. Johns River, is one of only a few major rivers that flow from south to north.",
                                                  "True or False: Florida is the second largest producer of watermelons in the country. It also produces the most tomatoes, strawberries and sugar.",
                                                  "What is the largest city in the United States in terms of area?",
                                                  "What is Florida's nickname?",
                                                  "Who is the current Governor of Florida?: "
                                                 };

         public string[]Quest
        {
            
            
            get { return quest; }
            set { quest = value; }
            
        }
      
        //answer to question from array quest
      private string[] ans = new string[11] { "1821",
                                              "tallahassee",
                                              "true",
                                              "Pierson, Florida",
                                              "345 ",
                                              "true",
                                              "true",
                                              "false",
                                              "jacksonville",
                                              "the sunshine state",
                                              "Ron DeSantis"
                                             };
                
        public string[] Ans
        {
            get { return ans; }
            set { ans = value; }
        }
            

            


        
    }
}
