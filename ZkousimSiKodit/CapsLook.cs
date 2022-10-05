namespace ZkousimSiKodit
{
    internal class CapsLock
    {
      
        public string changeCase(string stringToChange)
        {
            string changedString = "";
            char changedChar;
            foreach (char letter in stringToChange)
            {
                if (char.IsLower(letter))
                {
                    changedChar = char.ToUpper(letter);
                } else
                {
                    changedChar = char.ToLower(letter);
                }
                changedString += changedChar;
            }
            return changedString;
        }
    }
}
