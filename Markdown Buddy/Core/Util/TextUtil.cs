namespace Markdown_Buddy.Core.Util
{
    class TextUtil
    {

        /// <summary>
        /// Inserts a string at the beginning and end of a string
        /// </summary>
        /// <param name="str">The string to insert into</param>
        /// <param name="ins">The string to insert</param>
        /// <returns>The resulting string</returns>
        public static string InsertBeginningEnd(string str, string ins)
        {
            str = str.Insert(0, ins);
            str = str.Insert(str.Length - 1, ins);
            return str;
        }

        /// <summary>
        /// Inserts a string at the beginning of string
        /// </summary>
        /// <param name="str">The string to insert into</param>
        /// <param name="ins">The string to insert</param>
        /// <returns>The resulting string</returns>
        public static string InsertBeginning(string str, string ins)
        {
            str = str.Insert(0, ins);
            return str;
        }

    }
}
