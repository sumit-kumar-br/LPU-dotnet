using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary
{
    public class SomeLogic
    {
        #region Attributes
        int id;
        string name;
        string addr;
        #endregion

        #region Properties
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Addr
        {
            get { return addr; }
            set { addr = value; }
        }

        #endregion

        public SomeLogic()
        {

        }

        public SomeLogic(int yourID, string yourName, string yourAddress)
        {
            id = yourID;
            name = yourName;
            addr = yourAddress;
        }

        #region Methods

        public int AddMe(int num1, int num2)
        {
            return num1 + num2;
        }

        public List<object> ShowAll()
        {
            return new List<object>();
        }
        public List<Player> ShowAllPlayers()
        {
            return new List<Player>()
            {
                new Player(){PlayerID=1,PlayerName="Virat",Skills={"Batsman","Fielder"}},
                new Player(){PlayerID=1,PlayerName="Rohit",Skills={"Batsman","Fielder"}},
                new Player(){PlayerID=1,PlayerName="Bumrah",Skills={"Fast Bowler","Fielder"}},
            };
        }

        #endregion
    }
}