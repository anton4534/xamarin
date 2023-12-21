using System;
using Xamarin.Forms;

namespace AppLifecycleTutorial
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        
        
        }

        protected override void OnAppearing()
        {
            //Метод OnAppearing возвращает значение свойства 
            //App.DisplayText и задает его как значение свойства TextEntry.


            base.OnAppearing();

            entry.Text = (Application.Current as App).DisplayText;

            //Переопределение метода OnAppearing выполняется после готовности ContentPage, 
            //но только прежде чем он станет видимым.Таким образом лучше всего 
            //    задать содержимое представлений Xamarin.Forms.
        }

        //Когда текст в Entry завершен с помощью ключа возврата, 
        //в свойстве App.DisplayTextвыполняется метод 
        //    OnEntryCompleted и хранится текст Entry.

        void OnEntryCompleted(object sender, EventArgs e)
        {
            (Application.Current as App).DisplayText = entry.Text;
        }
    }
}
