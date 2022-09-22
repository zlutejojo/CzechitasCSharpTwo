namespace ZkousimSiKodit
{
    internal class CapsLook
    {
      
        public string changeCase(string stringToChange)
        {
            string changedString = "";
            char changedChar;
            foreach (char letter in stringToChange)
            {
                if (char.IsLower(letter)){
                    changedChar = char.ToUpper(letter);
                } else
                {
                    changedChar = char.ToLower(letter);
                }
                changedString = changedString + changedChar;
            }
            return changedString;
        }
    }
}
