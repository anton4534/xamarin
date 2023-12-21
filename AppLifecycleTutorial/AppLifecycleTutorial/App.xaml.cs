using System;
using Xamarin.Forms;

namespace AppLifecycleTutorial
{
    public partial class App : Application
    {
        const string displayText = "displayText";
        public string DisplayText { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
        
        protected override void OnStart() /*при запуске приложения*/
        {
            Console.WriteLine("Стартовало приложение то");

            //Затем при запуске приложения, при условии, 
            //что словарь Properties содержит ключ displayText, 
            //значение ключа восстанавливается в свойство DisplayText.



            if (Properties.ContainsKey(displayText))
            {
                DisplayText = (string)Properties[displayText];
            }
        }

        protected override void OnSleep()/*когда приложение в фоновом режиме*/
        {
            //Когда приложение находится в фоновом режиме или завершает работу, 
            //метод OnSleep переопределяет значение свойства DisplayText словарю Properties 
            //ключом displayText.

            Console.WriteLine("Спим");
            Properties[displayText] = DisplayText;
        }

        protected override void OnResume()/*когда приложение выходит из фонового режима*/
        {
            Console.WriteLine("Проснулись");
        }
    }
}
