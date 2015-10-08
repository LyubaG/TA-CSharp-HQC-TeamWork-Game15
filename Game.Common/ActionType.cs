namespace Game.Common
{
    public struct ActionType
    {
        private string _name;

        public ActionType(string name)
            : this()
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this._name;
            }
            private set
            {
                this._name = value;
            }
        }

        public static bool operator ==(ActionType actionType1, string actionType2)
        {
            return actionType1.Name == actionType2;
        }

        public static bool operator !=(ActionType actionType1, string actionType2)
        {
            return actionType1.Name != actionType2;
        }

        public static ActionType Get(string name)
        {
            return new ActionType(name);
        }
    }
}