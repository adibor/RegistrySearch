namespace SearchForm
{
    public class RegistryData
    {
        public string keyPath;
        public string value;


        public RegistryData(string keyPath, string value)
        {
            this.keyPath = keyPath;
            this.value = value;
        }

        override public string ToString()
        {
            return keyPath + " : " + value;
        }
    }

}
