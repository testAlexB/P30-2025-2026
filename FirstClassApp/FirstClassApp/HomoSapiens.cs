using System.ComponentModel;

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

        public void SetAge(int age)
        {
            age_ = age;
        }

        public int GetAge()
        {
            return age_;
        }
    }
}
