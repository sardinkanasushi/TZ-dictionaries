using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TZ
{
    public class Dictionary
    {
        public Dictionary() 
        {
            Id = null;
            ParantId = null;
            Name = "Имя";
            Code = "0";
            Description = null;
        }
        public Dictionary(int? newId,int? newParentId, string newName, string newCode, string newDescription)
        {
            Id = newId;
            ParantId = newParentId;
            Name = newName;
            Code = newCode;
            Description = newDescription;
        }

        private int? id;
        private int? parentId;
        private string name;
        private string code;
        private string description;
        public int? Id 
        {
            get { return id; }
            set 
            { 
                if (value >= 0 || value == null) id = value;
                else throw new Exception("incorrect id");
            }
        }
        public int? ParantId
        {
            get { return parentId; }
            set { parentId = value; }
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
        public string Code
        {
            get { return code; }
            set
            {
                if (value != null) code = value;
                else throw new Exception("incorrect code");
            }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
