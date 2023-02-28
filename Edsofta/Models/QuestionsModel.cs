using Newtonsoft.Json;


namespace Edsofta.Models
{
    public class QuestionsModel
    {
        //Class Properties which are linked with the Json Keys
       [JsonProperty("id")] 
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty("question")]
        private string question;
        public string Question
        {
            get { return question; }
            set { question = value; }
        }

        [JsonProperty("a")]
        private string a ;
        public string OptionA
        {
            get { return  a; }
            set { a = value; }
        }

        [JsonProperty("b")]
        private string b;
        public string OptionB
        {
            get { return b; }
            set { b = value; }
        }

        [JsonProperty("c")]
        private string c;
        public string OptionC
        {
            get { return c; }
            set { c = value; }
        }

        [JsonProperty("d")]
        private string d;
        public string OptionD
        {
            get { return d; }
            set { d = value; }
        }

        [JsonProperty("e")]
        private string e;
        public string OptionE
        {
            get { return e; }
            set { e = value; }
        }
        [JsonProperty("answer")]
        private string correctAnswer;
        public string CorrectAnswer
        {
            get { return correctAnswer; }
            set { correctAnswer = value; }
        }
    }
}
