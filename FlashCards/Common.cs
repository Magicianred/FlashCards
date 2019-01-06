/* Author       :   Mahasri Kalavala
 * Date         :   1/5/2019
 * Description  :   This application is written to help memorize many things
 *                  including languages, alphabets, words, formulas and more!
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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

        public static string AssemblyDirectory
        {
            get
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }

        public static string DataFilePath {
            get
            {
                return Path.Combine(AssemblyDirectory, Constants.DATA_FILE_NAME);
            }
        }
    }

    public static class Constants
    {
        public static readonly string DATA_FILE_NAME        = "data.json";

        // Time related messages
        public static readonly string HOURS                 = "Hours";
        public static readonly string MINUTES               = "Minutes";
        public static readonly string SECONDS               = "Seconds";


        public static readonly string FLASHCARDS_TITLE      = "Flash Cards for {0}";

        // Common Titles for Message Boxes
        public static readonly string TITLE_ATTENTION       = "Attention!";
        public static readonly string TITLE_GREATJOB        = "Great Job!";
        public static readonly string TITLE_MISSINGDATA     = "Missing Data";
        public static readonly string TITLE_CONFIRM_DELETE  = "Are you sure?";

        public static readonly string MSG_SELECT_ANSWER     = "Please select an answer to continue!";
        public static readonly string MSG_WRONG_ANSWER      = "You guessed the wrong answer! The correct Answer is:\r\n\r\n{0}";

        public static readonly string MSG_TOOLTIP_RIGHT     = "{0} Right";
        public static readonly string MSG_TOOLTIP_WRONG     = "{0} Wrong";

        public static readonly string MSG_FINISHED          = "You finished {0} cards in {1} Great job!!!\nDo you want to start over?";
        
        public static readonly string MSG_REQUIRED_DATA     = "Please fill in all the fields.";
        public static readonly string MSG_CONFIRM_DELETE    = "Are you sure, you want to delete the topic '{0}'?";

        // ERROR MESSAGES
        public static readonly string TOPIC_ADD_FAILED      = "Unable to add a new Topic. The JSON file '{0}' is either corrupted or invalid. Please make sure you have read/write access to the file. Delete that file and try again?";
        public static readonly string TOPIC_EXISTS          = "A topic with name '{0}' already exists.";
        public static readonly string ERROR_LOADING_DATA    = "Error loading '{0}' file. The json is either corrupted or invalid. You can paste the contents of that file at https://jsonlint.com/ and make sure the content is a valid JSON.";
    }
}