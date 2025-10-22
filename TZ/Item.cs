using System;

namespace TZ
{
    public class Item
    {
        private int? id;
        private string name;
        private string code;
        private int dictionaryId;
        public Item() { }
        public Item(int? newId, int newDictionaryId, string newName, string newCode)
        { 
            Id = newId;
            Name = newName;
            Code = newCode;
            DictionaryId = newDictionaryId;
        }
        public int? Id
        {
            get { return id; }
            set
            {
                if (value >= 0 || value == null) id = value;
                else throw new Exception("incorrect id");
            }
        }
        public int DictionaryId
        {
            get { return dictionaryId; }
            set 
            {
                if (value >= 0) dictionaryId = value;
                else throw new Exception("incorrect dictionaryId");
            }
        }
        public string Code
        {
            get { return code; }
            set
            {
                if (value != null) code = value;
                else throw new Exception("incorrect code");
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value != null) name = value;
                else throw new Exception("incorrect name");
            }
        }
    }
}
