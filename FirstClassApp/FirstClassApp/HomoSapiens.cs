namespace FirstClassApp
{
    public class HomoSapiens
    {
        /// описываем атрибуты - поля класса
        private string name_;
        private int age_;

        public string GetName()
        {
            return name_;
        }

        public void SetName(string name)
        {
            name_ = name;
        }
    }
}
