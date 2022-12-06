using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4Part2_SammiRoy
{
    internal class MultipleChoiceQuestion
    {
        // Fields
        private string _questionText;
        private string _answerText1;
        private string _answerText2;
        private string _answerText3;
        private string _answerText4;
        private int _correctAnswer;

        // Properties
        public string QuestionText
        {
            get
            {
                return _questionText;
            }

            set
            {
                _questionText = UtilityMethods.GetNonEmptyString(value);
            }
        }

        public string AnswerText1
        {
            get
            {
                return _answerText1;
            }
            set
            {
                _answerText1 = value;
            }
        }

        public string AnswerText2
        {
            get
            {
                return _answerText2;
            }
            set
            {
                _answerText2 = value;
            }
        }

        public string AnswerText3
        {
            get
            {
                return _answerText3;
            }
            set
            {
                _answerText3 = value;
            }
        }

        public string AnswerText4
        {
            get
            {
                return _answerText4;
            }
            set
            {
                _answerText4 = value;
            }
        }

        public int CorrectAnswer
        {
            get
            {
                return _correctAnswer;
            }

            set
            {
                _correctAnswer = value;
            }
        }

        // Constructors

        public MultipleChoiceQuestion()
        {

        }

        public MultipleChoiceQuestion()
    }
}
