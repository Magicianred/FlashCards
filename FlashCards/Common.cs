/* Author       :   Mahasri Kalavala
 * Date         :   1/5/2019
 * Description  :   This application is written to help memorize many things
 *                  including languages, alphabets, words, formulas and more!
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards
{
    public class Common
    {
        public enum FormMode
        {
            Add,
            Edit
        }
    }

    public static class Constants
    {
        // Time related messages
        public static readonly string HOURS                 = "Hours";
        public static readonly string MINUTES               = "Minutes";
        public static readonly string SECONDS               = "Seconds";


        public static readonly string FLASHCARDS_TITLE      = "Flash Cards for {0}";
        public static readonly string FLASHCARDS_COUNT      = "{0} flash cards!";

        // Common Titles for Message Boxes
        public static readonly string TITLE_ATTENTION       = "Attention!";
        public static readonly string TITLE_GREATJOB        = "Great Job!";
        public static readonly string TITLE_MISSINGDATA     = "Missing Data";
        public static readonly string TITLE_CONFIRM_DELETE  = "Are you sure?";

        public static readonly string MSG_SELECT_ANSWER     = "Please select an answer to continue!";
        public static readonly string MSG_WRONG_ANSWER      = "You guessed the wrong answer! The correct Answer is:\n\n{0}";

        public static readonly string MSG_TOOLTIP_RIGHT     = "{0} Right";
        public static readonly string MSG_TOOLTIP_WRONG     = "{0} Wrong";

        public static readonly string MSG_FINISHED          = "You finished {0} cards in {1} Great job!!!\nDo you want to start over?";

        
        public static readonly string MSG_REQUIRED_DATA     = "Please fill in all the fields.";
        public static readonly string MSG_CONFIRM_DELETE    = "Are you sure, you want to delete the topic '{0}'?";


        // ERROR MESSAGES
        public static readonly string ERROR_LOADING_DATA    = "Error loading the data file!";
        public static readonly string ERROR_INVALID_JSON    = "Invalid JSON or Corrupted JSON file. \n\nPlease fix the JSON format and restart application.";
        public static readonly string ERROR_NO_DATA         = "Cannot find data file. Please make sure the file path is specified correctly in the FlashCards.exe.config file.";
        public static readonly string ERROR_NO_FILE         = "File '{0}' does not exist!";
    }
}