namespace site.snapper.dynamo
{
    public class ChecklistItem
    {  
        public string Title { get; set; }

        public string SectionName { get; set; }

        public bool PhotoRequired { get; set; }

        public By CompletedBy { get; set; }

        public DateTime CompletedAt { get; set; }

        public bool IsCompleted { get; set; }

        public List<string> Images { get; set; }

        public List<QuestionYesNo> YesNoQuestions { get; set; }

        public List<QuestionRating> QuestionRatings { get; set; }

        public List<QuestionText> QuestionTexts { get; set; }

        public List<QuestionMultiple> QuestionMultiples { get; set; }

    }

    public class QuestionYesNo {

        public string Description { get; set; }

        public YesNoEnum Value { get; set; }
        public enum YesNoEnum { 
          YES,
          NO,
          NA
        }

    }


    public class QuestionRating {
        public string Description { get; set; }

        public int Value { get; set; }
    }

    public class QuestionText {
        public string Description { get; set; }

        public string Value { get; set; }
    }

    public class  QuestionMultiple
    {
        public string Description { get; set; }

        public List<QuestionMultipleChoice> QuestionMultipleChoices { get; set; }

    }

    public class QuestionMultipleChoice {
        public string Description { get; set; }

        public bool Checked { get; set; }
    }


}
