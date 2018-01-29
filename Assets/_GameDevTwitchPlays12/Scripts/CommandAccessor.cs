//using UnityEngine;

//namespace Remy.Commander
//{

//    public class CommandAccessor : DualBehaviour
//{


//        public Command GetCommandFrom(string userId, long timestamp, string rawMessage) {




//        }
    
    


//}




//    [System.Serializable]
//public class Command {


//        public Command(string _senderId, string _rawMessage, string _command, string _argument, bool isGeneratedByGame) {
//            m_senderId = _senderId;
//            m_rawMessage = _rawMessage;
//            m_rawMessage = _command;
//            m_rawMessage = _argument;
//            _generatedByGame = isGeneratedByGame;
//        }

//        [SerializeField]
//        private bool _generatedByGame;
        
//        [SerializeField]
//        private string m_senderId;

//        [SerializeField]
//        private string m_rawMessage;
//        [SerializeField]
//        private string m_commandType;
//        [SerializeField]
//        private string m_argument;
//        [SerializeField]
//        private long m_when;

//        public string GetRawMessage() { return m_rawMessage; }
//        public string GetCommandType() { return m_commandType; }
//        public string GetArgument() { return m_argument; }
//        public bool IsGeneratedByGame()
//        { return _generatedByGame; }
//        public long GetWhenGenerated() { return m_when; }
//    }



//    //public class MovingCommand : Command
//    //{
//    //    public MovingCommand(string _senderId, string _rawMessage, string _command, string _argument, bool isGeneratedByGame) : base(_senderId, _rawMessage, _command, _argument, isGeneratedByGame)
//    //    {
//    //    }

//    //    public enum MoveType { Up, Down, Left, Right}
//    //}
//    //public class JoinGameCommand : Command
//    //{
//    //    public JoinGameCommand(string _senderId, string _rawMessage, string _command, string _argument, bool isGeneratedByGame) : base(_senderId, _rawMessage, _command, _argument, isGeneratedByGame)
//    //    {
//    //    }
//    //}

//    //public class DigCommand : Command
//    //{
//    //    public DigCommand(string _senderId, string _rawMessage, string _command, string _argument, bool isGeneratedByGame) : base(_senderId, _rawMessage, _command, _argument, isGeneratedByGame)
//    //    {
//    //    }
//    //}
//    //public class InvestInLevelCommand : Command
//    //{
//    //    public InvestInLevelCommand(string _senderId, string _rawMessage, string _command, string _argument, bool isGeneratedByGame) : base(_senderId, _rawMessage, _command, _argument, isGeneratedByGame)
//    //    {
//    //    }
//    //}
//    //public class Stun : Command
//    //{
//    //    public Stun(string _senderId, string _rawMessage, string _command, string _argument, bool isGeneratedByGame) : base(_senderId, _rawMessage, _command, _argument, isGeneratedByGame)
//    //    {
//    //    }
//    //}
//    //public class Sprain : Command
//    //{
//    //    public Sprain(string _senderId, string _rawMessage, string _command, string _argument, bool isGeneratedByGame) : base(_senderId, _rawMessage, _command, _argument, isGeneratedByGame)
//    //    {
//    //    }
//    //}

//    //public class SendMessageToUser : Command
//    //{
//    //    public SendMessageToUser(string _senderId, string _rawMessage, string _command, string _argument, bool isGeneratedByGame) : base(_senderId, _rawMessage, _command, _argument, isGeneratedByGame)
//    //    {
//    //    }

        
//    //}
//    //public class SendMessageToAll : Command
//    //{
//    //    public SendMessageToAll(string _senderId, string _rawMessage, string _command, string _argument, bool isGeneratedByGame) : base(_senderId, _rawMessage, _command, _argument, isGeneratedByGame)
//    //    {
//    //    }
//    //}




//}