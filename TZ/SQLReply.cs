using System;
using System.Collections.Generic;

namespace TZ
{
    internal static class SQLReply
    {
        private static List<List<String>> reply = new List<List<string>>();
        private static int length = 0;

        public static void Clear()
        {
            reply.Clear();
        }
        public static void AddRow(List<String> row)
        {
            if (length == 0)
            {
                length = row.Count;
                reply.Add(row);
            }
            else if (length == row.Count) reply.Add(row);
            else throw new Exception("incorrect items number");
        }
        public static List<List<String>> GetReply()
        {
            return reply;
        }
    }
}
